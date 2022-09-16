namespace TPWinForm_Saucedo_Valenzuela
{
    partial class frmAltaArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.pbxUrl = new System.Windows.Forms.PictureBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 72);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 110);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(39, 38);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(104, 72);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(156, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(104, 108);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(156, 20);
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.Location = new System.Drawing.Point(104, 38);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(156, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 311);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 31);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 310);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(44, 145);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 8;
            this.lblmarca.Text = "Marca:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(28, 187);
            this.lblcategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(55, 13);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(43, 227);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(104, 222);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(156, 20);
            this.txtprecio.TabIndex = 7;
            // 
            // pbxUrl
            // 
            this.pbxUrl.Location = new System.Drawing.Point(414, 11);
            this.pbxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.pbxUrl.Name = "pbxUrl";
            this.pbxUrl.Size = new System.Drawing.Size(173, 162);
            this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrl.TabIndex = 14;
            this.pbxUrl.TabStop = false;
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(16, 263);
            this.lblurl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(69, 13);
            this.lblurl.TabIndex = 15;
            this.lblurl.Text = "URL imagen:";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(104, 263);
            this.txturl.Margin = new System.Windows.Forms.Padding(2);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(156, 20);
            this.txturl.TabIndex = 8;
            this.txturl.Leave += new System.EventHandler(this.txturl_Leave);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(104, 145);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(156, 21);
            this.cbxMarca.TabIndex = 16;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(104, 184);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(156, 21);
            this.cbxCategoria.TabIndex = 17;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 362);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.pbxUrl);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.PictureBox pbxUrl;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}