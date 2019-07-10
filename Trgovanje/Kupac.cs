using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovanje
{
    public class Kupac1
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public  int Godine  { get; set; }

        public void Print() {
            Console.WriteLine(Ime);
            Console.WriteLine(Prezime);
            Console.WriteLine(Godine);

        }
    }
}
