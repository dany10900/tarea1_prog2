using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Classes
{
    public abstract class Empleado : MiembroDeLaComunidad
    {
        private int salario;
        private DateTime fechaIngreso;
        private Boolean vacaciones;
        public Empleado(string n1, string n2, string a1, string a2,
                        DateTime fNacimiento, int salario, DateTime fechaIngreso)
            : base(n1, n2, a1, a2, fNacimiento)
        {
            this.salario = salario;
            this.fechaIngreso = fechaIngreso;
            vacaciones = false;
        }
        //propiedad de salario
        public int Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value > 0)
                {
                    this.salario = value;
                }
            }
        }
        //solo lectura
        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }
        }
        //solo lectura 
        public Boolean Vacaciones
        {
            get
            {
                return vacaciones;
            }
            set
            {
                if(value.GetType() == typeof(Boolean))
                {
                    this.vacaciones = value;        
                }
            }
        }
    }
}
