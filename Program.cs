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
