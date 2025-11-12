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
            peliculasTotales = new Button();
            Titulo = new Label();
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
            // peliculasTotales
            // 
            peliculasTotales.Location = new Point(505, 182);
            peliculasTotales.Name = "peliculasTotales";
            peliculasTotales.Size = new Size(162, 63);
            peliculasTotales.TabIndex = 1;
            peliculasTotales.Text = "Peliculas en el catalogo";
            peliculasTotales.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titulo);
            Controls.Add(peliculasTotales);
            Controls.Add(peliculasDisp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button peliculasDisp;
        private Button peliculasTotales;
        private Label Titulo;
    }
}