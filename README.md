# Konstruktor
Erklärung wie ein Konstruktor Funktioniert. :)

Main.cs
````c#
namespace Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geräuche 1 Parameter
            //Jahr 2 Parameter
            //wenn der KOnstruktor geschrieben wird steht da auch immer was dieser braucht.
            Tier Katze = new Tier("Wauuu", 2020);
            Console.WriteLine(Katze.Geräuch);

            //Tier = Klassenname
            //Katze = Variablen name
            //new Tier ruft den KOnstruktor der Klasse Tier auf.
            Tier Hund = new Tier("Wauuu", 20);
            Console.WriteLine(Hund.Alter);
        }
    }
}

````
Tier.cs
````c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    //zugriffsmodifikator
    //public, internal, private, protectet
    //public Tier() { }       // Jeder darf ein Auto erzeugen
    //internal Tier() { }     // Nur innerhalb desselben Projekts darf man ein Auto erzeugen
    //private Tier() { }      // Nur die Klasse selbst darf ein Auto erzeugen (z.B. für Singleton-Muster)
    public class Tier
    {
        public string Geräuch;
        public int Alter;

        // Konstruktor
        // kleingeschriebene wörter = Parameter der an den KOnstruktor übergibt.
        // Großgeschrieben = Property der Klasse
        internal Tier (string geräuch, int alter)
        {
            //Werte werden so gesehen von rechts nach Links Gelesen.
            //geräuch gibt sein wert an Geräuch weiter.
            Geräuch = geräuch;
            Alter = alter;
        }
    }
}
````