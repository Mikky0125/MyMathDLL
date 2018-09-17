using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathDLL
{
    public class MyMath
    {
        /// <summary>
        /// Int a + b
        /// </summary>
        public int Add (int a, int b)
        {
            return a + b;
        }
        public int Multiple (int a, int b)
        {
            return a * b;
        }
        public int Substract (int a, int b)
        {
            return a - b;
        }
        public int Divide (int a, int b)
        {
            return a / b;
        }

    }
}
