namespace PROYECTO_FINAL
{
    partial class EliminarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona Un Producto y Haz Click en Eliminar:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::PROYECTO_FINAL.Properties.Resources.trash_bin;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.Location = new System.Drawing.Point(54, 251);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(7);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(359, 94);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "Eliminar         ";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 29;
            this.listBoxProductos.Location = new System.Drawing.Point(54, 435);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(1064, 410);
            this.listBoxProductos.TabIndex = 3;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 714);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminar);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "EliminarProducto";
            this.Text = "FrmEliminarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProductos;
    }
}