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
using Videoclub.Frontend.Models;
using Videoclub.Frontend.Views;

namespace Videoclub_Frontend.Views
{
    public partial class Form2 : Form
    {
        private readonly PeliculasMVC _api = new PeliculasMVC();

        public Form2()
        {
            InitializeComponent();

        }

        private async void Form2_Load(object sender, EventArgs e)
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


        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPeliculas.ReadOnly = true;

            if (e.RowIndex < 0)
            {
                return;
            }
           

            var peliculas = (Pelicula)dgvPeliculas
                       .Rows[e.RowIndex]
                       .DataBoundItem;

            Form4 form4 = new Form4(peliculas);
            form4.Show();
            this.Hide();

        }
    }
}
