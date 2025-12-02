namespace Videoclub.Frontend.Views
{
    partial class Form11
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
            btnBorrar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(66, 46);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 62);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "Borrar pelicula";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(126, 144);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 179);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrar;
        private Button btnVolver;
    }
}