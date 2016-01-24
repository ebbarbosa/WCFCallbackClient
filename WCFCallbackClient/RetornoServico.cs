using System;
using WCFCallbackClient.WCFCallback;

namespace WCFCallbackClient
{
    internal class RetornoServico : IServicoCallback
    {
        public void RetornouServico(Retorno retorno)
        {
            Console.WriteLine("{0} number {1}.", retorno.Nome, retorno.Numero);
        }
    }
}