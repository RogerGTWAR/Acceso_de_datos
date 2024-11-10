namespace Ado.Net
{
    partial class MakesForm
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
            dgvMakes = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMakes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 136);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 51);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvMakes
            // 
            dgvMakes.BackgroundColor = SystemColors.ControlLightLight;
            dgvMakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakes.Location = new Point(12, 193);
            dgvMakes.Name = "dgvMakes";
            dgvMakes.ReadOnly = true;
            dgvMakes.RowHeadersWidth = 51;
            dgvMakes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMakes.Size = new Size(333, 188);
            dgvMakes.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(114, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 30);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 66);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 9);
            label2.Name = "label2";
            label2.Size = new Size(112, 41);
            label2.TabIndex = 4;
            label2.Text = "Marcas";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLightLight;
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(210, 136);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(135, 51);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(12, 387);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 51);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ControlLightLight;
            btnVolver.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(230, 470);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(115, 51);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLightLight;
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(230, 391);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 47);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = SystemColors.ControlLightLight;
            btnRefrescar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.Location = new Point(12, 470);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(122, 51);
            btnRefrescar.TabIndex = 9;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // MakesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(357, 528);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(dgvMakes);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "MakesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakesForm";
            Load += MakesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMakes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dgvMakes;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnVolver;
        private Button btnBuscar;
        private Button btnRefrescar;
    }
}