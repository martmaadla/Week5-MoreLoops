﻿using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salaõna on "admin1234";
            //siis konsoolis kuvatakse "Tere tulemast!"; 
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti.";
            //kasutajal on kolm katset

           
            int i = 0;

            while (i < 3)

            {
                Console.WriteLine("Sisetage kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                }
                else
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }

            }  

        }
    }
}
