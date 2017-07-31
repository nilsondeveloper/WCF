using NJ.WCF.ConsoleApp.ServiceReferencePessoaApp;

namespace NJ.WCF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client
            var pessoaAppClient = new PessoaAppClient();
            var pessoas = pessoaAppClient.ListarPessoas();
            pessoaAppClient.Close();
            
        }
    }
}
