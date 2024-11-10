namespace Ejercicio_1
{
    partial class InicioForm
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
            btnMakes = new Button();
            btnInventario = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // btnMakes
            // 
            btnMakes.BackColor = SystemColors.ControlLightLight;
            btnMakes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMakes.Location = new Point(25, 45);
            btnMakes.Name = "btnMakes";
            btnMakes.Size = new Size(135, 52);
            btnMakes.TabIndex = 0;
            btnMakes.Text = "Makes";
            btnMakes.UseVisualStyleBackColor = false;
            btnMakes.Click += btnMakes_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.ControlLightLight;
            btnInventario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(25, 430);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(135, 52);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventory";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(12, 529);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 52);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Location = new Point(208, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 331);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(208, 430);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 341);
            panel2.TabIndex = 3;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1211, 783);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(btnInventario);
            Controls.Add(btnMakes);
            Name = "InicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMakes;
        private Button btnInventario;
        private Button btnSalir;
        private Panel panel1;
        private Panel panel2;
    }
}