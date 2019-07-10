using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetvrtiDan
{
    class Tjedan
    {
        public Dan PocetniDanUTjednu { get; set; }
        public Dan TrenutniDanUTjednu { get; set; }

        public void PrikaziTrenutniDan() {

            switch (TrenutniDanUTjednu) {

                case Dan.Ponedjeljak:
                    Console.WriteLine("Danas je ponedjeljak");
                    break;
                case Dan.Utorak:
                    Console.WriteLine("Danas je utorak");
                    break;
                case Dan.Srijeda:
                    Console.WriteLine("Danas je srijeda");   //Console.Writeline("Danas je " + TrenutniDanUTjednu);
                    break;
                case Dan.Četvrtak:
                    Console.WriteLine("Danas je četvrtak");
                    break;
                case Dan.Petak:
                    Console.WriteLine("Danas je petak");
                    break;
                case Dan.Subota:
                    Console.WriteLine("Danas je subota");
                    break;
                case Dan.Nedjelja:
                    Console.WriteLine("Danas je nedjelja");
                    break;
            }
        }

    }
}
