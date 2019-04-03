using System;
using System.Threading;
using SteckbriefTool.SteckbriefKlassen;
using System.IO;
using System.Text;

namespace SteckbriefTool
{
    class Program
    {
        private static Steckbrief steckbrief = new Steckbrief();

        public static void Main()
        {
            Console.Title = "Steckbrief-Tool von Tobi, Alex & Julian | v1.0.0";

            Formatting.TextMitFarbe(Formatting.ASCII, ConsoleColor.Green, true);
            // Steckbriefinfos
            steckbrief.Ausgeben();
            Console.WriteLine("Legende: F1 = Steckbrief speichern, F2 = Programm schließen\n");
            OptionenAusgeben();

            Thread.Sleep(-1);
        }

        private static void OptionenAusgeben()
        {
            // Optionen auflisten
            Console.WriteLine("Bitte gib die Zahl für den Wert ein, den du bearbeiten willst!");
            Console.WriteLine(" 1) Name");
            Console.WriteLine(" 2) Stadt");
            Console.WriteLine(" 3) Alter\n");
            Console.Write("Deine Auswahl: ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Write("\nDu willst den Namen ändern. Gib einen neuen ein: ");
                    string neuerName = Console.ReadLine();
                    if (Prüfer.StringCheck(neuerName))
                        steckbrief.Name = neuerName;
                    else
                    {
                        Console.WriteLine("Dieser Name ist nicht gültig!");
                        Thread.Sleep(1500);
                    }
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.Write("\nDu willst die Stadt ändern. Gib eine neue ein: ");
                    string neueStadt = Console.ReadLine();
                    if (Prüfer.StringCheck(neueStadt))
                        steckbrief.Stadt = neueStadt;
                    else
                    {
                        Console.WriteLine("Diese Stadt ist nicht gültig!");
                        Thread.Sleep(1500);
                    }
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.Write("\nDu willst das Alter ändern. Gib ein neues ein: ");
                    int neuesAlter;
                    if (Int32.TryParse(Console.ReadLine(), out neuesAlter) && Prüfer.AlterCheck(neuesAlter))
                        steckbrief.Alter = neuesAlter;
                    else
                    {
                        Console.WriteLine("Dieses Alter ist nicht gültig!");
                        Thread.Sleep(1500);
                    }
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.F1:
                    // TODO: Prüfen, ob der Steckbrief leer ist. Falls ja => Nicht speichern!
                    File.WriteAllText("steckbrief_" + steckbrief.Name + ".txt", steckbrief.SteckbriefInhalt, Encoding.UTF8);
                    Console.WriteLine("\nDatei erfolgreich gespeichert!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Main(); // rekursiv
                    break;
                case ConsoleKey.F2:
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("\nUngültige Eingabe!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Main(); // rekursiv
                    break;
            }
        }
    }
}
