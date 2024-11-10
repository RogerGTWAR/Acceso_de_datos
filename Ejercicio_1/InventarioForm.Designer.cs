namespace Ejercicio_1
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
            dgvInventario = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            txtColor = new TextBox();
            txtPetName = new TextBox();
            CbMake = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.BackgroundColor = SystemColors.ButtonHighlight;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(12, 239);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(531, 174);
            dgvInventario.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 170);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 50);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(416, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(12, 108);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(163, 27);
            txtColor.TabIndex = 4;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(203, 108);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(163, 27);
            txtPetName.TabIndex = 5;
            // 
            // CbMake
            // 
            CbMake.FormattingEnabled = true;
            CbMake.Location = new Point(392, 107);
            CbMake.Name = "CbMake";
            CbMake.Size = new Size(151, 28);
            CbMake.TabIndex = 6;
            CbMake.SelectedIndexChanged += CbMake_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 74);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 7;
            label1.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 74);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 8;
            label2.Text = "PetName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(432, 73);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 9;
            label3.Text = "Makes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(232, 9);
            label4.Name = "label4";
            label4.Size = new Size(143, 41);
            label4.TabIndex = 10;
            label4.Text = "Inventory";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLightLight;
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(203, 170);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 48);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(556, 425);
            Controls.Add(btnBuscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CbMake);
            Controls.Add(txtPetName);
            Controls.Add(txtColor);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvInventario);
            Name = "InventarioForm";
            Text = "InventarioForm";
            Load += InventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventario;
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtColor;
        private TextBox txtPetName;
        private ComboBox CbMake;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBuscar;
    }
}