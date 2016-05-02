using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ServidorRMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servidor iniciado");
            TcpChannel tcpChannel = new TcpChannel(5000);
            ChannelServices.RegisterChannel(tcpChannel,false);


            

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CalculoFGTS),
            "FGTS", WellKnownObjectMode.SingleCall);

            Console.ReadKey();

        }
    }
}
