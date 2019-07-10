using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trgovanje;
using Vozila;
namespace CetvrtiDan
{

    enum Dan {
        Ponedjeljak,
        Utorak,
        Srijeda,
        Četvrtak,
        Petak,
        Subota,
        Nedjelja,

    }

    enum Spol {   //enum-value tip podataka

        Muško,
        Žensko
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Kupac k = new Kupac();
            //k.Ime = "Pero"; 
        
            //k.Prezime = "Perić";
            //k.spol = Spol.Muško;
            ////Console.WriteLine((int)k.spol);

            //Tjedan t = new Tjedan();
            //t.TrenutniDanUTjednu = Dan.Srijeda;
            //t.PocetniDanUTjednu = Dan.Ponedjeljak;
            //t.PrikaziTrenutniDan();

            Trgovina t = new Trgovina();
            t.BrojRadnika = 10;
            t.Ime = "Lidl";
            t.Lokacija = "Osijek";
            t.Telefon = "095121212";
            Autobus a = new Autobus();
            a.Godiste = 1999;
            Console.ReadLine();
        }
    }
}
