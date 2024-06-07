using System;

namespace itforallUmsatzRechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializierung von Variable Rabatt
            int Rabatt = 0;
            //Ausgabe Text
            Console.WriteLine("Geben Sie Umsatz: ");
            //Eingabe Wert von Umsatz
            int Umsatz = Convert.ToInt32(Console.ReadLine());
            //Ausgabe Umsatz
            Console.WriteLine("Umsatz: " + Umsatz);
            //wenn Umsatz mehr oder gleich 500
            if(Umsatz >= 500)
            {
                //dann Rabatt ist gleich 10
                Rabatt = 10;
            } 
            //sonst wenn Umsatz mehr oder gleich 100
            else if(Umsatz >= 100)
            {
                //dann Rabatt ist gleich 5
                Rabatt = 5;
            }
                //initializierung und zuweisung von Rechnungsbeitrag 
                int Rechnungsbeitrag = Umsatz - Rabatt;
            //Ausgabe von Rechnungsbeitrag
            Console.WriteLine("Rechnungsbeitrag: " + Rechnungsbeitrag);
        }
    }
}
