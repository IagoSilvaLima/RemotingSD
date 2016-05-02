using ServidorRMI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número do meses");
            int meses = Convert.ToInt16(Console.ReadLine());

            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);

            Type requiredType = typeof(ICalculoFGTS);

            ICalculoFGTS remoteObject = (ICalculoFGTS)Activator.GetObject(requiredType,
            "tcp://localhost:5000/FGTS");

            double fgts = remoteObject.Calcula(salario, meses);

            Console.WriteLine("Seu fgts será de {0}",fgts);

            Console.Read();
        }
    }
}
