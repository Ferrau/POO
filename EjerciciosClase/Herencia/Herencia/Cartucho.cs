using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Cartucho
    {
        public Cartucho(int elNivel, string c)
        {
            nivel = elNivel;
            color = c;
        }

        private string color;

        public string Color
        {
            get { return color; }
        }

        private int nivel;

        public int Nivel
        {
            get { return nivel; }
        
        }

        public void Descontar(int cantidad)
        {
            nivel -= cantidad;
        }

        public void Recargar(int cantidad)
        {
            nivel = cantidad;

        }

    }
}