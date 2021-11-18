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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            MessageBox.Show("Dados físicos atualizados com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            Inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Hide();
            Inicio.Show();
        }
    }
}
