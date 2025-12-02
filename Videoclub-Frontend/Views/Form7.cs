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
using VideoClub.Backend.Models;

namespace Videoclub.Frontend.Views
{
    public partial class Form7 : Form
    {   
        private readonly AlquilerPelicula Alquiler = new AlquilerPelicula();
        private readonly VistaClienteAlquilerMVC _api = new VistaClienteAlquilerMVC();
        private readonly AlquilerPeliculasMVC _servApi = new AlquilerPeliculasMVC();
        VistaClienteAlquiler _alquilerSeleccionado;
        public Form7(VistaClienteAlquiler alquilerSeleccionado)
        {
            InitializeComponent();
            _alquilerSeleccionado = alquilerSeleccionado;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            Form6 form6 = new Form6(_alquilerSeleccionado.NombreCliente);
            form6.Show();
            this.Hide();
        }

        private async void btnDevolver_Click(object sender, EventArgs e)
        {
            var nuevaDevolucion = new AlquilerPelicula
            {
                NombreCliente = _alquilerSeleccionado.NombreCliente,
                FechaDevolucion = null
            };
            string resultado = await _servApi.devolverPelicula(_alquilerSeleccionado.IdPelicula.Value, nuevaDevolucion);

            MessageBox.Show(resultado);

        }
    }
}
