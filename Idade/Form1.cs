using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                MessageBox.Show("Nome não informado");
                return;
            }


            DateTime dataNascimento = dtpNascimento.Value;
            DateTime DataAtual = DateTime.Now;






            int Anos = new DateTime(DataAtual.Subtract(dataNascimento).Ticks).Year;

            if (dataNascimento.Month >= DataAtual.Month && dataNascimento.Day >= dataNascimento.Day)
                Anos--;
                String nomeTexto = textNome.Text;


            DateTime AnosTranscorridos = dataNascimento.AddYears(Anos);
            if (Anos < 18)
            {
                MessageBox.Show("Idade não permitida!");
            }
            else if (dtpNascimento.Value < DateTime.Now)
            {
                int resultado = CalculaIdade(dtpNascimento.Value);
                lblIdade.Text = $"{nomeTexto},{resultado} anos";
            }
            else
            {
                MessageBox.Show("Data inválida ou idade não autorizada");
            }


        }
        private static int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
        DateTime dataNascimento;


        private void btnCalculaIdadeMaisPrecisa_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                MessageBox.Show("Nome não informado");
                return;
            }

            dataNascimento = dtpNascimento.Value;
            DateTime DataAtual = DateTime.Now;
            int Anos = new DateTime(DateTime.Now.Subtract(dataNascimento).Ticks).Year - 1;


            DateTime AnosTranscorridos = dataNascimento.AddYears(Anos);
            int Meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (AnosTranscorridos.AddMonths(i) == DataAtual)
                {
                    Meses = i;
                    continue;
                }
                else if (AnosTranscorridos.AddMonths(i) >= DataAtual)
                {
                    Meses = i - 1;
                    continue;
                }
                else if (Anos < 18)
                {
                    MessageBox.Show("Idade não permitida!");
                }
                  
            }
            int Dias = DataAtual.Subtract(AnosTranscorridos.AddMonths(Meses)).Days;
            int Horas = DataAtual.Subtract(AnosTranscorridos).Hours;
            int Minutos = DataAtual.Subtract(AnosTranscorridos).Minutes;
            int Segundos = DataAtual.Subtract(AnosTranscorridos).Seconds;
            String nomeTexto = textNome.Text;


            lblIdade.Text = $"{nomeTexto}, {Anos} anos {Meses} Meses {Dias} dias {Horas} horas" +
                $"{Minutos} minutos {Segundos} segundos";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
