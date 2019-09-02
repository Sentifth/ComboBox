using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice=cbAlimentos.SelectedIndex;
            string mensaje = "El día de hoy es " + cbAlimentos.Items[indice].ToString();
            MessageBox.Show(mensaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbAlimentos.Items.Add("Pozole");
            cbAlimentos.Items.Add("Tostadas de Pata");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cbAlimentos.Items.Add(textBox1.Text);
        }

        private void CbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbAlimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = cbAlimentos.Items[indice].ToString();
        }
    }
}
