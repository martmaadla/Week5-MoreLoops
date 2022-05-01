using System;

namespace TenToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsooli numbrid 10 kuni 1

            for (int i = 10; i < 10; i++) //init i = 0 (- start); i<10 (-end); i++ = i+1 (-step)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("Lõpp");
        }
    }
}
