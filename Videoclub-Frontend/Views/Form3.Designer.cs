namespace Videoclub_Frontend.Views
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            categoria = new Label();
            duracion = new Label();
            btnVolver = new Button();
            btnAlquilar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "TITANIC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Categoria :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 124);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Duracion :";
            // 
            // categoria
            // 
            categoria.AutoSize = true;
            categoria.Location = new Point(131, 74);
            categoria.Name = "categoria";
            categoria.Size = new Size(38, 15);
            categoria.TabIndex = 4;
            categoria.Text = "label5";
            categoria.Visible = false;
            categoria.Click += categoria_Click;
            // 
            // duracion
            // 
            duracion.AutoSize = true;
            duracion.Location = new Point(131, 124);
            duracion.Name = "duracion";
            duracion.Size = new Size(38, 15);
            duracion.TabIndex = 6;
            duracion.Text = "label5";
            duracion.Visible = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(60, 285);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAlquilar
            // 
            btnAlquilar.Location = new Point(60, 168);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(95, 95);
            btnAlquilar.TabIndex = 8;
            btnAlquilar.Text = "Alquilar";
            btnAlquilar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 331);
            Controls.Add(btnAlquilar);
            Controls.Add(btnVolver);
            Controls.Add(duracion);
            Controls.Add(categoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label categoria;
        private Label duracion;
        private Button btnVolver;
        private Button btnAlquilar;
    }
}