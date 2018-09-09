using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // String z = "25-5*3/5+10+35/7+45/9+3;";

                while (true)
                {
                    Console.WriteLine("Please, enter the expression.");
                    String z = Console.ReadLine();
                    z = z + ";";

                    String[] mass = getExpFromLine(z);

                    String[] mass2 = mass;
                    mass2 = whileHighPrio(mass2);

                    mass2 = whileLowPrio(mass2);

                    Console.Write("Answer:");
                    foreach (String gg in mass2)
                    {
                        Console.WriteLine(gg);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something comes wrong. Let's just continue.");
            }
        }

        public static double addition(double a, double b)
        {
            return a + b;
        }

        public static double subtraction(double a, double b)
        {
            return a - b;
        }

        public static double division(double a, double b)
        {
            return a / b;
        }

        public static double multiplication(double a, double b)
        {
            return a * b;
        }


        public static String[] whileHighPrio(String[] lines)
        {
            String[] lines2 = lines;
            int how_much = 0;
            foreach (String z in lines)
            {
                if (z == "*" || z == "/")
                {
                    how_much++;
                }
            }

            for (int i = 0; i < how_much; i++)
            {
                lines2 = whenHighPrio(lines2);
            }

            return lines2;
        }

        public static String[] whileLowPrio(String[] lines)
        {
            String[] lines2 = lines;
            int how_much = 0;
            foreach (String z in lines)
            {
                if (z == "+" || z == "-")
                {
                    how_much++;
                }
            }

            for (int i = 0; i < how_much; i++)
            {
                lines2 = whenLowPrio(lines2);
            }

            return lines2;
        }


        public static String[] whenHighPrio(String[] line)
        {
            String[] line2 = new string[line.Length - 2];
            String res = "";

            int exPlace = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == "*")
                {
                    exPlace = i;
                    res = multiplication(Convert.ToDouble(line[i - 1]), Convert.ToDouble(line[i + 1])).ToString();
                    break;
                }
                if (line[i] == "/")
                {
                    exPlace = i;
                    res = division(Convert.ToDouble(line[i - 1]), Convert.ToDouble(line[i + 1])).ToString();
                    break;
                }

            }

            line[exPlace - 1] = res;

            for (int i = 0; i < line2.Length; i++)
            {
                if (i <= exPlace - 1)
                {
                    line2[i] = line[i];
                }
                else
                {
                    line2[i] = line[i + 2];
                }

            }

            return line2;
        }

        public static String[] whenLowPrio(String[] line)
        {
            String[] line2 = new string[line.Length - 2];
            String res = "";

            int exPlace = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == "+")
                {
                    exPlace = i;
                    res = addition(Convert.ToDouble(line[i - 1]), Convert.ToDouble(line[i + 1])).ToString();
                    break;
                }
                if (line[i] == "-")
                {
                    exPlace = i;
                    res = subtraction(Convert.ToDouble(line[i - 1]), Convert.ToDouble(line[i + 1])).ToString();
                    break;
                }

            }

            line[exPlace - 1] = res;

            for (int i = 0; i < line2.Length; i++)
            {
                if (i <= exPlace - 1)
                {
                    line2[i] = line[i];
                }
                else
                {
                    line2[i] = line[i + 2];
                }

            }

            return line2;
        }

        public static String[] getExpFromLine(String line)
        {
            char[] k = line.ToCharArray();

            List<String> lines = new List<String>();

            String element = "";

            foreach (char n in k)
            {
                if (n != '+' && n != '-' && n != '*' && n != '/' && n != ';')
                {
                    element += n.ToString();
                }
                else if (n == ';')
                {
                    lines.Add(element);
                }
                else
                {
                    lines.Add(element);
                    lines.Add(n.ToString());
                    element = "";
                }
            }

            String[] mass = lines.ToArray();

            return mass;
        }
    }
}
