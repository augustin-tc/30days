using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day14
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] e)
        {
            elements = e;
        }

        internal void computeDifference()
        {

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {

                    int diff = Math.Abs(elements[i] - elements[j]);
                    if (diff > maximumDifference)
                        maximumDifference = diff;
                }
            }

            /* recommended approach
             * 
            * int n=elements.size();
            int min=100;
            int max=1;

            for(int i=0;i<n;++i)
            {
                if(elements[i]<min){min=elements[i];}
                if(elements[i]>max){max=elements[i];}
            }
            maximumDifference=max-min;
            */


        }
    }
}
