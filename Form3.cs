using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Treinos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 CriarNovoTreino = new Form4();
            Hide();
            CriarNovoTreino.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 MeusTreinos = new Form5();
            Hide();
            MeusTreinos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 ComecarTreino = new Form6();
            Hide();
            ComecarTreino.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 AtualizarDados = new Form7();
            Hide();
            AtualizarDados.Show();
        }
    }
}
