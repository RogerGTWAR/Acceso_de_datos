namespace Ado.Net
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
            btnInventario = new Button();
            btnMakes = new Button();
            label1 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnInventario
            // 
            btnInventario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(462, 66);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(132, 46);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnMakes
            // 
            btnMakes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMakes.Location = new Point(86, 66);
            btnMakes.Name = "btnMakes";
            btnMakes.Size = new Size(108, 46);
            btnMakes.TabIndex = 1;
            btnMakes.Text = "Marcas";
            btnMakes.UseVisualStyleBackColor = true;
            btnMakes.Click += btnMakes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 41);
            label1.TabIndex = 2;
            label1.Text = "Sistema Con Ado.Net";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(270, 102);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(643, 152);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnMakes);
            Controls.Add(btnInventario);
            MaximizeBox = false;
            Name = "InicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInventario;
        private Button btnMakes;
        private Label label1;
        private Button btnSalir;
    }
}