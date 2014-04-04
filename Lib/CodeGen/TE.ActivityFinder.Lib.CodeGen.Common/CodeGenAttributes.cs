using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Te.ActivityFinder.Lib.CodeGen.Common
{
    public class CodeGenAttributes : Attribute
    {
        protected CodeGenJSTypeEnum _enum;
        public CodeGenJSTypeEnum CodeGenJSTypeEnum
        {
            get
            {
                return this._enum;
            }
        }

        public CodeGenAttributes(CodeGenJSTypeEnum Description_in)
        {
            this._enum = Description_in;
        }
    }

    public enum CodeGenJSTypeEnum
    {
        GET,
        PUT,
        POST
    }
}
