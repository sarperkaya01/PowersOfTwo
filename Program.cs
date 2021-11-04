using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstelSayu
{
    class Program
    {
        static long deger(long a)
        {
            bool b = true;


            while (b)
            {
                if (a % 2 == 0)
                {
                    a = a / 2;

                    Console.WriteLine(a);
                    if (a == 1)
                    {
                        break;

                    }
                }
                else
                {
                    b = false;


                }
            }
            if (b == true)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
            }

            return a;
        }
        static void Main(string[] args)
        {
            long a = Convert.ToInt32(Console.ReadLine());

            deger(a);


            Console.ReadLine();
        }

    }
}


