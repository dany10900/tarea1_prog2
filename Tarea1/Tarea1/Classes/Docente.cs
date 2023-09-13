using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Classes
{
    abstract class Docente:Empleado
    {
        private string[] materiasImpartiendo;

        public Docente(string n1, string n2, string a1, string a2,
                        DateTime fNacimiento, int salario, DateTime fechaIngreso, string[] materiasImpartiendo)
            : base(n1, n2, a1, a2, fNacimiento, salario, fechaIngreso)
        {

        }

        public string this[int i]
        {
            get { return materiasImpartiendo[i]; }
            set { materiasImpartiendo[i] = value; }
        }
    }
}
