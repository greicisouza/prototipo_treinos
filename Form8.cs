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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();            
            MessageBox.Show("Treino2 foi cadastrado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Hide();
            Inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 CadastroTreino = new Form4();
            Hide();
            CadastroTreino.Show();
        }
    }
}
