using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidaSaldo.Models
{
    public class ModelSaldos
    {
        [JsonProperty]
        public string Agencia { get; set; }
        [JsonProperty]
        public string Posto { get; set; }
        [JsonProperty]
        public string DescricaoAgencia { get; set; }
        [JsonProperty]
        public string ContaCorrente { get; set; }
        [JsonProperty]
        public string TipoConta { get; set; }
        [JsonProperty]
        public string CPF { get; set; }
        [JsonProperty]
        public string Nome { get; set; }
        [JsonProperty]
        public string Limite { get; set; }
        [JsonProperty]
        public string LimiteUtilizado { get; set; }
        [JsonProperty]
        public string LimiteBloqueado { get; set; }
        [JsonProperty]
        public string BloqueioComprasCPMF { get; set; }
        [JsonProperty]
        public string LimiteDisponivel { get; set; }
        [JsonProperty]
        public string SaldoContaCorrente { get; set; }
        [JsonProperty]
        public string ContaInvestimento { get; set; }
        [JsonProperty]
        public string ParcelaVencida { get; set; }
        [JsonProperty]
        public string ProvisaoTarifa { get; set; }
        [JsonProperty]
        public string BloqueioParcelaAtraso { get; set; }
        [JsonProperty]
        public string BloqueioParcelaEmprestimoDesenv { get; set; }
        [JsonProperty]
        public string SaldoDisponivel { get; set; }
        [JsonProperty]
        public string ProvisaoCPMF { get; set; }
        [JsonProperty]
        public string SaldoSaque { get; set; }
        [JsonProperty]
        public string Bloqueado24H { get; set; }
        [JsonProperty]
        public string BloqueadoAcima24H { get; set; }
        [JsonProperty]
        public string BloqueioJudicial { get; set; }
        [JsonProperty]
        public string SaldoTotal { get; set; }
    }
}
