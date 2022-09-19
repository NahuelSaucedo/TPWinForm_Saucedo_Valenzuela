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
        Articulo articulo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
         
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

    

                articulo.Nombre = txtnombre.Text;
                articulo.Descripcion = txtdescripcion.Text;
                articulo.Codigo = txtcodigo.Text;
                articulo.ImagenUrl = txturl.Text;
                articulo.marca = (Marca)cbxMarca.SelectedItem;
                articulo.categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtprecio.Text);
                articulo.categoria.id = Convert.ToInt32(cbxCategoria.SelectedValue);
                articulo.marca.id = Convert.ToInt32(cbxMarca.SelectedValue);
                articulo.Activo = 1;

         
                    if (articulo.Id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Articulo modificado");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Articulo agregado");
                    }
                
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
            try
            {
                cbxCategoria.DataSource = negocio.listar();
                cbxMarca.DataSource = dato.listar();
                cbxMarca.ValueMember = "id";
                cbxMarca.DisplayMember = "descripcion";
                cbxCategoria.ValueMember = "id";
                cbxCategoria.DisplayMember = "descripcion";

                if(articulo != null)
                {
                    txtcodigo.Text = articulo.Codigo;
                    txtnombre.Text = articulo.Nombre;
                    txtdescripcion.Text = articulo.Descripcion;
                    txturl.Text = articulo.ImagenUrl;
                    cbxMarca.SelectedItem = articulo.marca.id;
                    cbxCategoria.SelectedItem = articulo.categoria.id;
                    txtprecio.Text = Convert.ToString(articulo.Precio);
                    cargarImagen(articulo.ImagenUrl);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message);
            }
        }

        private bool checkNullity()
        {
            if(string.IsNullOrEmpty(txtcodigo.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(cbxCategoria.Text) || string.IsNullOrEmpty(cbxMarca.Text))
            {
                MessageBox.Show("Por favor, complete los campos requeridos", "Completar campos");
                return false;
            }
            return true;
        }



        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            cargarbox();
        }


    }
}
