using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number from range");
            int firstEl;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out firstEl) && firstEl > 0)
                {
                    break;
                }
                else Console.WriteLine("Try one more time");
            }





            Console.WriteLine("Please enter second number from range");
            int lastEl;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out lastEl) && lastEl > firstEl)
                {
                    break;
                }
                else Console.WriteLine("Try one more time");
            }


            Console.WriteLine("first = {0} second= {1}", firstEl, lastEl);

        }


        public static int Calculation(int firstEl, int lastEl)

        {
            int sum = 0;
            for (int i = firstEl; i < lastEl; i++)
            {

                if ((i % 3 == 0) && (i % 5 != 0))
                    sum = sum + i;

            }
            return sum;
        }



    }
}


