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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Hide();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();            
            MessageBox.Show("Treino1 foi gerado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Hide();
            Inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 CadastroTreino = new Form8();
            Hide();
            CadastroTreino.Show();
        }
    }
}
