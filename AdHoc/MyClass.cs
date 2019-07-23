using System;
using System.Collections.Generic;
using System.Text;

namespace AdHoc
{
    class MyClass
    {
        public int  GetMax(params int [] args)
        {
            int result = args[0];

            for (int i = 0; i< args.Length; i++)
            {
                if (result<args[i])
                {
                    result = args[i];
                }
            }
            return result;
        }
    }
}
