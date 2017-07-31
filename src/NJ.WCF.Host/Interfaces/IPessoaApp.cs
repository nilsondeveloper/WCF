using System.Collections.Generic;
using System.ServiceModel;
using NJ.WCF.Host.Entidades;

namespace NJ.WCF.Host.Interfaces
{
    [ServiceContract]
    public interface IPessoaApp
    {
        [OperationContract]
        IList<Pessoa> ListarPessoas();
    }
}