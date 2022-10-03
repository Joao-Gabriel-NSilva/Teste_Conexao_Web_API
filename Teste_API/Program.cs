using Newtonsoft.Json;
using Teste_API.Model;
using Teste_API.Utils;


// Busca na API web
string json = await Buscador.GetJsonAsync("https://economia.awesomeapi.com.br/json/last/USD-BRL");
Obj obj = JsonConvert.DeserializeObject<Obj>(json);


// conecta ao banco
DAO dao = new DAO("Data Source=TREINAMENTO-02\\SQLEXPRESS;Database=" +
                "SATKTREINAMENTOFIN2022;User Id=DBATAK;Password=1;");


// Procura o código da moeda retornado pela api no banco
var cod_moeda = dao.ProcuraMoedaID(obj.Cotacao.code);


// Insere no banco de dados o valor da cotação da moeda que a api retornou
dao.Registra(obj, cod_moeda);
