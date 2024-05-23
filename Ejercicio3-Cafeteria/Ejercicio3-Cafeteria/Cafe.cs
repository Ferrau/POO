using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Cafeteria
{
    public class Cafe
    {
		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private double precioPorLitro;

		public double PrecioPorLitro
        {
			get { return precioPorLitro; }
			set { precioPorLitro = value; }
		}

		//Constructor que le da el estado inicial.
		public Cafe(string ptipo, double pprecioPorLitro)
		{
			this.tipo = ptipo;
			this.precioPorLitro= pprecioPorLitro;
		}

		//public int Servirse(Vaso vaso)
		//{
			//Vaso vaso = vaso.Tipo
			//return;
		//}


	}
}
