using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace presentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void button2_Click(object sender, EventArgs e)
        {
          /*  FormUser v1 = new FormUser();
            this.Hide();
            v1.ShowDialog();
            this.Show();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
      
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }

        private void mostrarLogo()
        {
            AbrirFormEnPanel(new Logo());
        }
        private void btnprod_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrarLogo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void PanelBarraTitulo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form5());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormE());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa creado por Alexis Villegas!");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (MenuVertical.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Usuario,Seguro de salir?", " Esta a punto de cerrar!!!!" ,MessageBoxButtons.YesNo)==DialogResult.Yes)
            Application.Exit();
            else
            {

            }
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Admin";
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lbFecha_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Farmacia());
        }

        private void panelContenedorForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panelContenedorForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
