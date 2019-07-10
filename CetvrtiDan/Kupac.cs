using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetvrtiDan
{
    class Kupac              //enum,enumeracija
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol spol { get; set; }      //1--musko,2--zensko

        public void PrikaziSpol() {
            if (spol == Spol.Muško)
            {
                Console.WriteLine("Muško");
            }
            else if (spol ==Spol.Žensko) {
                Console.WriteLine("Žensko");
            }
        }

    }
   

}
