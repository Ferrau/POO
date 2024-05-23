using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA_1
{
    public class IMPRESORA
    {
        private CARTUCHO negro;

        public CARTUCHO Negro
        {
            get { return negro; }
            set { negro = value; }
        }


        protected virtual bool Validar()
        {
            return negro.Nivel > 0;
        }

        public virtual string Imprimir()
        {
            string respuesta;
            if(Validar())
            {
                respuesta = "Imprimiendo en negro";
                negro.Nivel--;
            }
            else
            {

                respuesta = "No hay tinta negra";
            }
            return respuesta;

        }


    }
}
