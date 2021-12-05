using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsool kuvatakse "Tere tulemast!";
            //muud konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti".
            //kasutajal on kolm katset. 
            int i = 3;

            while (i > 0)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti. Teil on jäänud {i-1} katset");
                    i--;
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
            }
            Console.WriteLine("Teil pole rohkem katset");

        }
    }
}
