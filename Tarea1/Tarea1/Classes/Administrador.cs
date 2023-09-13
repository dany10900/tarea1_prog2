using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Classes
{
    public class Administrador:Docente
    {
        
        public Administrador(string n1, string n2, string a1, string a2,
                        DateTime fNacimiento, int salario, DateTime fechaIngreso, string[] materiasImpartiendo)
            :base(n1,n2,a1,a2,fNacimiento,salario,fechaIngreso,materiasImpartiendo) { }
        public void ReducirSalarioEmpleado(Empleado emp,double salario) 
        {
            if ((emp.Salario - salario) > 0)
            {
                emp.Salario = emp.Salario - salario;
            }
        }
        public void AumentarSalario(Empleado emp,double salario)
        {
            emp.Salario = emp.Salario + salario;
        }
    }
}
