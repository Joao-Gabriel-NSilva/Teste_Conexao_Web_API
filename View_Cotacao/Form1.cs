using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_API.Model;
using Teste_API.Utils;

namespace View_Cotacao
{
    public partial class Form1 : Form
    {
        private static Thread thread;
        private static string moedaOrigem;
        private static string moedaDestino;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            moedaOrigem = comboBoxOrigem.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            moedaDestino = comboBoxDestino.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sATKTREINAMENTOFIN2022DataSet.tbMoeda'. Você pode movê-la ou removê-la conforme necessário.
            this.tbMoedaTableAdapter.Fill(this.sATKTREINAMENTOFIN2022DataSet.tbMoeda);
            moedaOrigem = comboBoxOrigem.Text;
            moedaDestino = comboBoxDestino.Text;


        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {

            thread = new Thread(ThreadBuscador);
            thread.Start();     
        }

        private static void ThreadBuscador()
        {
            try
            {
                string json = Buscador.Busca($"https://economia.awesomeapi.com.br/json/last/" +
                                $"{moedaOrigem}-{comboBoxDestino}");
                Obj obj = JsonConvert.DeserializeObject<Obj>(json);
                textBoxResultado.Text = obj.Cotacao.ask;
            } catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            
        }
    }
}
