namespace Videoclub.Frontend.Views
{
    partial class Form7
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
            btnDevolver = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(48, 80);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(104, 79);
            btnDevolver.TabIndex = 0;
            btnDevolver.Text = "Devolver pelicula";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(133, 221);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 256);
            Controls.Add(btnVolver);
            Controls.Add(btnDevolver);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDevolver;
        private Button btnVolver;
    }
}