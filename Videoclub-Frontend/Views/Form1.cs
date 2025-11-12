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
    public partial class Form1 : Form
    {
        private readonly PeliculasDbContext _context;
        private readonly PeliculasServices _services;

        public Form1()
        {
            InitializeComponent();

            _context = new PeliculasDbContext();
            _services = new PeliculasServices(_context);
        }

        private void peliculasDisp_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.Show();

            this.Hide();
        }
    }
}
