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
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.pbxUrl = new System.Windows.Forms.PictureBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(52, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(139, 88);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(207, 22);
            this.txtnombre.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(139, 133);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(207, 22);
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.Location = new System.Drawing.Point(139, 47);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(207, 22);
            this.txtcodigo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(50, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 38);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 39);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(58, 178);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(48, 16);
            this.lblmarca.TabIndex = 8;
            this.lblmarca.Text = "Marca:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(37, 230);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(69, 16);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(57, 279);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(49, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Precio:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(139, 175);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(207, 22);
            this.txtmarca.TabIndex = 5;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(139, 224);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(207, 22);
            this.txtcategoria.TabIndex = 6;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(139, 273);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(207, 22);
            this.txtprecio.TabIndex = 7;
            // 
            // pbxUrl
            // 
            this.pbxUrl.Location = new System.Drawing.Point(391, 47);
            this.pbxUrl.Name = "pbxUrl";
            this.pbxUrl.Size = new System.Drawing.Size(349, 373);
            this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrl.TabIndex = 14;
            this.pbxUrl.TabStop = false;
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(21, 324);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(85, 16);
            this.lblurl.TabIndex = 15;
            this.lblurl.Text = "URL imagen:";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(139, 324);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(207, 22);
            this.txturl.TabIndex = 8;
            this.txturl.Leave += new System.EventHandler(this.txturl_Leave);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 446);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.pbxUrl);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtmarca);
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
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
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
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.PictureBox pbxUrl;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txturl;
    }
}