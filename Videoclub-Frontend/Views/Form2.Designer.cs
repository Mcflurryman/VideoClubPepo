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
            dgvPeliculas = new DataGridView();
            kabel2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(228, 406);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Atras";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(90, 62);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(116, 280);
            dgvPeliculas.TabIndex = 1;
            dgvPeliculas.CellClick += dgvPeliculas_CellClick;
            // 
            // kabel2
            // 
            kabel2.AutoSize = true;
            kabel2.Location = new Point(122, 24);
            kabel2.Name = "kabel2";
            kabel2.Size = new Size(53, 15);
            kabel2.TabIndex = 2;
            kabel2.Text = "Peliculas";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(kabel2);
            Controls.Add(dgvPeliculas);
            Controls.Add(btnReturn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnreturn;
        private DataGridView dgvPeliculasDisponibles;
        private Button btnReturn;
        private DataGridView dgvPeliculas;
        private Label kabel2;
    }
}