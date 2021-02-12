using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class RegistroF : Form
    {
        public RegistroF()
        {
            InitializeComponent();
        }

        private void RegistroF_Load(object sender, EventArgs e)
        {

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        public bool Comprobar()
        {
            bool aux = false;
            if(textBox1.Text!="" && textBox2.Text!="" && textBox4.Text!="")
            {
                if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    if(comboBox1.SelectedIndex>=0 && comboBox2.SelectedIndex >= 0)
                    {
                        aux = true;
                    }
                }
            }
            return aux;
        }
        public string Distribuidor()
        {
            string nomDistribuidor = "";
            if (radioButton1.Checked)
                nomDistribuidor = radioButton1.Text;
            if (radioButton2.Checked)
                nomDistribuidor = radioButton2.Text;
            if (radioButton3.Checked)
                nomDistribuidor = radioButton3.Text;
            return nomDistribuidor;
        }

        private void buttonRege_Click(object sender, EventArgs e)
        {
            try
            {
                if (Comprobar() == true)
                {
                    MessageBox.Show("Medicamento Registrado");
                }
                else
                {
                    MessageBox.Show("Ingrese toda la informacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
