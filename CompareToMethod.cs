using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison
{
    class CompareToMethod
    {
        public double lengthOne, lengthTwo;

        public CompareToMethod(double lengthOne, double lengthTwo)
        {
            this.lengthOne = lengthOne;
            this.lengthTwo = lengthTwo;
        }
        public void FuncCompareToMethod()
        {
            Console.WriteLine("Compariso Result "+lengthOne.CompareTo(lengthTwo));
        }
    }
}
