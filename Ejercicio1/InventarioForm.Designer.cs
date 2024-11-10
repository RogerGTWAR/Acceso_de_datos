namespace Ejercicio1
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
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            label2 = new Label();
            txtColor = new TextBox();
            txtPetName = new TextBox();
            CbMake = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.HighlightText;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevo.Location = new Point(14, 152);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 57);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HighlightText;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(198, 152);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 57);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.HighlightText;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnActualizar.Location = new Point(375, 152);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 57);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 4;
            label1.Text = "Color";
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(14, 217);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(511, 184);
            dgv.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(213, 50);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 6;
            label2.Text = "PetName";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(12, 86);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(134, 27);
            txtColor.TabIndex = 7;
            txtColor.TextChanged += textBox1_TextChanged;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(198, 86);
            txtPetName.Margin = new Padding(3, 4, 3, 4);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(142, 27);
            txtPetName.TabIndex = 8;
            // 
            // CbMake
            // 
            CbMake.FormattingEnabled = true;
            CbMake.Location = new Point(374, 85);
            CbMake.Name = "CbMake";
            CbMake.Size = new Size(151, 28);
            CbMake.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(417, 51);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 10;
            label3.Text = "Make";
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(537, 419);
            Controls.Add(label3);
            Controls.Add(CbMake);
            Controls.Add(txtPetName);
            Controls.Add(txtColor);
            Controls.Add(label2);
            Controls.Add(dgv);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventarioForm";
            Load += InventarioForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label1;
        private DataGridView dgv;
        private Label label2;
        private TextBox txtColor;
        private TextBox txtPetName;
        private ComboBox CbMake;
        private Label label3;
    }
}