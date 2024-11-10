namespace Ejercicio1
{
    partial class Inicio
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
            btnInventario = new Button();
            btnMakes = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.ButtonHighlight;
            btnInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInventario.Location = new Point(14, 56);
            btnInventario.Margin = new Padding(3, 4, 3, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(134, 47);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventary";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnCustumer_Click;
            // 
            // btnMakes
            // 
            btnMakes.BackColor = SystemColors.ButtonHighlight;
            btnMakes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMakes.Location = new Point(14, 443);
            btnMakes.Margin = new Padding(3, 4, 3, 4);
            btnMakes.Name = "btnMakes";
            btnMakes.Size = new Size(134, 45);
            btnMakes.TabIndex = 1;
            btnMakes.Text = "Makes";
            btnMakes.UseVisualStyleBackColor = false;
            btnMakes.Click += btnMakes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Location = new Point(197, 56);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 371);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(197, 443);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 371);
            panel2.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.HighlightText;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(965, 759);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 55);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1070, 830);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Controls.Add(btnMakes);
            Controls.Add(btnInventario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInventario;
        private Button btnMakes;
        private Panel panel1;
        private Panel panel2;
        private Button btnSalir;
    }
}