namespace PROYECTO_FINAL
{
    partial class MostrarProductos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 92;
            this.dgvProductos.RowTemplate.Height = 37;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(2182, 335);
            this.dgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de productos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.cross_14793290;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Location = new System.Drawing.Point(2084, 975);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 87);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // MostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2603, 1089);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MostrarProductos";
            this.Text = "Mostrar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}