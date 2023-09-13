using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Classes
{
    public class Maestro:Docente
    {
        public Maestro(string n1, string n2, string a1, string a2,
                        DateTime fNacimiento, int salario, DateTime fechaIngreso, string[] materiasImpartiendo)
            : base(n1, n2, a1, a2, fNacimiento, salario, fechaIngreso, materiasImpartiendo)
        {
        }
        public string PublicarCalificaciones()
        {
           return ("Publicando...");
        }
    }
}
