using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TE.ActivityFinder.Lib.CodeGen.Common;

namespace TE.ActivityFinder.Lib.CodeGen.JSService
{
    public class GenRestful
    {
        #region Properties
        private string _serviceUrl { get; set; }
        private ResponseFormat _responseFormat { get; set; }
        private string _assemblyPath { get; set; }
        private string _serviceType { get; set; }
        public string _outputJScriptPath { get; set; }
        #endregion

        #region Init
        public GenRestful(string assemblyPath, string serviceType, string serviceUrl, string responseFormat, string outputJScriptPath)
        {
            _serviceUrl = serviceUrl;
            _serviceType = serviceType;
            _assemblyPath = assemblyPath;
            _outputJScriptPath = outputJScriptPath;
            _responseFormat = (ResponseFormat)Enum.Parse(typeof(ResponseFormat), responseFormat);
        }
        #endregion

        #region Public Methods
        public void CreateJScript()
        {
            string jScript = string.Empty;
            string jScriptName = string.Empty;
            Console.WriteLine("CodeGen: get assemblies");
            string currentPath = new FileInfo(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName).DirectoryName + "\\";
            string assPath = new FileInfo(_assemblyPath).DirectoryName;

            CopyDlls(currentPath, assPath);

            List<string> dllList = Directory.GetFiles(assPath, "*." + _serviceType + ".dll").ToList();
            if (dllList.Count > 0)
            {
                foreach (string assemblyFile in dllList)
                {
                    jScript = GenRestFulService(assemblyFile, ref jScriptName);
                    WriteScriptToFileSystem(jScript, jScriptName);
                }
            }
            else
            {
                Console.WriteLine("CodeGen: no assemblies of type " + _serviceType + " found");
            }

        }

        private static void CopyDlls(string currentPath, string assPath)
        {
            List<string> allDllList = Directory.GetFiles(assPath, "*.dll").ToList();
            foreach (string file in allDllList)
            {
                string fileName = currentPath + new FileInfo(file).Name;

                FileInfo info = new FileInfo(file);
                // Skip the code gen assembly
                if (info.Name != "TE.ActivityFinder.Lib.CodeGen.Common.dll")
                {
                    try
                    {
                        if (!File.Exists(fileName))
                        {
                            if ((info.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                            {
                                info.Attributes &= ~FileAttributes.ReadOnly;
                            }
                            File.Delete(fileName);
                        }

                        File.Copy(file, fileName, true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("CodeGen: error copying files - " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Private Methods
        private string GenRestFulService(string assemblyFile, ref string jScriptName)
        {
            StringBuilder sb = new StringBuilder();
            List<Type> TypeList;

            Console.WriteLine("CodeGen: load and reflect assembly: " + assemblyFile);
            TypeList = Assembly.LoadFile(assemblyFile).GetTypes().Where(t => t.IsPublic).Where(t => !t.IsInterface).ToList();
            Console.WriteLine("CodeGen: found " + TypeList.Count() + " service(s)");

            foreach (Type t in TypeList)
            {
                jScriptName = t.FullName;
                foreach (MethodInfo mi in GetMethodList(t))
                {
                    bool hasParam = false;
                    bool isFirst = true;

                    sb.Append("function " + mi.Name + "(");
                    foreach (ParameterInfo pi in mi.GetParameters())
                    {
                        hasParam = true;
                        sb.Append(pi.Name + ",");
                    }
                    if (hasParam)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                    sb.Append("){");
                    sb.Append("\r\n\t");

                    foreach (Attribute attr in mi.GetCustomAttributes(true))
                    {
                        if (attr is CodeGenAttributes)
                        {
                            sb.Append("Type = " + @"""" + (attr as CodeGenAttributes).CodeGenJSTypeEnum.ToString() + @""";");
                        }
                    }

                    sb.Append("\r\n\t");
                    sb.Append("Url = " + @"""" + _serviceUrl + t.Name + ".svc/" + mi.Name);

                    if (mi.GetParameters().Count() > 0)
                    {
                        foreach (ParameterInfo pi in mi.GetParameters())
                        {
                            if (isFirst)
                            {
                                sb.Append(@"/""+" + pi.Name);
                                isFirst = false;
                            }
                            else
                            {
                                sb.Append(@"+""/""+" + pi.Name);
                            }
                        }
                        sb.Append(";");
                    }
                    else
                    {
                        sb.Append(@""";");
                    }

                    sb.Append("\r\n\t");
                    sb.Append("ContentType = " + @"""" + "application/" + _responseFormat.ToString() + "; charset=utf-8" + @""";");
                    sb.Append("\r\n\t");
                    sb.Append("DataType = " + @"""" + _responseFormat.ToString() + @""";");
                    sb.Append("\r\n\t");
                    sb.Append("ProcessData = false;");
                    sb.Append("\r\n\t");
                    sb.Append("method = " + @"""" + mi.Name + @""";");
                    sb.Append("\r\n\t");
                    sb.Append("CallService();");
                    sb.Append("\r\n");
                    sb.Append("}\r\n");
                }
            }
            return sb.ToString();
        }
        private List<MethodInfo> GetMethodList(Type assemblyType)
        {
            var methodList = assemblyType.GetMethods().ToList().FindAll(mi => (mi.IsPublic && !mi.Name.Equals("ToString")
                && !mi.Name.Equals("Equals") && !mi.Name.Equals("GetType") && !mi.Name.Equals("GetHashCode")));
            Console.WriteLine("CodeGen: found " + methodList.Count() + " method(s)");
            return methodList;
        }
        private void WriteScriptToFileSystem(string script, string filename)
        {
            using (StreamWriter file = new StreamWriter(_outputJScriptPath + @"\" + filename + ".js"))
            {
                System.Console.WriteLine("CodeGen: writing to file " + _outputJScriptPath + @"\" + filename + ".js");
                file.Write(script);
                System.Console.WriteLine("CodeGen: write complete");
            }
        }
        #endregion
    }

    #region Enum ResponseFormat
    public enum ResponseFormat
    {
        json,
        xml
    }
    #endregion
}
