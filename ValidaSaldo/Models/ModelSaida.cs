using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidaSaldo.Models
{
    public class ModelSaida
    {
        [JsonProperty]
        public object Saldos { get; set; }
        [JsonProperty]
        public object Aplicacoes { get; set; }
        [JsonProperty]
        public object LancamentosDia { get; set; }
    }
}
