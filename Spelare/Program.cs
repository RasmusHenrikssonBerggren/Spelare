using System;

public class Spelare /*Klassen "Spelare" är public och tillgänlig för andra klasser*/
{
    private string position; /*private gör att det enbart tillhör klassen "Spelare"*/
    private int antalmål;
    private int ålder;

    public string V { get; } 

    public Spelare(string position, int ålder, int antalmål) /*Klassen spelare innehåller position, ålder och antal mål*/
    {
        this.position = position;
    }

    public Spelare(string v) /*Alla "string v" har Visual Studio rekommenderat och genererat*/
    {
        V = v;
    }

    public string getPosition() /*Hämtar och retunererar "position"*/
    {
        return position;
    }

    public int getAntalmål() /*Hämtar och retunererar "antal mål"*/
    {
        return antalmål;
        
    }

    public int getÅlder() /*Hämtar och retunererar "ålder"*/
    {
        return ålder;
    }

}

public class Fotbollslag : Spelare /*Klassen "Fotbollslag" är arv till klassen "Spelare"*/
{
    private int antalTitlar;

    public Fotbollslag(string v) : base(v) /*Kunstruktor Visual Studio löste (läs rad 68)*/ 
    {
    }

    public Fotbollslag(string position, int antalmål, int ålder, int antalTitlar)
        : base(position, antalmål, ålder) /*Basklassen är "Spelare", och det är klassen "Spelare" som ska ha hand om "position", "antal mål" och "ålder"*/
    {
        this.antalTitlar = antalTitlar; 
    }

    public int getAntaltitlar() /*Hämtar och retunererar "antal titlar"*/
    {
        return antalTitlar;
    }

    class Program
    {

        static void Main() /*Genomför koden och gör så att den kan "run"*/
        {
            Spelare minSpelare = new Spelare("Cole Palmer"); /*Ny version av "Spelare" skapas*/
            Console.WriteLine("Antal mål: 2"  + minSpelare.getAntalmål()); /*Information om spelaren skrivs ut i form av "antal mål", "ålder" och "position"*/
            Console.WriteLine("Ålder: 2" + minSpelare.getÅlder());
            Console.WriteLine("Position: Mittfältare " + minSpelare.getPosition()); 
            Fotbollslag braFotbollslag = new Fotbollslag("Chelsea"); /*Fel uppstod här, så Visual Studio genererade konstruktor för "Fotbollslag" vid rad 44-46*/
            Console.WriteLine("Antal titlar: 36"); /*Information om fotbollslaget skrivs ut i form av "antal titlar"*/
        }

     
    }


}

