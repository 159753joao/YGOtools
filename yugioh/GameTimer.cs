using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yugioh
{
    public partial class GameTimer : Form
    {
        private System.Windows.Forms.Timer timer; // Usando o Timer correto
        private TimeSpan timeLeft;

        public GameTimer()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Cria uma nova instância do Timer
            timer = new System.Windows.Forms.Timer(); // Usando o Timer correto
            timer.Interval = 1000; // 1 segundo
            timer.Tick += new EventHandler(Timer_Tick);

            // Define o tempo inicial
            timeLeft = TimeSpan.FromMinutes(50);
            UpdateTimeDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualiza o tempo restante
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimeDisplay();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Tempo esgotado!");
            }
        }

        private void UpdateTimeDisplay()
        {
            // Atualiza o rótulo com o tempo restante
            label1.Text = timeLeft.ToString(@"mm\:ss");
        }

        private void Iniciar_Timer(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Pausar_Timer(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Rein_Timer(object sender, EventArgs e)
        {
            timer.Stop();
            timeLeft = TimeSpan.FromMinutes(50);
            UpdateTimeDisplay();
        }
    }
}
