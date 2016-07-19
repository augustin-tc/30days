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
            Day9();
            Console.Read();
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
