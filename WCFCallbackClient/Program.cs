using System;
using System.ServiceModel;
using System.Threading;
using WCFCallbackClient.WCFCallback;

namespace WCFCallbackClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RetornoServico callback = new RetornoServico();
            InstanceContext context = new InstanceContext(callback);
            var client = new ServicoClient(context);

            while (!Console.KeyAvailable)
            {
                try
                {
                    client.IniciaServico();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error at service {0}", client.Endpoint.Address);
                    Console.ResetColor();
                    client.Abort();
                    client = new ServicoClient(context);
                }
            }

            Console.ReadKey();
        }
    }
}
