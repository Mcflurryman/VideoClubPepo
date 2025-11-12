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
    public partial class Form3 : Form
    {
        private readonly PeliculasDbContext _context;
        private readonly PeliculasServices _services;
        public Form3()
        {
            InitializeComponent();
            _context = new PeliculasDbContext();
            _services = new PeliculasServices(_context);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void categoria_Click(object sender, EventArgs e)
        {
            var pelicula = _context.Peliculas.FirstOrDefault(p => p.Nombre == "Titanic");
            categoria.Text = pelicula.Categoria;
            categoria.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var pelicula = _context.Peliculas.FirstOrDefault(p => p.Nombre == "Titanic");
            categoria.Text = pelicula.Categoria;

            duracion.Text = pelicula.Duracion.ToString();

            categoria.Visible = true;
            duracion.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
