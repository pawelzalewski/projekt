﻿using System;

namespace Projekt
{
    public class Chapter_4
    {
        static Random rand = new Random();

        public static void PonownaNauka()
        {
            Program.Print("Po skończonej nauce, sprawdzasz wiadomość od starosty i okazuje się, że jutro sesja.", 60);
            Program.Print("Co robisz w tej sytuacji?");
            Program.Print("Twoja szansa na zdanie wynosi: ");
            Console.Write(Program.postac.szansa);
            Console.WriteLine("");
            CzyUczycSie();
        }

        public static void CzyUczycSie()
        {
            {
                Console.WriteLine("======================================================");
                Console.WriteLine();
                Console.WriteLine("| (I)dź pogłębiąć swoją wiedzę    (S)tarczy tej nauki |");
                Console.WriteLine();
                Console.WriteLine("======================================================");
                Console.WriteLine("Szansa na zdanie: {0}%", Program.postac.szansa);
                string odp = Console.ReadLine();
                if (odp.ToLower() == "i" || odp.ToLower() == "nauka")
                {
                    //nauka
                    int szansa = rand.Next(0, Program.postac.szansa) + rand.Next(1, 4);
                    Program.Print("Świetnie, twoja szansa na zdanie wzrosła o " + szansa + "%");
                    Program.postac.szansa += szansa;
                    Program.Print("Twoja szansa na zdanie to: " + Program.postac.szansa + "%");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                    Console.ReadKey();
                }
                else if (odp.ToLower() == "s" || odp.ToLower() == "starczy")
                {
                    //wywalone
                    Program.Print("Co w takim razie zamierzasz teraz zrobić?");
                    string zamiar = Console.ReadLine();
                    Program.Print("Czy napewno uważasz, że nie jest lepiej sie pouczyć? Sesja lada chwila!");
                    Console.WriteLine("==============================");
                    Console.WriteLine("| T(ak)                (N)ie |");
                    Console.WriteLine("==============================");
                    Program.Print("Szansa na zdanie: {0}%", Program.postac.szansa);
                    string odp1 = Console.ReadLine();
                    if (odp1.ToLower() == "t" || odp1.ToLower() == "tak")
                    {
                        int szansa = rand.Next(0, Program.postac.szansa) + rand.Next(1, 4);
                        Program.postac.szansa -= szansa;
                        Program.Print("W porządku, niestety, ale twoja szansa na zdanie zmalała o " + szansa + "%");
                        Program.Print("Szansa na zdanie: {0}%", Program.postac.szansa);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                        Console.ReadKey();
                    }
                    else if (odp1.ToLower() == "n" || odp1.ToLower() == "nie")
                    {
                        int szansa = rand.Next(0, Program.postac.szansa) + rand.Next(1, 4);
                        Console.WriteLine("Świetnie! Twoja szansa na zdanie wzrosła o " + szansa + "%");
                        Program.postac.szansa += szansa;
                        Console.WriteLine("Szansa na zdanie: {0}%", Program.postac.szansa);
                        Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować...");
                        Console.ReadKey();
                    }
                }
            }
            Console.Clear();
        }
    }
}