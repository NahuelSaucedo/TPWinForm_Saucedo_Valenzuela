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
                articulo.Marca = txtmarca.Text;
                articulo.Categoria = txtcategoria.Text;
                articulo.Precio = txtprecio.Text;

                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());            
            }
        }
    }
}
