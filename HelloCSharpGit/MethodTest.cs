using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharpGit
{
    class MethodTest
    {
        /**
         * test ouput parameters
         **/
        public void GetOutput(int x,out int y)
        {
            y = x + 555;
        }

        // test refs
        public void SwapInt(int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // test refs
        public void SwapIntRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public int TestRecursive(int n,int x)
        {
            if (n > 1)
            {
                x = x * x;
            }else if (n <= 1)
            {
                return x;
            }
            n = n - 1;
            return TestRecursive(n, x);
        }

        public String StringTogether(ref String s1,ref String s2,out String so,out String numSo)
        {
            so = s1 + s2;
            try
            {
                numSo = (int.Parse(s1) - int.Parse(s2)).ToString();
            }
            catch (System.FormatException)
            {
                numSo = "";
                return "failed";
            }

            return "success";
        }

    }
}
