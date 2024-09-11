using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yugioh
{
    public partial class CalcuDraw : Form
    {
        public CalcuDraw()
        {
            InitializeComponent();
            InitializeComponent();
            button1.Click += new EventHandler(CalculateProbability);
        }

        private void CalculateProbability(object sender, EventArgs e)
        {
            // Pegando os valores dos controles de entrada
            int deckSize = (int)numericUpDown1.Value;       // Total de cartas no baralho
            int normalS = (int)numericUpDown2.Value;        // Total de cartas específicas (monstros desejados)
            int handCard = (int)numericUpDown3.Value;       // Total de cartas puxadas
            int minBixoHand = (int)numericUpDown4.Value;    // Número mínimo de monstros desejados na mão

            // Validando os inputs
            if (deckSize <= 0 || normalS < 0 || handCard <= 0 || minBixoHand < 0 || normalS > deckSize || handCard > deckSize || minBixoHand > handCard)
            {
                MessageBox.Show("Valores inválidos. Verifique as entradas.");
                return;
            }

            double probability = CalculateProbability(deckSize, normalS, handCard, minBixoHand);
            label5.Text = $"{probability:0.00}%";
        }

        private double CalculateProbability(int deckSize, int normalS, int handCard, int minBixoHand)
        {
            // Função auxiliar para calcular combinações
            double Combinations(int n, int k)
            {
                if (k > n) return 0;
                return Factorial(n) / (Factorial(k) * Factorial(n - k));
            }

            double Factorial(int x)
            {
                double result = 1;
                for (int i = 2; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }

            // Calcula a probabilidade
            double totalCombinations = Combinations(deckSize, handCard);
            double favorableCombinations = 0;

            for (int i = minBixoHand; i <= Math.Min(normalS, handCard); i++)
            {
                favorableCombinations += Combinations(normalS, i) * Combinations(deckSize - normalS, handCard - i);
            }

            return (favorableCombinations / totalCombinations) * 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}