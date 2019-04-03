using System;
using System.Threading;

namespace SteckbriefTool.SteckbriefKlassen
{
    class Formatting
    {

        public static string ASCII = @"
                                              _____ ____ _______          _ 
                                             / ____|  _ \__   __|        | |
                                            | (___ | |_) | | | ___   ___ | |
                                             \___ \|  _ <  | |/ _ \ / _ \| |
                                             ____) | |_) | | | (_) | (_) | |
                                            |_____/|____/  |_|\___/ \___/|_|
        ";

        public static void ZentriereText(string text)
        {
            int consoleBreite = Console.WindowWidth;
            Console.SetCursorPosition((consoleBreite - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        public static void TextMitFarbe(string text, ConsoleColor c, bool animiert)
        {
            Console.ForegroundColor = c;
            if (animiert)
            {
                for(int i = 0; i < text.Length; i++)
                {
                    Thread.Sleep(3);
                    Console.Write(text[i]);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine(text);
            Console.ResetColor();
        }


    }
}
