using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoclub.Shared.Data;
using VideoclubFrontend.Services;

namespace Videoclub_Frontend.Views
{
    public partial class Form2 : Form
    {
        private readonly PeliculasDbContext _context;
        private readonly PeliculasServices _services;
        public Form2()
        {
            InitializeComponent();
            _context = new PeliculasDbContext();
            _services = new PeliculasServices(_context);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnTitanic_Click(object sender, EventArgs e)
        {
            var pelicula = _context.Peliculas.FirstOrDefault(p => p.Nombre == "Titanic");

            if (pelicula == null)
            {
                MessageBox.Show("La pelicula ya no esta en nuestro catalogo");
            }
            else if (pelicula != null)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }
        }
    }
}
