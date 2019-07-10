using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetvrtiDan
{
   public class Vozilo
    {

        //access modifieri za clanove klase:
        //private 
        //public
        //protected-varijabla je vidljiva svakoj klasi koja nasljedi tu klasu
        //internal-samo unutar tog projekta
        //protected internal

            //access modifieri za klase:public,internal

        private int Brzina; //field --->dostupan bilo gdje unutar klase(private-za klasu)

        public void Ispis() { 

            Brzina = 10;
            Console.WriteLine(Brzina);
        }
    }
}
