using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid 
            //programm kontrollib, kumb mängija viskas rohkem 
            //mängija, kes viskab rohkem - võitja
            //täringuid vasatakse kolm korda
            //programm kulutab võitjat

            Random rnd = new Random();


            int cpuScore = 0;
            int userScore = 0;
            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                if (cpuRandom < userRandom)
                {
                    userScore++;
                }
                else if (cpuRandom > userRandom)
                {
                    
                    cpuScore++;
                }
            }
            if (cpuScore >=  2)
            {
                Console.WriteLine("Arvuti on mangu voitnud " + cpuScore);
            }
            else if (userScore >= 2)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne! " + userScore);
            }
            else
            {
                Console.WriteLine("Viik");
                
            }
        }
    }
}
