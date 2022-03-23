using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class D
    {
        public static A CreateAObject()
        {
            return new A(1, "", 4);
        }
    }
}
