using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Mano_de_cartas_de_truco a = new Mano_de_cartas_de_truco();

            Console.WriteLine("Queres repartir tu mano? Y / N");

            if (a.repartirmano(Console.ReadLine()) == true)
            {
                a.setnumerodecarta();
                a.setpalodecarta();
                Console.WriteLine(a.getcarta());
                Console.ReadLine();

                a.tengoenvido();
                Console.WriteLine("Queres cantar envido? Y / N");
                Console.WriteLine(a.cantarenvido(Console.ReadLine()));
                Console.ReadLine();

                a.tengotruco();
                Console.WriteLine("Queres cantar truco? Y / N");
                Console.WriteLine(a.cantartruco(Console.ReadLine()));
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("Sin cartas no podes jugar");
                Console.ReadLine();
            }





        }
    }
}
