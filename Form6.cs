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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Hide();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            var nome = comboBox1.Text;
            Console.WriteLine(nome);

            comboBox2.Items.Add(nome);

            var countNomes = comboBox2.Items.Count;

            var ultimoNome = comboBox2.Items[countNomes - 1].ToString();
            MessageBox.Show("Treino iniciado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //IA
            int count = 0;
            if (countNomes >= 20)
            {
                if (ultimoNome == nome)
                {
                    for (int i = 1; i <= 20; i++)
                    {
                        var nomes = comboBox2.Items[countNomes - i].ToString();
                        Console.WriteLine(nome);
                        Console.WriteLine(nomes);
                        if (nome == nomes)
                        {
                            count += 1;
                        }
                    }
                }
            }
            Console.WriteLine(count);
            if (count >= 20)
            {
                MessageBox.Show("Você realizou esse treino 20 vezes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Hide();
            Inicio.Show();
        }
    }
}
