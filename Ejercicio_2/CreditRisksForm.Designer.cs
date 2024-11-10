namespace Ejercicio_2
{
    partial class CreditRisksForm
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
            dgvCreditRisks = new DataGridView();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtApellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CbCustomer = new ComboBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).BeginInit();
            SuspendLayout();
            // 
            // dgvCreditRisks
            // 
            dgvCreditRisks.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCreditRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditRisks.Location = new Point(12, 225);
            dgvCreditRisks.Name = "dgvCreditRisks";
            dgvCreditRisks.ReadOnly = true;
            dgvCreditRisks.RowHeadersWidth = 51;
            dgvCreditRisks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCreditRisks.Size = new Size(588, 151);
            dgvCreditRisks.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 160);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 59);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 66);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(157, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 59);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLightLight;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(299, 160);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(141, 59);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(240, 100);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 27);
            txtApellido.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(271, 66);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(210, 9);
            label4.Name = "label4";
            label4.Size = new Size(185, 41);
            label4.TabIndex = 8;
            label4.Text = "Credit Risks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(459, 66);
            label5.Name = "label5";
            label5.Size = new Size(132, 31);
            label5.TabIndex = 9;
            label5.Text = "CustomerId";
            // 
            // CbCustomer
            // 
            CbCustomer.FormattingEnabled = true;
            CbCustomer.Location = new Point(449, 99);
            CbCustomer.Name = "CbCustomer";
            CbCustomer.Size = new Size(151, 28);
            CbCustomer.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLightLight;
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(459, 160);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(141, 59);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CreditRisksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(612, 384);
            Controls.Add(btnRefresh);
            Controls.Add(CbCustomer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCreditRisks);
            Name = "CreditRisksForm";
            Text = "CreditRisksForm";
            Load += CreditRisksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCreditRisks;
        private Button btnAgregar;
        private TextBox txtNombre;
        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtApellido;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CbCustomer;
        private Button btnRefresh;
    }
}