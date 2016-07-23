using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day19
{
    public interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }
    class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {

            int i = n;
            int sum = 0;
            while (i > 0)
            {
                if (n%i == 0)
                    sum += i;
                i--;
            }
            return sum;
        }
    }
}
