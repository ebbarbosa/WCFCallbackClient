using System;
using System.ServiceModel;
using WCFCallbackClient.WCFCallback;

namespace WCFCallbackClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aperte Enter para iniciar o servico");
            Console.ReadLine();

            IniciaServico();

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }

        private static void IniciaServico()
        {
            var callback = new RetornoServico();
            var context = new InstanceContext(callback);
            var client = new ServicoClient(context);
           
            try
            {
                client.IniciaServico();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();

                IniciaServico();
            }
        }
    }
}
