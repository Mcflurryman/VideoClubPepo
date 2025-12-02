using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoclub.Frontend.Views;


namespace Videoclub_Frontend.Views
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void peliculasDisp_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peliculasTotales_Click(object sender, EventArgs e)
        {
            var nombreCliente = txtbNombreCliente.Text;
            txtbNombreCliente.Visible = true;
            txtbNombreCliente.Visible = true;
            btnEntrar.Visible = true;


            // Form6 form6 = new Form6(nombreCliente.Text);

            //form6.Show();
            //this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var nombreCliente = txtbNombreCliente.Text;
            Form6 form6 = new Form6(nombreCliente);

            form6.Show();
            this.Hide();


        }

        private void btnRestringido_Click(object sender, EventArgs e)
        {
            txtbContraseña.Visible = true;
            btnEntrarZona.Visible = true;
        }

        private void txtbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrarZona_Click(object sender, EventArgs e)
        {
            if (txtbContraseña.Text == "admin123")
            {
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.");
            }
        }
    }
}
