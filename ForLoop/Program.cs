﻿using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboards in the halls. 

            string message = "I will not skateboards in the halls.".ToUpper();


            for(int i=0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}. I will not skateboards in the halls.".ToUpper());
            }
            Console.WriteLine("Kena päeva!");
        }
        
    }
}
