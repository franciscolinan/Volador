using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl tower = new TorreDeControl();

            Pato pato = new Pato();
            Boing747 boing747 = new Boing747();
            Superman superman = new Superman();

            tower.agregarVolador(pato);
            tower.agregarVolador(boing747);
            tower.agregarVolador(superman);

            tower.vuelenTodos();

            Console.ReadKey();
        }
    }
}
