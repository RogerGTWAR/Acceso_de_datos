namespace Entity_Framework
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
            label1 = new Label();
            txtRiesgo = new TextBox();
            CbCustomer = new ComboBox();
            btnAgregar = new Button();
            btnVolver = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label2 = new Label();
            txtTipo = new TextBox();
            btnRefrescar = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).BeginInit();
            SuspendLayout();
            // 
            // dgvCreditRisks
            // 
            dgvCreditRisks.BackgroundColor = SystemColors.ControlLightLight;
            dgvCreditRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditRisks.Location = new Point(164, 250);
            dgvCreditRisks.Name = "dgvCreditRisks";
            dgvCreditRisks.ReadOnly = true;
            dgvCreditRisks.RowHeadersWidth = 51;
            dgvCreditRisks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCreditRisks.Size = new Size(570, 188);
            dgvCreditRisks.TabIndex = 1;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 71);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 2;
            label1.Text = "Riesgo";
            // 
            // txtRiesgo
            // 
            txtRiesgo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRiesgo.Location = new Point(106, 103);
            txtRiesgo.Name = "txtRiesgo";
            txtRiesgo.Size = new Size(170, 30);
            txtRiesgo.TabIndex = 3;
            // 
            // CbCustomer
            // 
            CbCustomer.FormattingEnabled = true;
            CbCustomer.Location = new Point(647, 105);
            CbCustomer.Name = "CbCustomer";
            CbCustomer.Size = new Size(108, 28);
            CbCustomer.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(32, 190);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 51);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ControlLightLight;
            btnVolver.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(740, 387);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 51);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLightLight;
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(740, 190);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 51);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(540, 193);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 51);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLightLight;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(260, 190);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(145, 51);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(441, 71);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 9;
            label2.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipo.Location = new Point(386, 105);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(170, 30);
            txtTipo.TabIndex = 10;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = SystemColors.ControlLightLight;
            btnRefrescar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(12, 387);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(146, 51);
            btnRefrescar.TabIndex = 11;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(619, 71);
            label3.Name = "label3";
            label3.Size = new Size(153, 31);
            label3.TabIndex = 12;
            label3.Text = "Id de Clientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(260, 9);
            label4.Name = "label4";
            label4.Size = new Size(279, 41);
            label4.TabIndex = 13;
            label4.Text = "Riesgos crediticios";
            // 
            // CreditRisksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(869, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRefrescar);
            Controls.Add(txtTipo);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(CbCustomer);
            Controls.Add(txtRiesgo);
            Controls.Add(label1);
            Controls.Add(dgvCreditRisks);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "CreditRisksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreditRisksForm";
            Load += CreditRisksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCreditRisks;
        private Label label1;
        private TextBox txtRiesgo;
        private ComboBox CbCustomer;
        private Button btnAgregar;
        private Button btnVolver;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label2;
        private TextBox txtTipo;
        private Button btnRefrescar;
        private Label label3;
        private Label label4;
    }
}