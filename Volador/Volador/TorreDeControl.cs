using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreDeControl
    {
        List<Volador> voladores = new List<Volador>();
        public void agregarVolador(Volador unVolable)
        {
            voladores.Add(unVolable);
        }

        public void vuelenTodos()
        {
            foreach (Volador volador in voladores)
            {
                volador.Volar();
            }
        }
    }
}
