using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteckbriefTool.SteckbriefKlassen
{
    class Steckbrief
    {
        // Felder
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Stadt { get; set; }

        public const int Einträge = 3;

        // Konstruktor
        public Steckbrief() { }

        /// <summary>
        /// test
        /// </summary>
        /// <param name="name"></param>
        /// <param name="alter"></param>
        /// <param name="stadt"></param>
        public Steckbrief(string name, int alter, string stadt)
        {
            // Felder zuweisen
            Name = name;
            Alter = alter;
            Stadt = stadt;
        }

        public void Ausgeben()
        {
            Formatting.ZentriereText("____________________________");
            Formatting.ZentriereText("Name: " + Name);
            Formatting.ZentriereText("Stadt: " + Stadt);
            Formatting.ZentriereText("Alter: " + ((Alter == 0) ? "" : Alter.ToString()));
            Formatting.ZentriereText("____________________________");
            Console.WriteLine();
        }

        public string SteckbriefInhalt => "Name: " + Name + Environment.NewLine + "Alter: " + ((Alter == 0) ? "" : Alter.ToString()) + Environment.NewLine + "Stadt: " + Stadt;
    }
}
