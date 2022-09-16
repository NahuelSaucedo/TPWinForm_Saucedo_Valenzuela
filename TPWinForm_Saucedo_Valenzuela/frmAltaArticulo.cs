using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace TPWinForm_Saucedo_Valenzuela
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulo.Nombre = txtnombre.Text;
                articulo.Descripcion = txtdescripcion.Text;
                articulo.Codigo = txtcodigo.Text;
                articulo.ImagenUrl = txturl.Text;
                articulo.Marca.descripcion = txtdescripcion.Text;
                articulo.Categoria.descripcion = cbxCategoria.Text;
                articulo.Precio = decimal.Parse(txtprecio.Text);

                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());            
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrl.Load(imagen);
            }
            catch (Exception)
            {
                pbxUrl.Load("https://th.bing.com/th/id/OIP.B1009X_jAfBqCSnF7pd7mQHaE7?pid=ImgDet&rs=1");
            }
        }

        private void txturl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txturl.Text);
        }


        private void cargarbox()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            MarcaNegocio dato = new MarcaNegocio();
            cbxCategoria.DataSource = negocio.listar();
            cbxMarca.DataSource = dato.listar();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            cargarbox();
        }
    }
}
