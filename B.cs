using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class B
    {
        public void Display()
        {
          var a = D.CreateAObject(); // with DI
           // var a = new A(); // without DI
            a.Display("calling from B");
        }
    }
}
