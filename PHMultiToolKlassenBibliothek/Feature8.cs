﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PHMultiToolKlassenBibliothek
{
    class Feature8
    {
        public static void Feature8Funcion1()
        {
            Console.WriteLine("Feature8 SubSubMenue");


            string HauptAusw;

            bool Exit = false;
            bool Hmenue;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Objekt-Volumen Berechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: submenue\t->\tZurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können Sie das Volumen vom Würfel, Kugel, Pyramide und Prisma berechnen.\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Berechnung des Volumen von Objekt:\n");
                Console.WriteLine("\t1 - Kugel");
                Console.WriteLine("\t2 - Pyramide");
                Console.WriteLine("\t3 - Prisma\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Kugel();
                        break;

                    case "2":
                        Console.Clear();
                        Pyramide();
                        break;

                    case "3":
                        Console.Clear();
                        Prisma();
                        break;


                    case "submenue":
                        Console.Clear();
                        Hmenue = true;
                        break;
                    case "exit":
                        Exit = true;
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);
        }



        //              Oben nichts ändern
        // ------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------
        //                                  Kugel


        public static void Kugel()
        {
            double dou_radius = 0;
            double volumen = 0;
            bool parse_value;
            Console.WriteLine("Kugel");

            do
            {
                Console.WriteLine("Bitte geben sie Radius ein");
                string str_radius = Convert.ToString(Console.ReadLine());

                do
                {
                    parse_value = Double.TryParse(str_radius, out dou_radius);
                }
                while (parse_value == false);

                volumen = (3.14 * dou_radius) Math.Pow;));

                Console.WriteLine("Das Ergebnis lautet {0} 2^3 insgesamt");

            }
            while (true);
        }






        // -------------------------------------------------------------------------------------------------
        //                          Pyramide


        public static void Pyramide()
        {
            Console.WriteLine("Pyramide");
            double dou_höhe = 0;
            double dou_grundfläche = 0;
            double volumen = 0;
            bool parse_value;
            do
            {
                Console.WriteLine("Bitte geben sie Höhe ein");
                string str_höhe = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Bitte geben die Grundfläche ein");
                dou_grundfläche = Convert.ToDouble(Console.ReadLine());
                do
                {
                    parse_value = Double.TryParse(str_höhe, out dou_grundfläche);
                }
                while (parse_value == false);

                volumen = 1 / 3 * dou_grundfläche * dou_höhe;

                Console.WriteLine("Das Ergebnis lautet {0} 2^3");
            }
            while (true);
        }




        // -------------------------------------------------------------------------------------------------
        //                              Prisma      


        public static void Prisma()
        {
            Console.WriteLine("Prisma");
            Console.WriteLine("Bitte geben sie Höhe ein");
            do
            {
                string str_höhe = Console.ReadLine();
                double Volumen = 0;
                double dou_höhe = 0;
                double dou_grundfläche = 0;
                bool parse_value;
                do
                {
                    Console.WriteLine("Bitte geben sie die Grundfläche ein");
                    dou_grundfläche = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bitte geben die Höhe ein");
                    dou_höhe = Convert.ToDouble(Console.ReadLine());
                    parse_value = Double.TryParse(str_höhe, out dou_grundfläche);
                }
                while (parse_value == false);

                Volumen = dou_grundfläche * dou_höhe;
                Console.WriteLine("Die Ausgabe lautet {0} 2^3 insgesamt", Volumen);


            } while (true);
        }
    }
}
       
