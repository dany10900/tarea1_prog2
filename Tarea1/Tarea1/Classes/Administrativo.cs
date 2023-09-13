using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Classes
{
    public class Administrativo : Empleado
    {
        private string cargo;
        public Administrativo(string n1, string n2, string a1, string a2,
                        DateTime fNacimiento, int salario, DateTime fechaIngreso, string cargo)
            : base(n1, n2, a1, a2, fNacimiento, salario, fNacimiento)
        {
            this.cargo = cargo;
        }

        public string Cargo
        {
            get
            {
                return cargo;
            }
        }
    }
}
