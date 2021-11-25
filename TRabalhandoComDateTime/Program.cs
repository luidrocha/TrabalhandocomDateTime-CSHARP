using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TRabalhandoComDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2019, 10, 22);
            DateTime d3 = new DateTime(2019, 10, 22, 17, 45, 3);
            DateTime d4 = new DateTime(2019, 10, 22, 17, 45, 3, 500);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow; // Pega o horario de greenwitch

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine("----------------------------");

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine("----------------------------");

            Console.WriteLine("Conversões ");
            Console.WriteLine("----------------------------");


            DateTime dt1 = DateTime.Parse("2021-10-22");
            DateTime dt2 = DateTime.Parse("2021-10-22 17:54:55");
            DateTime dt3 = DateTime.Parse("22/10/2021 17:54:55");

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Personalizando DAta :");

            Console.WriteLine("----------------------------");

            DateTime dt4 = DateTime.ParseExact("2021-10-22", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dt5 = DateTime.ParseExact("22/10/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dt4);
            Console.WriteLine(dt5);
        }
    }
}
