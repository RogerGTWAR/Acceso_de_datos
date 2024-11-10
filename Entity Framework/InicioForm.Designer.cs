namespace Entity_Framework
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
            btnCustomers = new Button();
            btnCreditRisks = new Button();
            label1 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.ControlLightLight;
            btnCustomers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(88, 63);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(116, 47);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Clientes";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnCreditRisks
            // 
            btnCreditRisks.BackColor = SystemColors.ControlLightLight;
            btnCreditRisks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreditRisks.Location = new Point(424, 63);
            btnCreditRisks.Name = "btnCreditRisks";
            btnCreditRisks.Size = new Size(116, 47);
            btnCreditRisks.TabIndex = 1;
            btnCreditRisks.Text = "Riesgos";
            btnCreditRisks.UseVisualStyleBackColor = false;
            btnCreditRisks.Click += btnCreditRisks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 41);
            label1.TabIndex = 2;
            label1.Text = "Sistema con Entity Framework";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(262, 95);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 47);
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
            ClientSize = new Size(625, 154);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnCreditRisks);
            Controls.Add(btnCustomers);
            MaximizeBox = false;
            Name = "InicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomers;
        private Button btnCreditRisks;
        private Label label1;
        private Button btnSalir;
    }
}