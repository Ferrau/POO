using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Impresora
    {
        public Impresora()
        {

            cartucho = new Cartucho(50, "Negro");
        }

        protected Cartucho cartucho;

        public Cartucho Negro
        {
            get { return cartucho; }
            
        }

        public virtual string Imprimir(string texto)
        {
            cartucho.Descontar(texto.Length);
            return "Negro: " + texto;
        }
    }
}