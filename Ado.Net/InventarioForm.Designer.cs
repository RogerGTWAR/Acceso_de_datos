namespace Ado.Net
{
    partial class InventarioForm
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
            label1 = new Label();
            txtColor = new TextBox();
            dgvInventario = new DataGridView();
            CbMake = new ComboBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            txtPetName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVolver = new Button();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 180);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 51);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 67);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 1;
            label1.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(12, 101);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 30);
            txtColor.TabIndex = 2;
            // 
            // dgvInventario
            // 
            dgvInventario.BackgroundColor = SystemColors.ControlLightLight;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(12, 250);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(590, 188);
            dgvInventario.TabIndex = 3;
            // 
            // CbMake
            // 
            CbMake.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbMake.FormattingEnabled = true;
            CbMake.Location = new Point(495, 101);
            CbMake.Name = "CbMake";
            CbMake.Size = new Size(93, 31);
            CbMake.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLightLight;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(161, 180);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 51);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(337, 180);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 51);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtPetName
            // 
            txtPetName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPetName.Location = new Point(250, 101);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(125, 30);
            txtPetName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 67);
            label2.Name = "label2";
            label2.Size = new Size(254, 31);
            label2.TabIndex = 8;
            label2.Text = "Nombre De La Mascota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(460, 67);
            label3.Name = "label3";
            label3.Size = new Size(160, 31);
            label3.TabIndex = 9;
            label3.Text = "Id de la Marca";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 9);
            label4.Name = "label4";
            label4.Size = new Size(155, 41);
            label4.TabIndex = 10;
            label4.Text = "Inventory";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(412, 444);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 51);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLightLight;
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(481, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 51);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = SystemColors.ControlLightLight;
            btnRefrescar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(73, 444);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(125, 51);
            btnRefrescar.TabIndex = 13;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(616, 502);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPetName);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(CbMake);
            Controls.Add(dgvInventario);
            Controls.Add(txtColor);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "InventarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventarioForm";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private TextBox txtColor;
        private DataGridView dgvInventario;
        private ComboBox CbMake;
        private Button btnActualizar;
        private Button btnEliminar;
        private TextBox txtPetName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVolver;
        private Button btnBuscar;
        private Button btnRefrescar;
    }
}