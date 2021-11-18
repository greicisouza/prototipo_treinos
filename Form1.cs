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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Cadastrar = new Form2();
            Hide();
            Cadastrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Hide();
            Inicio.Show();
        }
    }
}
