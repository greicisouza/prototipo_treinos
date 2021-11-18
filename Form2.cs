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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Hide();
            MessageBox.Show("Cadastro realizado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Inicio.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Hide();
            Login.Show();
        }
    }
}
