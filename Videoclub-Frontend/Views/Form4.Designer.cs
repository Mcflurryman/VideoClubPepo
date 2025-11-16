namespace Videoclub.Frontend.Views
{
    partial class Form4
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
            lblCategoria = new Label();
            lblDuracion = new Label();
            lblNombrePelicula = new Label();
            btnAlquilar = new Button();
            btnVolver = new Button();
            lblCategoria1 = new Label();
            lblDuracion1 = new Label();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(34, 153);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria :";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(34, 226);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(61, 15);
            lblDuracion.TabIndex = 1;
            lblDuracion.Text = "Duracion :";
            // 
            // lblNombrePelicula
            // 
            lblNombrePelicula.AutoSize = true;
            lblNombrePelicula.Location = new Point(117, 22);
            lblNombrePelicula.Name = "lblNombrePelicula";
            lblNombrePelicula.Size = new Size(51, 15);
            lblNombrePelicula.TabIndex = 3;
            lblNombrePelicula.Text = "Nombre";
            lblNombrePelicula.Click += lblNombrePelicula_Click;
            // 
            // btnAlquilar
            // 
            btnAlquilar.Location = new Point(88, 322);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(130, 51);
            btnAlquilar.TabIndex = 4;
            btnAlquilar.Text = "Alquilar";
            btnAlquilar.UseVisualStyleBackColor = true;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(216, 402);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCategoria1
            // 
            lblCategoria1.AutoSize = true;
            lblCategoria1.Location = new Point(145, 153);
            lblCategoria1.Name = "lblCategoria1";
            lblCategoria1.Size = new Size(38, 15);
            lblCategoria1.TabIndex = 6;
            lblCategoria1.Text = "label1";
            lblCategoria1.Click += lblCategoria1_Click;
            // 
            // lblDuracion1
            // 
            lblDuracion1.AutoSize = true;
            lblDuracion1.Location = new Point(145, 226);
            lblDuracion1.Name = "lblDuracion1";
            lblDuracion1.Size = new Size(38, 15);
            lblDuracion1.TabIndex = 7;
            lblDuracion1.Text = "label2";
            lblDuracion1.Click += lblDuracion1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 450);
            Controls.Add(lblDuracion1);
            Controls.Add(lblCategoria1);
            Controls.Add(btnVolver);
            Controls.Add(btnAlquilar);
            Controls.Add(lblNombrePelicula);
            Controls.Add(lblDuracion);
            Controls.Add(lblCategoria);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private Label lblDuracion;
        private Label lblNombrePelicula;
        private Button btnAlquilar;
        private Button btnVolver;
        private Label lblCategoria1;
        private Label lblDuracion1;
    }
}