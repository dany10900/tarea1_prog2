using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Interfaces;

namespace Tarea1.Classes
{
    public class Estudiante : MiembroDeLaComunidad, IMatricula
    {
        private string matricula;
        private string[] materiasCursando;
        public Estudiante(string n1, string n2, string a1, string a2,
            DateTime fNacimiento, string[] materiasCursando, string matricula) 
            :base(n1, n2, a1, a2, fNacimiento)
        {
            this.materiasCursando = materiasCursando;
            this.matricula = matricula;
        }

        public string Matricula => this.matricula;

        string IMatricula.matricula => this.matricula;
        public string  this[int i]
        {
            get { return materiasCursando[i]; }
            set { materiasCursando[i] = value; }
        }
    }
}
