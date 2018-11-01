using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.ProtectedInternals
{
    public class SecondClass
    {
        protected internal class InnerSecondClass
        {
            string Name { get; set; }
            string Age { get; set; }
        }
    }
}
