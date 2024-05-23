using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Cafeteria
{
    public class Maquina
    {
		private Cafe cafe;

		public Cafe Cafe
		{
			get { return cafe; }
			set { cafe = value; }
		}

		private double recaudacion;

		public double Recaudacion 
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}


		private double capacidad;

		public double Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		//Descontar cuando se sirva de la maquina
		public void Descontar (int cantidad)
		{
			capacidad -= cantidad;

		}

		//Recargar hasta el tope de la capacidad
		public void Recargar (int cantidad)
		{
			capacidad = cantidad;
		}


	}
}
