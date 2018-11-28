using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharpGit.Class
{
    class StringUtil
    {
        public int i;
        public static int ii;
        public static string sss = "THIS_IS_STATIC";

        public static string ToUpper(string s)
        {
            ii++;
            return s.ToUpper();
        }
    }
}
