namespace Videoclub.Frontend.Views
{
    partial class Form5
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
            label1 = new Label();
            btxtNombre = new TextBox();
            lblIdPelicula = new Label();
            lblFechaDevolucion = new Label();
            btnAlquilar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 78);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su nombre por favor";
            // 
            // btxtNombre
            // 
            btxtNombre.Location = new Point(57, 104);
            btxtNombre.Name = "btxtNombre";
            btxtNombre.Size = new Size(100, 23);
            btxtNombre.TabIndex = 1;
            btxtNombre.TextChanged += btxtNombre_TextChanged;
            // 
            // lblIdPelicula
            // 
            lblIdPelicula.AutoSize = true;
            lblIdPelicula.Location = new Point(90, 21);
            lblIdPelicula.Name = "lblIdPelicula";
            lblIdPelicula.Size = new Size(38, 15);
            lblIdPelicula.TabIndex = 2;
            lblIdPelicula.Text = "label2";
            lblIdPelicula.Click += lblIdPelicula_Click;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Location = new Point(90, 164);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(38, 15);
            lblFechaDevolucion.TabIndex = 3;
            lblFechaDevolucion.Text = "label2";
            lblFechaDevolucion.Click += lblFechaDevolucion_Click;
            // 
            // btnAlquilar
            // 
            btnAlquilar.Location = new Point(74, 200);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(75, 23);
            btnAlquilar.TabIndex = 4;
            btnAlquilar.Text = "Alquilar";
            btnAlquilar.UseVisualStyleBackColor = true;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(134, 245);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 289);
            Controls.Add(btnVolver);
            Controls.Add(btnAlquilar);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblIdPelicula);
            Controls.Add(btxtNombre);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox btxtNombre;
        private Label lblIdPelicula;
        private Label lblFechaDevolucion;
        private Button btnAlquilar;
        private Button btnVolver;
    }
}