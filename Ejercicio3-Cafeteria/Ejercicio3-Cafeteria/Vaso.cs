using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Cafeteria
{
    public class Vaso
    {
		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private string capacidad;

		public string Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		//Constructor que le da el estado inicial
		public Vaso(string ptipo, string pcapacidad)
		{
			this.tipo = ptipo;
			this.capacidad = pcapacidad;
		}
	}
}
