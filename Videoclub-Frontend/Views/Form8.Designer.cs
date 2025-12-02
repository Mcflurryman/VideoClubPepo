namespace Videoclub.Frontend.Views
{
    partial class Form8
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
            btnBorrarPeliculas = new Button();
            btnBorrarAlquileres = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnBorrarPeliculas
            // 
            btnBorrarPeliculas.Location = new Point(35, 112);
            btnBorrarPeliculas.Name = "btnBorrarPeliculas";
            btnBorrarPeliculas.Size = new Size(98, 80);
            btnBorrarPeliculas.TabIndex = 1;
            btnBorrarPeliculas.Text = "Borrar Peliculas";
            btnBorrarPeliculas.UseVisualStyleBackColor = true;
            btnBorrarPeliculas.Click += btnBorrarPeliculas_Click;
            // 
            // btnBorrarAlquileres
            // 
            btnBorrarAlquileres.Location = new Point(203, 112);
            btnBorrarAlquileres.Name = "btnBorrarAlquileres";
            btnBorrarAlquileres.Size = new Size(98, 80);
            btnBorrarAlquileres.TabIndex = 2;
            btnBorrarAlquileres.Text = "Borrar Alquileres";
            btnBorrarAlquileres.UseVisualStyleBackColor = true;
            btnBorrarAlquileres.Click += btnBorrarAlquileres_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(242, 277);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 312);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrarAlquileres);
            Controls.Add(btnBorrarPeliculas);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrarPeliculas;
        private Button btnBorrarAlquileres;
        private Button btnVolver;
    }
}