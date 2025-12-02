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
    public partial class Form9 : Form
    {
        private readonly PeliculasMVC _api = new PeliculasMVC();
        public Form9()
        {
            InitializeComponent();
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Form9_Load(object sender, EventArgs e)
        {
            {
                var peliculas = await _api.GetPeliculas();
                dgvPeliculas.DataSource = peliculas;
                dgvPeliculas.RowHeadersVisible = false;
                dgvPeliculas.Columns["Id"].Visible = false;
                dgvPeliculas.Columns["Categoria"].Visible = false;
                dgvPeliculas.Columns["Duracion"].Visible = false;
                dgvPeliculas.Columns["EstaDisponible"].Visible = false;
                dgvPeliculas.BorderStyle = BorderStyle.None;
                dgvPeliculas.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgvPeliculas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;




            }
        }

        private void dgvPeliculas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var peliculaEncontrada = (Pelicula)dgvPeliculas
                       .Rows[e.RowIndex]
                       .DataBoundItem;

            Form11 form11 = new Form11(peliculaEncontrada);
            form11.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();



        }
    }
}
