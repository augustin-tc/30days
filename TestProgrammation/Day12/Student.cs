using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day12
{
    class Student: Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int identification, int[] TestScores): base(firstName, lastName, identification)
        {          
            testScores = TestScores;
        }
        internal string calculate()
        {
            int sum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }
            int avg = sum / testScores.Length;

            if (avg >= 90 && avg <= 100)
                return "O";
            else if (avg >= 80 && avg <= 90)
                return "E";
            else if (avg >= 70 && avg <= 80)
                return "A";
            else if (avg >= 55 && avg <= 70)
                return "P";
            else if (avg >= 40 && avg <= 55)
                return "D";
            else if (avg < 40)
                return "T";
            else return "Error";

        }

       
    }
}
