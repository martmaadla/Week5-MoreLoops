using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salaõna on "admin1234";
            //siis konsoolis kuvatakse "Tere tulemast!"; 
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";

            //OR (või) || (pipes)

            // true || true --> true
            // false || true --> true
            // true|| false --> true
            // false || false --> false

            Console.WriteLine("Sisetage kasutajatunnus:");
            string userName = Console.ReadLine(); //salvestab vahemälusse
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine(); //salvestab vahemälusse

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere Tulemast!");
            }

            //"admin1" != "admin" || "admin1234" != "admin1234" --> true || false --> true
            //"admin" != "admin" || "admin12345" != "admin1234" --> false || true --> true
            //"admin1" != "admin" || "admin12345" != "admin1234" --> false || false --> true
            //"admin" != "admin" || "admin1234" != "admin1234" --> true || true --> false

        }
    }
}
