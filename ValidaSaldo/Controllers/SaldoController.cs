using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ValidaSaldo.Models;

namespace ValidaSaldo.Controllers
{
    [ApiController]
    public class SaldoController : ControllerBase
    {
        [HttpPost("/")]
        public async Task<IActionResult> SomeActionAsync()
        {
            using (var reader = new StreamReader(Request.Body))
            {
                var body = reader.ReadToEnd();
                
                //criar chamamento para metodo externo e passar somente o conteudo que no caso vai ser o json body
                //o metodo externo irá verificar as condições e retornar true or false
                //false == notfound
                //true == ok
                //usar fluent validation

                //verificar o tamanho que foi inserido tanto da agencia quanto da ccor

                //verificar tipo de input
                //verificar o numero que foi colocado


                JObject json = JObject.Parse(body);

                string agencia = (string)json["agencia"];
                string ccor = (string)json["ccor"];

                if (agencia == null || agencia == "")
                {
                    return NotFound("numero da agencia não foi inserido");
                } else if (ccor == null || ccor == "")
                {
                    return NotFound("numero da conta corrente não foi inserido");
                } else if (agencia.Length != 4)
                {
                    return NotFound("Numero dos digitos da agencia invalidos deve conter 4 digitos");
                }

                else if (ccor.Length != 12)
                {
                    return NotFound("Numero dos digitos da conta corrente invalidos deve conter 12 digitos");
                }

                else if (agencia == "0015" && ccor == "000002105349")
                {
                    var fluxo = new ModelFluxo
                    {
                        Sucesso = new ModelSucesso
                        {
                            Rotas = "Oi",
                            Indice = "Eu",
                            Rota = "Sou",
                            Entrada = "O",
                            Saida = new ModelSaida
                            {
                                Saldos = new ModelSaldos
                                {
                                    Agencia = "0015",
                                    Posto = "01",
                                    DescricaoAgencia = "AG. SENADOR LEMOS",
                                    ContaCorrente = "00000210534/9",
                                    TipoConta = "MULTICRED - CLIENTE",
                                    CPF = "000.532.602-87",
                                    Nome = "TEREZA CRUZ CHAGAS",
                                    Limite = "0.00",
                                    LimiteUtilizado = "0.00",
                                    LimiteBloqueado = "0.00",
                                    BloqueioComprasCPMF = "0.00",
                                    LimiteDisponivel = "0.00",
                                    SaldoContaCorrente = "828.697,42",
                                    ContaInvestimento = "0.00",
                                    ParcelaVencida = "0.00",
                                    ProvisaoTarifa = "0.00",
                                    BloqueioParcelaAtraso = "0.00",
                                    BloqueioParcelaEmprestimoDesenv = "0.00",
                                    SaldoDisponivel = "828.697,42",
                                    ProvisaoCPMF = "0.00",
                                    SaldoSaque = "828.697,42",
                                    Bloqueado24H = "10,00",
                                    BloqueadoAcima24H = "6,00",
                                    BloqueioJudicial = "0,00",
                                    SaldoTotal = "828.713,42"
                                }
                            }
                            
                        },
                        Erro = new ModelErro
                        {
                            Rotas = "Oi",
                            Indice = "Eu",
                            Rota = "Sou",
                            Entrada = "O",
                            Saida = "Goku"
                        }
                    };

                    var stringPayload = await Task.Run(() => JsonConvert.SerializeObject(fluxo));

                    return Ok(stringPayload);

                } else
                {
                    return Ok("Conta ou Agencia não estão presentes no banco de dados");
                }

            }
   
        }
    }
}
