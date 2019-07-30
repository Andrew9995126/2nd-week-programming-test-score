using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_score_program_2nd_week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the score from your test out of 0 to 100");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 89 & num1 < 101)
                    { Console.WriteLine("Your mark is A+");
            }

            if (num1 > 79 & num1 < 90)
                    { Console.WriteLine("Your mark is A");
            }

            if (num1 > 69 & num1 < 80)
                    { Console.WriteLine("Your mark is B+");
            }

            if (num1 > 59 & num1 < 70)
                    { Console.WriteLine("Your mark is B");
            }

            if (num1 > 49 & num1 < 60)
                    { Console.WriteLine("Your mark is C");
            }

            if (num1 > 39 & num1 < 50)
                    { Console.WriteLine("Your mark is D");
            }

            if (num1 < 40)
            {
                Console.WriteLine("Your mark is F");
            }

            Console.ReadLine();
            

                

            
        }
    }
}
