using System;
using System.Collections.Generic;
using System.Text;

namespace AdHoc
{
    class Constructor
    {
        private int field;

        public Constructor()
        {
            field = 5;
        }
        public void Show ()
        {
            Console.WriteLine(field);
        }
    }
}
