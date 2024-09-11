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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância de Form2
            CalcuDraw form2 = new CalcuDraw();

            // Exibe o Form2
            form2.Show();

            // Opcionalmente, você pode definir o Form2 para ser fechado
            // quando o Form1 for fechado
            form2.FormClosed += (s, args) => this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calcu form3 = new Calcu();
            
            form3.Show();
            form3.FormClosed += (s, args) => this.Show();


        }

        private void MenuDado(object sender, EventArgs e)
        {
            DadoJusto100_aleatorio form4 = new DadoJusto100_aleatorio();
            form4.Show();
            form4.FormClosed += (s, args) => this.Show();
        }

        private void Menu_Timer(object sender, EventArgs e)
        {
            GameTimer form5 = new GameTimer();
            form5.Show();
            form5.FormClosed += (s, args) => this.Show();
        }
    }
}
