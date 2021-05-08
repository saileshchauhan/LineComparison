using System;

namespace Line_Comparison
{
 public class Program
    {
        public double lengthOne, lengthTwo;
        static void Main(string[] args)
        { 
            Distance lineOne = new Distance(1,1,2,2);
            double lengthOne = lineOne.GetDistance();
            Console.WriteLine("LengthOne"+lengthOne);
            Distance lineTwo = new Distance(1, 1, 3, 3);
            double lengthTwo = lineTwo.GetDistance();
            Console.WriteLine("LengthTwo  " + lengthTwo);

            //Equals Method
            EqualsMethod equalCheck = new EqualsMethod(lengthOne,lengthTwo);
            equalCheck.FunctionEqualsMethod();

            //CompareTo Method
            CompareToMethod compareCheck = new CompareToMethod(lengthOne,lengthTwo);
            compareCheck.FuncCompareToMethod();

        }
        
    }
}
