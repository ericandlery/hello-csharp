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
    }
}
