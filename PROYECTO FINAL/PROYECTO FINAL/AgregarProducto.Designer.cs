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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarproducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(12, 91);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(207, 20);
            this.txtnombreproducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el producto:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(253, 90);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 3;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAgregarproducto.Image = global::PROYECTO_FINAL.Properties.Resources.tag;
            this.btnAgregarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarproducto.Location = new System.Drawing.Point(12, 128);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(150, 46);
            this.btnAgregarproducto.TabIndex = 0;
            this.btnAgregarproducto.Text = "Agregar";
            this.btnAgregarproducto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.btnAgregarproducto);
            this.Name = "AgregarProducto";
            this.Text = "FrmAgregarProducto";
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