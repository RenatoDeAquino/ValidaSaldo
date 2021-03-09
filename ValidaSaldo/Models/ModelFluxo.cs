using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidaSaldo.Models
{
    public class ModelFluxo
    {
        [JsonProperty]
        public object Sucesso { get; set; }
        [JsonProperty]
        public object Erro { get; set; }
    }
}
