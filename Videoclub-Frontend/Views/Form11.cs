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
    public partial class Form11 : Form
    {
        Pelicula _peliculaEncontrada;
        PeliculasMVC _api = new PeliculasMVC();
        public Form11(Pelicula peliculaEncontrada)
        {
            InitializeComponent();
            _peliculaEncontrada = peliculaEncontrada;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            var delete = await _api.DeletePelicula(_peliculaEncontrada.Id);
            MessageBox.Show(delete);

        }
    }
}
