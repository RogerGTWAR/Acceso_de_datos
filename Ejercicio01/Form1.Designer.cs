namespace Ejercicio01
{
    partial class Form1
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
            btnNuevo = new Button();
            dgv = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(12, 139);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 46);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 208);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(776, 230);
            dgv.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(609, 139);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 46);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += Salir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(207, 139);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 46);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(416, 139);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(124, 46);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(dgv);
            Controls.Add(btnNuevo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private DataGridView dgv;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label1;
        private TextBox txtNombre;
    }
}
