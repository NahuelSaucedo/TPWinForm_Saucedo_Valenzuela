
namespace TPWinForm_Saucedo_Valenzuela
{
    partial class frmDetalle
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
            this.txtDetalleCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreDetalle = new System.Windows.Forms.TextBox();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.ptbDetalle = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetalleCodigo
            // 
            this.txtDetalleCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtDetalleCodigo.Location = new System.Drawing.Point(80, 21);
            this.txtDetalleCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalleCodigo.Name = "txtDetalleCodigo";
            this.txtDetalleCodigo.ReadOnly = true;
            this.txtDetalleCodigo.Size = new System.Drawing.Size(235, 22);
            this.txtDetalleCodigo.TabIndex = 5;
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreDetalle.Location = new System.Drawing.Point(80, 72);
            this.txtNombreDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.ReadOnly = true;
            this.txtNombreDetalle.Size = new System.Drawing.Size(235, 22);
            this.txtNombreDetalle.TabIndex = 6;
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrecioDetalle.Location = new System.Drawing.Point(80, 119);
            this.txtPrecioDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(235, 22);
            this.txtPrecioDetalle.TabIndex = 7;
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.Location = new System.Drawing.Point(15, 24);
            this.lblCodigoDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoDetalle.TabIndex = 8;
            this.lblCodigoDetalle.Text = "Codigo:";
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.Location = new System.Drawing.Point(15, 72);
            this.lblNombreDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(59, 16);
            this.lblNombreDetalle.TabIndex = 9;
            this.lblNombreDetalle.Text = "Nombre:";
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.Location = new System.Drawing.Point(15, 119);
            this.lblPrecioDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(49, 16);
            this.lblPrecioDetalle.TabIndex = 10;
            this.lblPrecioDetalle.Text = "Precio:";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(15, 162);
            this.lblDescripcionDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionDetalle.TabIndex = 11;
            this.lblDescripcionDetalle.Text = "Descripcion:";
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(18, 194);
            this.txtDescripcionDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionDetalle.Multiline = true;
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.ReadOnly = true;
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(299, 84);
            this.txtDescripcionDetalle.TabIndex = 12;
            // 
            // ptbDetalle
            // 
            this.ptbDetalle.Location = new System.Drawing.Point(363, 11);
            this.ptbDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbDetalle.Name = "ptbDetalle";
            this.ptbDetalle.Size = new System.Drawing.Size(317, 328);
            this.ptbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDetalle.TabIndex = 13;
            this.ptbDetalle.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(124, 301);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 39);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 352);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ptbDetalle);
            this.Controls.Add(this.txtDescripcionDetalle);
            this.Controls.Add(this.lblDescripcionDetalle);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblNombreDetalle);
            this.Controls.Add(this.lblCodigoDetalle);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.txtNombreDetalle);
            this.Controls.Add(this.txtDetalleCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalleCodigo;
        private System.Windows.Forms.TextBox txtNombreDetalle;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.PictureBox ptbDetalle;
        private System.Windows.Forms.Button btnOk;
    }
}