using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace presentacion
{
    public partial class Form1 : Form
    {
        ConSQL cn = new ConSQL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string contra="unach2020";
            string usuario="Admin";
           
            if((textBox1.Text==usuario) & (textBox2.Text==contra))
            {
                this.Hide();
                Form4 v2 = new Form4();
                v2.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto o no registrado");
            }
            /* if(cn.conSQL(txtuser.Text,txtpass.Text)==1)
             {
                 MessageBox.Show("Ingresado Correctamente");
                 this.Hide();
                 Form2 v1 = new Form2();
                 v1.Show();
             }
             else
             {
                 MessageBox.Show("No ha sido encontrado");
             }*/
          /*  this.Hide();
            Form4 v2 = new Form4();
            v2.Show();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 v1 = new Form3();
            v1.Show();
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Funcion No habilitada");
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
