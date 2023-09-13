using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Classes
{
    public abstract class MiembroDeLaComunidad
    {
        private string primerNombre;
        private string segundoNombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;

        public MiembroDeLaComunidad(string n1, string n2, string a1, string a2,
                                    DateTime fNacimiento) {
            primerNombre = n1;
            segundoNombre = n2;
            apellidoPaterno = a1;
            apellidoMaterno = a2;
            fechaNacimiento = fNacimiento;
        }
        //solo lectura
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        //solo lectura 
        public string SegundoNombre
        {
            get
            {
                return segundoNombre;
            }
        }
        //solo lectura 
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
        }
        //solo lectura 
        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }
        }
    }
}
