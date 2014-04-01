using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.ActivityFinder.Lib.CodeGen.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new string[5];
            //args[0] = @"C:\GitHub\TE.ActivityFinder\WCF\TE.ActivityFinder.WCF\bin\"; //assembly path to reflect
            //args[1] = "WCF"; //service type 
            //args[2] = "http://10.211.55.3/TE.ActivityFinder.WCF/"; //service url
            //args[3] = "json"; //response format
            //args[4] = @"c:\temp\"; //output file

            System.Console.WriteLine("CodeGen: start codeGen console...");

            if (args.Count() == 5)
            {
                System.Console.WriteLine("CodeGen: log parameters...");
                System.Console.WriteLine("CodeGen: assembly path: " + args[0]);
                System.Console.WriteLine("CodeGen: service type: " + args[1]);
                System.Console.WriteLine("CodeGen: service url: " + args[2]);
                System.Console.WriteLine("CodeGen: response format: " + args[3]);
                System.Console.WriteLine("CodeGen: output path: " + args[4]);
                System.Console.WriteLine("CodeGen: end log parameters");

                var GenRestService = new JSService.GenRestful(args[0], args[1], args[2], args[3], args[4]);
                GenRestService.CreateJScript();
            }
            else
            {
                System.Console.WriteLine("CodeGen: console EXPECTS 5 INPUT ARGUMENTS: (1) assembly path (2) service type (3) service url (4) response format (5) output path" );
            }

            System.Console.WriteLine("CodeGen: end codeGen console");

            //System.Console.ReadKey();
        }
    }
}
