using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        public int factorial (int num)
        {
            int result;
            if(num == 1)
            {
                return 1;
            }else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            /* local variable definintion */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            double? num5 = null;
            double? num6 = 3.14157;
            double num7;

            //calling the FindMax method
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();

            //calling the factorial method
            Console.WriteLine("Factorial of 6 is : {0}", n.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
            Console.ReadLine();

            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();

            //Null Coalescing Operator (??)
            num7 = num5 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num7);

            num7 = num6 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num7);
            Console.ReadLine();
        }
    }
}
