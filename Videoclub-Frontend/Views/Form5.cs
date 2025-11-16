using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoclub.Frontend.Models;
using Videoclub.Frontend.Services;

namespace Videoclub.Frontend.Views
{
    public partial class Form5 : Form
    {
        Pelicula _pelicula;
        private readonly AlquilerPeliculasMVC _api = new AlquilerPeliculasMVC();
        private readonly PeliculasMVC _apiPeliculas = new PeliculasMVC();
        public Form5(Pelicula peliculas)
        {
            InitializeComponent();
            _pelicula = peliculas;
        }

        private void btxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdPelicula_Click(object sender, EventArgs e)
        {
            lblIdPelicula.Text = _pelicula.Id.ToString();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblIdPelicula.Text = _pelicula.Id.ToString();
            lblIdPelicula.Visible = false;
            lblFechaDevolucion.Visible = false; 
        }

        private void lblFechaDevolucion_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_pelicula);
            form4.Show();
            this.Hide();
        }

        private async void btnAlquilar_Click(object sender, EventArgs e)
        {
            var nuevoAlquiler = new AlquilerPelicula
            {
                NombreCliente = btxtNombre.Text,
                FechaAlquiler = null,
                IdPelicula = int.Parse(lblIdPelicula.Text)

            };
            string resultado = await _api.PostAlquiler(nuevoAlquiler);

            MessageBox.Show(resultado);

        }
    }
}
