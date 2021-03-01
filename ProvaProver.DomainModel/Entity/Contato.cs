using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ProvaProver.DomainModel.Entity

{
    [JsonObject(IsReference = true)]
    public class Contato : EntityBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Documento { get; set; }
    }
}
