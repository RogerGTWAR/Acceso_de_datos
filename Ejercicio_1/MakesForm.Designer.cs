namespace Ejercicio_1
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
            dgvMakes = new DataGridView();
            btnAgregar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMakes).BeginInit();
            SuspendLayout();
            // 
            // dgvMakes
            // 
            dgvMakes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakes.Location = new Point(28, 227);
            dgvMakes.Name = "dgvMakes";
            dgvMakes.RowHeadersWidth = 51;
            dgvMakes.Size = new Size(340, 188);
            dgvMakes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(28, 161);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 49);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 65);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(252, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 49);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 41);
            label2.TabIndex = 5;
            label2.Text = "Makes";
            // 
            // MakesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(392, 429);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMakes);
            Name = "MakesForm";
            Text = "MakesForm";
            ((System.ComponentModel.ISupportInitialize)dgvMakes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMakes;
        private Button btnAgregar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Label label2;
    }
}