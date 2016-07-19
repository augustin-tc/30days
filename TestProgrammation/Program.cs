using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starway(10);
            //Console.WriteLine(sum(new int[] { 3, 6, 4,8 }));
            //Day2();
            //Day3();
            //Day4();
            //Day5();
            //Day6();
            //Day7();
            //Day8();
            //Day9();
            //Day10();
            //Day11();
            Day12();
            Console.Read();
        }

        private static void Day12()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Day12.Student s = new Day12.Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");

        }

        private static void Day11()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
               string[] arr_temp = "1 1 1 0 0 0".Split(' ');
            //string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);

            }

            arr[0] = Array.ConvertAll("-1 -1 0 -9 -2 -2".Split(' '), Int32.Parse);
            arr[1] = Array.ConvertAll("-2 -1 -6 -8 -2 -5".Split(' '), Int32.Parse);
            arr[2] = Array.ConvertAll("-1 -1 -1 -2 -3 -4".Split(' '), Int32.Parse);
            arr[3] = Array.ConvertAll("-1 -9 -2 -4 -4 -5".Split(' '), Int32.Parse);
            arr[4] = Array.ConvertAll("-7 -3 -3 -2 -9 -9".Split(' '), Int32.Parse);
            arr[5] = Array.ConvertAll("-1 -3 -1 -2 -4 -5".Split(' '), Int32.Parse);

            //parcourir patterns
            int sumMax = 0;
            bool changed = false;
            int tempSum = 0;
            for (int i = 0; i < 4; i++)
            {
                //arr[i] = [0 1 0 1] 
                for (int j = 0; j < 4; j++)
                {
                    tempSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (!changed || tempSum > sumMax)
                    {
                        changed = true;
                        sumMax = tempSum;
                    }

                }

                
            }

            Console.WriteLine(sumMax);

        }

        private static void Day10()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> binarynumbers = new List<int>();
            while (n > 0)
            {
                int reminder = n % 2;
                binarynumbers.Add(reminder);
                n = n / 2;
            }
            int maxNumber = 0;
            int TempmaxNumber = 0;
            for (int i = 0; i < binarynumbers.Count; i++)
            {
                if (binarynumbers[i] == 1)
                {
                    TempmaxNumber++;
                    if (TempmaxNumber > maxNumber)
                        maxNumber = TempmaxNumber;
                }
                else if (binarynumbers[i] == 0)
                    TempmaxNumber = 0;
            }

            Console.WriteLine(maxNumber);
        }

        private static void Day9()
        {
            //factorial
            Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
        }
        private static int Factorial(int n)
        {
            if (n > 1)
                return n * Factorial(n - 1);
            else return 1;
               
        }

        private static void Day8()
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < N; i++)
            {
                string entry = Console.ReadLine();
                dic.Add(entry.Split(' ')[0], entry.Split(' ')[1]);

            }
            bool test = true;
            
            while (test == true)
            {
                string query = Console.ReadLine();
                if (!string.IsNullOrEmpty(query))
                {
                    if (dic.ContainsKey(query))
                    {
                        Console.WriteLine(query + "=" + dic[query]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
                else test = false;
                      
            }
        
        }

        private static void Day6()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string s = Console.ReadLine();
                string odd = "";
                string even = "";
                for (int j = 0; j < s.Length; j++)
                {
                    if (j%2 !=0)//odd
                    {
                        odd += s[j];
                    }
                    else //even
                    {
                        even += s[j];
                    }
                }
                Console.WriteLine(even + " " + odd);
            }
        }

        static void Day7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            string output = "";

            for (int i = arr.Length-1 ;i >= 0; i--)
            {
                output += arr[i] + " ";
            }
            Console.WriteLine(output.Trim());
         
        }

        static void Day5()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(N + " x " + i + " = " + (i*N));
            }

        }


        static void Day1()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int intVar;
            double doubleVar;
            string stringVar;
            // Read and save an integer, double, and String to your variables.
            intVar = int.Parse(Console.ReadLine());
            doubleVar = double.Parse(Console.ReadLine());
            stringVar = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i+intVar);
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + doubleVar).ToString("0.0"));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + stringVar);
            // The 's' variable above should be printed first.
        }

        static void Day4()
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }

        static void Day3()
        {
            uint N = uint.Parse(Console.ReadLine());
            if (N <= 100)
            {
                if (N % 2 != 0)
                    Console.WriteLine("Weird");
                else if (N >= 2 && N <= 5)
                    Console.WriteLine("Not Weird");
                else if (N >= 6 && N <= 20)
                    Console.WriteLine("Weird");
                else if (N > 20)
                    Console.WriteLine("Not Weird");
            }

        }
        static void Day2()
        {
            double mealcost = double.Parse(Console.ReadLine());
            double tipPercent = double.Parse(Console.ReadLine());
            double taxPercent = double.Parse(Console.ReadLine());
            double total;

            double tipValue = mealcost * (Math.Round((double)tipPercent / 100, 2));
            double taxValue = mealcost * (Math.Round((double)taxPercent / 100,2));
            total = mealcost + tipValue + taxValue;

            total = Math.Round(total);

            Console.WriteLine("The total meal cost is {0} dollars.", total);

        }

        static int sum(int[] numbers)
        {
            int sum = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0)
                    sum += numbers[i];


            }
            return sum;
        }


        static void Starway(int n)
        {
            //pour chaque ligne 
            for (int i = 1; i <=n ; i++)
            {
                string line = "";

                for (int j = 0; j < n - i; j++)
                {
                    line += " ";
                }

                for (int j = 0; j < i; j++)
                {
                    line += "#";
                }

                Console.WriteLine(line);
            
            }
        }
    }
}
