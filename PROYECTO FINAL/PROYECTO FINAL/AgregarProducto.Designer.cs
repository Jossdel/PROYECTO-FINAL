namespace PROYECTO_FINAL
{
    partial class AgregarProducto
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

        private void InitializeComponent()
        {
            this.btnAgregarproducto = new System.Windows.Forms.Button();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAgregarproducto.Location = new System.Drawing.Point(28, 286);
            this.btnAgregarproducto.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(350, 103);
            this.btnAgregarproducto.TabIndex = 0;
            this.btnAgregarproducto.Text = "Agregar";
            this.btnAgregarproducto.UseVisualStyleBackColor = false;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(28, 203);
            this.txtnombreproducto.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(478, 35);
            this.txtnombreproducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el producto:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(590, 201);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(277, 37);
            this.comboBoxCategoria.TabIndex = 3;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoría";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.btnAgregarproducto);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "AgregarProducto";
            this.Text = "FrmAgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label2;
    }
}
