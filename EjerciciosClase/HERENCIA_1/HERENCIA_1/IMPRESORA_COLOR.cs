using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA_1
{
   public class IMPRESORA_COLOR : IMPRESORA
    {

        private CARTUCHO cyan;

        public CARTUCHO Cyan
        {
            get { return cyan; }
            set { cyan = value; }
        }

        private CARTUCHO mg;

        public CARTUCHO MG
        {
            get { return mg; }
            set { mg = value; }
        }

        private CARTUCHO am;

        public CARTUCHO Amarillo
        {
            get { return am; }
            set { am = value; }
        }

        public override string Imprimir()
        {
            string resultado;
            if (this.Validar())
            {
                cyan.Nivel--;
                mg.Nivel -= 2;
                am.Nivel -= 3;
                resultado = base.Imprimir() + " y COLOR";
            }
            else
            {
                resultado = "No hay tinta";
            }
            return resultado;
        }

        protected override bool Validar()
        {
            return base.Validar() && cyan.Nivel > 0 && am.Nivel > 0 && mg.Nivel >0;
        }

    }
}
