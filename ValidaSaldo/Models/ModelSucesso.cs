using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidaSaldo.Models
{
    public class ModelSucesso
    {
        [JsonProperty]
        public string Rotas { get; set; }
        [JsonProperty]
        public string Indice { get; set; }
        [JsonProperty]
        public string Rota { get; set; }
        [JsonProperty]
        public string Entrada { get; set; }
        [JsonProperty]
        public object Saida { get; set; }
    }
}
