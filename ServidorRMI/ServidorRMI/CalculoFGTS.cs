using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorRMI
{
    public class CalculoFGTS : MarshalByRefObject,ICalculoFGTS
    {
        public double Calcula(double salario, int meses)
        {
            var mensal = salario * 0.08;
            return mensal * meses;
        }
    }
}
