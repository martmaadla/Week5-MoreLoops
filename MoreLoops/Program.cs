using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "adim1234";
            //siis konsoolis kuvatakse "Tere Tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";
            
            int tries = 3;
            Console.WriteLine("Welcome to this console application");

            login:
            Console.WriteLine("Username:");
            Console.Write(">");
            string userName = Console.ReadLine();
            Console.WriteLine("Password:");
            Console.Write(">");
            string password = Console.ReadLine();
            Console.WriteLine();

            if (userName == "admin" && password == "admin1234")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                tries -= 1;
                if (tries > 0)
                {
                    Console.WriteLine("Wrong username or password. Try again");
                    Console.WriteLine("You have " + tries + " retries left");
                    goto login;
                }
                else
                {
                    Console.WriteLine("Too bad. You can't log in anymore.");
                }
            }

            Console.ReadLine();
        }
    }
}
