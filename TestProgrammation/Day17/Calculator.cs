using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day17
{
    class Calculator
    {
        internal int power(int n, int p)
        {

            if (n < 0 | p < 0)
                throw new Exception("n and p should be non-negative");
            else
            {

                return (int)Math.Pow(n, p);
            }
        }
    }
}
