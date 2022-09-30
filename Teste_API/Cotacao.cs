using System;

namespace teste_API
{
    public class Cotacao
    {
        public string code { get; set; }
        public string codein { get; set; }
        public string name { get; set; }
        public string high { get; set; } // Máximo
        public string low { get; set; } // Mínimo
        public string varBid { get; set; } // Variação
        public string pctChange { get; set; } // Porcentagem de Variação
        public string bid { get; set; } // Compra
        public string ask { get; set; } // Venda
        public string timestamp { get; set; }
        public string create_date { get; set; }
    }
}
