namespace Entity_Framework
{
    partial class CustomerForm
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
            btnAgregar = new Button();
            dgvCustomer = new DataGridView();
            label1 = new Label();
            txtFirstName = new TextBox();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnBuscar = new Button();
            txtLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 136);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 49);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.BackgroundColor = SystemColors.ControlLightLight;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(140, 201);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(453, 174);
            dgvCustomer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 55);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(96, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 30);
            txtFirstName.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ControlLightLight;
            btnVolver.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(599, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 49);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(420, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 49);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLightLight;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(191, 136);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(137, 49);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLightLight;
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(599, 136);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(122, 49);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(454, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(164, 30);
            txtLastName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 9);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 9;
            label2.Text = "Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 55);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = SystemColors.ControlLightLight;
            btnRefrescar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(12, 326);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(122, 49);
            btnRefrescar.TabIndex = 11;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(727, 387);
            Controls.Add(btnRefrescar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(dgvCustomer);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dgvCustomer;
        private Label label1;
        private TextBox txtFirstName;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnBuscar;
        private TextBox txtLastName;
        private Label label2;
        private Label label3;
        private Button btnRefrescar;
    }
}