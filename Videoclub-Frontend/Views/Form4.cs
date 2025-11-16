
using Videoclub.Frontend.Models;
using Videoclub_Frontend.Views;


namespace Videoclub.Frontend.Views
{
    public partial class Form4 : Form
    {
        Pelicula _pelicula;
        public Form4(Pelicula peliculas)
        {
            InitializeComponent();
            _pelicula = peliculas;


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblCategoria1.Text = _pelicula.Categoria;
            lblNombrePelicula.Text = _pelicula.Nombre;
            lblDuracion1.Text = _pelicula.Duracion.ToString();


        }

        private void lblNombrePelicula_Click(object sender, EventArgs e)
        {
            lblNombrePelicula.Text = _pelicula.Nombre;
        }

        private void lblCategoria1_Click(object sender, EventArgs e)
        {
            lblCategoria1.Text = _pelicula.Categoria;
        }

        private void lblDuracion1_Click(object sender, EventArgs e)
        {
            lblNombrePelicula.Text = _pelicula.Duracion.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(_pelicula);
            form5.Show();
            this.Hide();
        }
    }
}
