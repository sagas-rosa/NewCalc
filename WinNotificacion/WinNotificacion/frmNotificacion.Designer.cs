namespace WinNotificacion
{
    partial class frmNotificacion
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.Location = new System.Drawing.Point(38, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(588, 26);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "label1";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDireccion
            // 
            this.lbDireccion.Location = new System.Drawing.Point(35, 53);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(591, 25);
            this.lbDireccion.TabIndex = 1;
            this.lbDireccion.Text = "label2";
            this.lbDireccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTelefono
            // 
            this.lbTelefono.Location = new System.Drawing.Point(35, 93);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(591, 25);
            this.lbTelefono.TabIndex = 2;
            this.lbTelefono.Text = "label3";
            this.lbTelefono.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 127);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNotificacion";
            this.Text = "frmNotificacion";
            this.Load += new System.EventHandler(this.frmNotificacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelefono;
    }
}