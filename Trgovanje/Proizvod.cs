using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovanje
{
    public class Proizvod
    {
        public string  Naziv { get; set; }
        public int Cijena { get; set; }
        public int Masa { get; set; }

        public void Print() {

            Console.WriteLine(Naziv);
            Console.WriteLine(Cijena);
            Console.WriteLine(Masa);

        }

    }
}
