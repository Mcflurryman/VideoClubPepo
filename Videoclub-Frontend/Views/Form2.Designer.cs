namespace Videoclub_Frontend.Views
{
    partial class Form2
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
            btnReturn = new Button();
            btnTitanic = new Button();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(71, 24);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Atras";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // btnTitanic
            // 
            btnTitanic.Location = new Point(60, 91);
            btnTitanic.Name = "btnTitanic";
            btnTitanic.Size = new Size(86, 90);
            btnTitanic.TabIndex = 1;
            btnTitanic.Text = "Titanic";
            btnTitanic.UseVisualStyleBackColor = true;
            btnTitanic.Click += btnTitanic_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTitanic);
            Controls.Add(btnReturn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnreturn;
        private DataGridView dgvPeliculasDisponibles;
        private Button btnReturn;
        private Button btnTitanic;
    }
}