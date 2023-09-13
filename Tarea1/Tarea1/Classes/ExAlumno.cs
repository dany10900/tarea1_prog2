using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Interfaces;

namespace Tarea1.Classes
{
    public class ExAlumno: MiembroDeLaComunidad, IMatricula
    {
        private DateTime fechaSalida;
        private string matricula;
        public ExAlumno(string n1, string n2, string a1, string a2,
            DateTime fNacimiento, string matricula, DateTime fechaSalida)
            : base(n1, n2, a1, a2, fNacimiento)
        {
            this.matricula = matricula;
            this.fechaSalida = fechaSalida;
        }
        public string Matricula => this.matricula;

        public DateTime FechaSalida
        {
            get { return this.fechaSalida; }
        }
        string IMatricula.matricula => this.matricula;
    }
}
