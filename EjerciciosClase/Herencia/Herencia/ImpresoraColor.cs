using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class ImpresoraColor : Impresora
    {
        public ImpresoraColor():base()
        {
            cyan = new Cartucho(50,"cyan");
            magenta = new Cartucho(50,"magenta");
            amarillo = new Cartucho(50,"amarillo");

          
        }
                
        private Cartucho cyan;

        public Cartucho Cyan
        {
            get { return cyan; }
       
        }

        private Cartucho magenta;

        public Cartucho Magenta
        {
            get { return magenta; }
     
        }
        private Cartucho amarillo;

        public Cartucho Amarillo
        {
            get { return amarillo; }
   
        }

        public override string Imprimir(string texto)
        {
            string resultado = "Color y" + base.Imprimir(texto);
            cyan.Descontar( texto.Length +1 );
            magenta.Descontar(texto.Length + 2);
            amarillo.Descontar(texto.Length + 3);
            return resultado;
        }


    }
}