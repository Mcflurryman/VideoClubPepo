namespace Videoclub_Frontend.Views
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            peliculasDisp = new Button();
            btnAlquileres = new Button();
            Titulo = new Label();
            btnEntrar = new Button();
            txtbNombreCliente = new TextBox();
            label1 = new Label();
            btnRestringido = new Button();
            txtbContraseña = new TextBox();
            btnEntrarZona = new Button();
            SuspendLayout();
            // 
            // peliculasDisp
            // 
            peliculasDisp.Location = new Point(76, 182);
            peliculasDisp.Name = "peliculasDisp";
            peliculasDisp.Size = new Size(152, 63);
            peliculasDisp.TabIndex = 0;
            peliculasDisp.Text = "Peliculas Disponibles";
            peliculasDisp.UseVisualStyleBackColor = true;
            peliculasDisp.Click += peliculasDisp_Click;
            // 
            // btnAlquileres
            // 
            btnAlquileres.Location = new Point(505, 182);
            btnAlquileres.Name = "btnAlquileres";
            btnAlquileres.Size = new Size(162, 63);
            btnAlquileres.TabIndex = 1;
            btnAlquileres.Text = "Mis Alquileres";
            btnAlquileres.UseVisualStyleBackColor = true;
            btnAlquileres.Click += peliculasTotales_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(326, 28);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(72, 15);
            Titulo.TabIndex = 2;
            Titulo.Text = "¡Bienvenido!";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(551, 342);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Visible = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtbNombreCliente
            // 
            txtbNombreCliente.Location = new Point(530, 295);
            txtbNombreCliente.Name = "txtbNombreCliente";
            txtbNombreCliente.Size = new Size(120, 23);
            txtbNombreCliente.TabIndex = 4;
            txtbNombreCliente.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 263);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 5;
            label1.Text = "Inserte su nombre por favor";
            label1.Visible = false;
            // 
            // btnRestringido
            // 
            btnRestringido.Location = new Point(635, 28);
            btnRestringido.Name = "btnRestringido";
            btnRestringido.Size = new Size(94, 41);
            btnRestringido.TabIndex = 6;
            btnRestringido.Text = "Zona Restringida";
            btnRestringido.UseVisualStyleBackColor = true;
            btnRestringido.Click += btnRestringido_Click;
            // 
            // txtbContraseña
            // 
            txtbContraseña.Location = new Point(635, 75);
            txtbContraseña.Name = "txtbContraseña";
            txtbContraseña.Size = new Size(94, 23);
            txtbContraseña.TabIndex = 7;
            txtbContraseña.UseSystemPasswordChar = true;
            txtbContraseña.Visible = false;
            txtbContraseña.TextChanged += txtbContraseña_TextChanged;
            // 
            // btnEntrarZona
            // 
            btnEntrarZona.Location = new Point(644, 104);
            btnEntrarZona.Name = "btnEntrarZona";
            btnEntrarZona.Size = new Size(75, 23);
            btnEntrarZona.TabIndex = 8;
            btnEntrarZona.Text = "Entrar";
            btnEntrarZona.UseVisualStyleBackColor = true;
            btnEntrarZona.Visible = false;
            btnEntrarZona.Click += btnEntrarZona_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrarZona);
            Controls.Add(txtbContraseña);
            Controls.Add(btnRestringido);
            Controls.Add(label1);
            Controls.Add(txtbNombreCliente);
            Controls.Add(btnEntrar);
            Controls.Add(Titulo);
            Controls.Add(btnAlquileres);
            Controls.Add(peliculasDisp);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button peliculasDisp;
        private Button btnAlquileres;
        private Label Titulo;
        private Button btnEntrar;
        private TextBox txtbNombreCliente;
        private Label label1;
        private Button btnRestringido;
        private TextBox txtbContraseña;
        private Button btnEntrarZona;
    }
}