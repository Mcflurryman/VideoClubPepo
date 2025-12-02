using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoclub.Frontend.Services;
using VideoClub.Backend.Models;
using Videoclub_Frontend.Views;

namespace Videoclub.Frontend.Views
{

    public partial class Form6 : Form
    {
        private readonly VistaClienteAlquilerMVC _api = new VistaClienteAlquilerMVC();
        private readonly string _nombreCliente;
        public Form6(string nombreCliente)
        {
            InitializeComponent();
            _nombreCliente = nombreCliente;
        }

        private void dgvAlquileres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<VistaClienteAlquiler>? datasource = (sender as DataGridView)!.DataSource as List<VistaClienteAlquiler>;
            if (datasource != null)
            {
                VistaClienteAlquiler? seleccionado = datasource[e.RowIndex];
                if (seleccionado != null)
                {
                    var Alquileres = new VistaClienteAlquiler
                    {
                        IdPelicula = seleccionado.IdPelicula,
                        NombreCliente = seleccionado.NombreCliente,
                        NombrePelicula = seleccionado.NombrePelicula,
                        FechaAlquiler = seleccionado.FechaAlquiler,
                        FechaDevolucion = seleccionado.FechaDevolucion
                    };
                    Form7 form7 = new Form7(Alquileres);

                    this.Hide();
                    form7.ShowDialog();

                }
            }

        }

        private async void Form6_Load(object sender, EventArgs e)
        {
            var Alquileres = await _api.GetAlquilerPorNombre(_nombreCliente);

            dgvAlquileres.DataSource = Alquileres;

            dgvAlquileres.Columns["IdPelicula"].Visible = false;

            dgvAlquileres.RowHeadersVisible = false;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
