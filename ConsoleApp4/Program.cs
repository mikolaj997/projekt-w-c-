﻿using System;

namespace ToToLotek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numery = new int[6];

            Random generator = new Random();
            int index = 0;
            bool losujKolejne;
            do
            {
                numery[index] = generator.Next(1, 50);
                losujKolejne = true;
                for (int i = 0; i < index; i++)
                {
                    if (numery[index] == numery[i])
                    {
                        losujKolejne = false;
                        break;
                    }
                    
                }
                if (losujKolejne)
                {
                    index++;
                }
                

            } while (index < numery.Length);

            Console.WriteLine("Wylosowane liczby to: ");


            foreach (int numer in numery)
            {
                Console.Write(numer + ", ");
                  if (numer == 6)
                {
                    Console.WriteLine("wygrałeś");
                }
                  else { Console.WriteLine("próbój dalej"); }
            }
           

            Console.ReadKey();
        }
    }
}
