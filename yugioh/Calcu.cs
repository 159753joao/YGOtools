using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace yugioh
{
    public partial class Calcu : Form
    {
        // Variáveis para armazenar os valores
        private int LP = 8000;
        private int LPp2 = 8000;
        private int somaN = 0;
        private int somaNp2 = 0;
        

        public Calcu()
        {
            InitializeComponent();
            UpdateSomaLabel();
            UpdateLPLabel();
            UpdateSomaLabelp2();
            UpdateLPLabelp2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adiciona 1000 à variável somaN
            somaN += 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void UpdateSomaLabel()
        {
            // Atualiza o texto da label com o valor atual de somaN
            label1.Text = somaN.ToString();
        }
        private void UpdateSomaLabelp2()
        {
            // Atualiza o texto da label com o valor atual de somaN
            label2.Text = somaNp2.ToString();
        }

        private void UpdateLPLabel()
        {
            // Atualiza o texto da label com o valor atual de LP
            Resultado.Text = LP.ToString();
        }
        private void UpdateLPLabelp2()
        {
            // Atualiza o texto da label com o valor atual de LP
            Resultado2.Text = LPp2.ToString();
        }
        private void Soma1000(object sender, EventArgs e)
        {
            // Adiciona 1000 à variável somaN
            somaN += 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Calcu_Load(object sender, EventArgs e)
        {
            // Este método pode ser usado para inicializar ou carregar dados no carregamento do formulário
            UpdateSomaLabel();
        }

        private void Soma500(object sender, EventArgs e)
        {
            // Adiciona 500 à variável somaN
            somaN += 500;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Soma100(object sender, EventArgs e)
        {
            // Adiciona 100 à variável somaN
            somaN += 100;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Soma50(object sender, EventArgs e)
        {
            // Adiciona 50 à variável somaN
            somaN += 50;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

     

        private void ResultSoma(object sender, EventArgs e)
        {
            // Adiciona o valor acumulado de somaN à variável LP
            LP += somaN;
            // Zera o valor de somaN após adicionar a LP
            somaN = 0;
            // Atualiza as labels para refletir os novos valores
            UpdateLPLabel();
            UpdateSomaLabel();
        }

        private void Sub1000(object sender, EventArgs e)
        {
            // Adiciona -1000 à variável somaN
            somaN -= 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Sub50(object sender, EventArgs e)
        {
            // Adiciona -50 à variável somaN
            somaN -= 50;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Sub500(object sender, EventArgs e)
        {
            // Adiciona -500 à variável somaN
            somaN -= 500;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Sub100(object sender, EventArgs e)
        {
            // Adiciona -100 à variável somaN
            somaN -= 100;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabel();
        }

        private void Soma1000p2(object sender, EventArgs e)
        {
            // Adiciona 1000 à variável somaNp2
            somaNp2 += 1000;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void Soma500p2(object sender, EventArgs e)
        {
            // Adiciona 500 à variável somaNp2
            somaNp2 += 500;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void Soma100p2(object sender, EventArgs e)
        {
            // Adiciona 100 à variável somaNp2
            somaNp2 += 100;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void Soma50p2(object sender, EventArgs e)
        {
            // Adiciona 50 à variável somaNp2
            somaNp2 += 50;
            // Atualiza a label com o novo valor de somaN
            UpdateSomaLabelp2();
        }

        private void ResultSoma2p(object sender, EventArgs e)
        {
            // Adiciona o valor acumulado de somaN à variável LP
            LPp2 += somaNp2;
            // Zera o valor de somaN após adicionar a LP
            somaNp2 = 0;
            // Atualiza as labels para refletir os novos valores
            UpdateLPLabelp2();
            UpdateSomaLabelp2();
        }

        private void Sub10002p(object sender, EventArgs e)
        {
            // Adiciona -1000 à variável somaNp2
            somaNp2 -= 1000;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void Sub5002p(object sender, EventArgs e)
        {
            // Adiciona -500 à variável somaNp2
            somaNp2 -= 500;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void Sub502p(object sender, EventArgs e)
        {
            // Adiciona -50 à variável somaNp2
            somaNp2 -= 50;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }

        private void Sub1002p(object sender, EventArgs e)
        {
            // Adiciona -100 à variável somaNp2
            somaNp2 -= 100;
            // Atualiza a label com o novo valor de somaNp2
            UpdateSomaLabelp2();
        }
    }
}
