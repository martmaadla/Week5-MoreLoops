using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard in the hall.;

            string message = "I will not skateboard in the hall.".ToUpper();  // ToUpper - suurte tähtetega

            for (int i = 0; i < 10; i++) //init i = 0 (- start); i<10 (-end); i++ = i+1 (-step)
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the hall.".ToUpper());
            }
            Console.WriteLine("Lõpp");
        }
    }
}
