using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_API
{
    public class DAO
    {
        private string _connectionString;

        public DAO(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public object ProcuraMoedaID(string cod)
        {
            SqlConnection sqlConn = new SqlConnection(_connectionString);
            sqlConn.Open();

            string select = $"SELECT Cod_moeda FROM tbMoeda WHERE Cod_moeda_API = '{cod}'";

            SqlCommand cmdSelect = new SqlCommand(select, sqlConn);
            SqlDataReader seleRd = cmdSelect.ExecuteReader();
            seleRd.Read();
            var cod_moeda = seleRd[0];

            seleRd.Close();

            return cod_moeda;
        }

        public void Registra(Obj obj, object cod_moeda)
        {
            SqlConnection sqlConn = new SqlConnection(_connectionString);
            sqlConn.Open();

            string sqlCommand = $"INSERT INTO tbMoedaCotacao (Cod_moeda, Data_cotacao, Valor_cotacao)" +
                $" VALUES ({cod_moeda}, '{obj.Cotacao.create_date}', {obj.Cotacao.ask});";

            SqlCommand cmdIn = new SqlCommand(sqlCommand, sqlConn);
            cmdIn.ExecuteReader();

            Console.WriteLine($"O valor da cotação de {obj.Cotacao.name} foi atualizada!");

            sqlConn.Close();
        }
    }
}
