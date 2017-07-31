using System;
using System.Runtime.Serialization;

namespace NJ.WCF.Host.Entidades
{
    [DataContract]
    public class Pessoa
    {
        [DataMember]
        public Guid Id{ get; set; }
        [DataMember]
        public String Nome { get; set; }
        [DataMember]
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
            Id = Guid.NewGuid();
        }
    }
}