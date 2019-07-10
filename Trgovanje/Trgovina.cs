using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovanje
{
    public class Trgovina
    {
        public string Ime { get; set; }
        public string Lokacija { get; set; }
        public string Telefon { get; set; }
        public int BrojRadnika { get; set; }

        public void Print() {

            Console.WriteLine(Ime);
            Console.WriteLine(Lokacija);
            Console.WriteLine(Telefon);
            Console.WriteLine(BrojRadnika);

        }

    }
}
