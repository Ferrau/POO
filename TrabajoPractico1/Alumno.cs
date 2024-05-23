using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    public class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso;
        private readonly int edad;
        private Boolean activo;
        private int cant_materia_aprobadas;

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        //Metodos de acceso
        public DateTime Fecha_nacimiento
        {
            //Solo escritura
            set { fecha_nacimiento = value; }
        }
        public DateTime Fecha_ingreso
        {
            //Solo escritura
            set { fecha_ingreso = value;}
        }
        public int Edad
        {
            //Solo lectura
            get { return edad; }
        }

        public Boolean Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public int Cant_materia_aprobadas
        {
            //Solo escritura
            set { cant_materia_aprobadas = value; }
        }

        //Constructor sin parametros
        public Alumno()
        {

        }

        //Constructor con todos los parametros
        public Alumno(int legajo, string nombre, string apellido, DateTime fecha_nacimiento, DateTime fecha_ingreso, Boolean activo, int cant_materia_aprobadas)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_nacimiento = fecha_nacimiento;
            Fecha_ingreso = fecha_ingreso;
            Activo = activo;
            Cant_materia_aprobadas = cant_materia_aprobadas;
        }

        public int Antiguedad(Boolean a, Boolean m, Boolean d)
        {
            DateTime fechaActual = DateTime.Now;

            int anio = fechaActual.Year - fecha_ingreso.Year;
            int mes = fechaActual.Month - fecha_ingreso.Month;
            int dia = fechaActual.Day - fecha_ingreso.Day;

            if (a)
            {

                if(mes < 0  || (mes == 0 && dia < 0))
                {
                    anio--;
                    mes += 12;
                }
                return anio;

            }
            else if (m){
                //Ejemplo: 1 * 12 + 3 = 15 meses
                return anio * 12 + mes;

            }
            else
            {
                return dia;

            }
        }

        public int MateriasNoAprobadas(int cant_materia_aprobadas)
        {
            //Carrera tiene 36 materias totales
            int materiasNoAprobadas = 0;
            return materiasNoAprobadas = 36 - cant_materia_aprobadas;
        }

        public int EdadIngreso(int edad)
        {
            int anio = fecha_ingreso.Year - fecha_nacimiento.Year;
            int mes = fecha_ingreso.Month - fecha_nacimiento.Month;
            int dia = fecha_ingreso.Day - fecha_nacimiento.Day;

            //EJEMPLO:
            //fecha_ingreso = 20/03/2024
            //fecha_nacimiento = 26/03/2002
            //edad ingreso = 21
            //anio: 2024 - 2002 = 22
            //mes: 03 - 03 = 0
            //dia: 20 - 26 = -6
        }
    }
}
