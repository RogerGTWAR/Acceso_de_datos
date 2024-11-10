namespace Ejercicio_2
{
    partial class CustomersForm
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
            dgvCustomers = new DataGridView();
            txtApellido = new TextBox();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();

            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = SystemColors.ControlLightLight;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(112, 191);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(456, 168);
            dgvCustomers.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(469, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(165, 27);
            txtApellido.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLightLight;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(336, 129);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(132, 56);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(519, 49);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 27);
            txtNombre.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(183, 129);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 56);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(23, 129);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 56);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 9);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 8;
            label3.Text = "Customers";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLightLight;
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(502, 129);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(132, 56);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(646, 375);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(txtApellido);
            Controls.Add(dgvCustomers);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private TextBox txtApellido;
        private Button btnActualizar;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label3;
        private Button btnRefresh;
    }
}