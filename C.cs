using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class C
    {
        public void Display()
        {
             //var a =  new A();
            var a = D.CreateAObject();
            a.Display("calling from C");
        }
    }
}
