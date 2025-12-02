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

namespace Videoclub.Frontend.Views
{
    public partial class Form10 : Form
    {
        private readonly AlquilerPeliculasMVC _api = new AlquilerPeliculasMVC();
        public Form10()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void dgvAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.RowHeadersVisible = false;
            dgvAlquileres.Columns["Id"].Visible = false;
            
        }

        private async void Form10_Load(object sender, EventArgs e)
        {
            var Alquileres = await _api.GetAlquiler();
            dgvAlquileres.DataSource = Alquileres;

        }
    }
}
