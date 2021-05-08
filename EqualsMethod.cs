using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    class EqualsMethod
    {
        public double lengthOne, lengthTwo;

        public EqualsMethod(double lengthOne,double lengthTwo)
        {
            this.lengthOne = lengthOne;
            this.lengthTwo = lengthTwo;
        }
        public void FunctionEqualsMethod()
        {
            Console.WriteLine("Equal  " + lengthOne.Equals(lengthTwo));
        }
    }
}
