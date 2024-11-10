namespace Ejercicio1
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCustomers = new Button();
            Panel = new Panel();
            btnCreditRisks = new Button();
            label1 = new Label();
            Panel2 = new Panel();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.HighlightText;
            btnCustomers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(256, 66);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(174, 51);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customer";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click_1;
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.HighlightText;
            Panel.Location = new Point(12, 123);
            Panel.Name = "Panel";
            Panel.Size = new Size(663, 415);
            Panel.TabIndex = 1;
            // 
            // btnCreditRisks
            // 
            btnCreditRisks.BackColor = SystemColors.HighlightText;
            btnCreditRisks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreditRisks.Location = new Point(1044, 66);
            btnCreditRisks.Name = "btnCreditRisks";
            btnCreditRisks.Size = new Size(161, 51);
            btnCreditRisks.TabIndex = 0;
            btnCreditRisks.Text = "Credit Risks";
            btnCreditRisks.UseVisualStyleBackColor = false;
            btnCreditRisks.Click += btnCreditRisks_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(502, 46);
            label1.TabIndex = 0;
            label1.Text = "Sistema con Entity Framework";
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.HighlightText;
            Panel2.Location = new Point(762, 123);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(630, 415);
            Panel2.TabIndex = 0;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1404, 554);
            Controls.Add(Panel2);
            Controls.Add(label1);
            Controls.Add(btnCreditRisks);
            Controls.Add(Panel);
            Controls.Add(btnCustomers);
            MaximizeBox = false;
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomers;
        private Panel Panel;
        private Button btnCreditRisks;
        private Label label1;
        private Panel Panel2;
    }
}
