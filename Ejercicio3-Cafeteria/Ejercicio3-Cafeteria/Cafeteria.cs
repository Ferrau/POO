using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Cafeteria
{
    public class Cafeteria
    {

        private List<Maquina> maquinas;

        public List<Maquina> Maquinas
        {
            get { return maquinas; }
            set { maquinas = value; }
        }


        private List<Cafe> cafe;

        public List<Cafe> Cafe
        {
            get { return cafe; }
            set { cafe = value; }
        }

        private List<Vaso> vaso;

        public List<Vaso> Vaso
        {
            get { return vaso; }
            set { vaso = value; }
        }

        public double RecaudacionTotal()
        {
            double total= 0;

            return total;
        }
    }
}
