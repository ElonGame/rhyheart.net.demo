using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.PrivateProtecteds
{
    public class FirstClass
    {
        private protected class InnerFirstClass
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

    }
}
