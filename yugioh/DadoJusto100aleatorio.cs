using System;
using System.Windows.Forms;

namespace yugioh
{
    public partial class DadoJusto100_aleatorio : Form
    {
        private Random random;
        private int resultadoDado; // Variável para armazenar o resultado do dado
        private int resultadoDadoj1 ;

        public DadoJusto100_aleatorio()
        {
            InitializeComponent();
            random = new Random();
            resultadoDado = 0; // Inicializa a variável
            resultadoDadoj1 = 0; // Inicializa a variável
        }

        private void AtivarDado(object sender, EventArgs e)
        {
            // Gera um valor aleatório entre 1 e 6
            resultadoDado = random.Next(1, 7);

            // Mostra o valor em uma MessageBox
            MessageBox.Show($"O dado caiu em: {resultadoDado}", "Resultado do Dado");
            label8.Text = $" {resultadoDado}";

        }

        private void Nomej2(object sender, EventArgs e)
        {
            // Verifica se o texto em textBox2 não está vazio
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                // Obtém o texto da textBox2
                string nomeUsuario = textBox2.Text;

                label4.Text = $" {nomeUsuario}";
                label7.Text = $" {nomeUsuario}";

                // Exibe uma MessageBox com o nome do usuário
                MessageBox.Show($"Seu nome é {nomeUsuario}", "Nome Salvo");
            }
            else
            {
                // Se textBox2 estiver vazio, mostra uma mensagem de erro
                MessageBox.Show("Por favor, insira um nome antes de salvar.", "Nome Não Inserido");
            }
        }

        private void NomeJ1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
               
                string nomeUsuario1 = textBox1.Text;

                label3.Text = $" {nomeUsuario1}";
                label6.Text = $" {nomeUsuario1}";

                MessageBox.Show($"Seu nome é {nomeUsuario1}", "Nome Salvo");
            }
            else
            {
                
                MessageBox.Show("Por favor, insira um nome antes de salvar.", "Nome Não Inserido");
            }
        }

        private void AtivarDadoj1(object sender, EventArgs e)
        {
            // Gera um valor aleatório entre 1 e 6
            resultadoDadoj1 = random.Next(1, 7);

            // Mostra o valor em uma MessageBox
            MessageBox.Show($"O dado caiu em: {resultadoDadoj1}", "Resultado do Dado");
            label5.Text = $" {resultadoDadoj1}";
        }
    }
}
