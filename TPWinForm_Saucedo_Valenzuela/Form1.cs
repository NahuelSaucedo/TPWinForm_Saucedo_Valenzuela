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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();

        }


        public void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            listaArticulo = negocio.listar();
            dgvDatos.DataSource = listaArticulo;

            pbxArticulo.Load(listaArticulo[0].ImagenUrl);





        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen) 
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://th.bing.com/th/id/OIP.B1009X_jAfBqCSnF7pd7mQHaE7?pid=ImgDet&rs=1");
            }
        }
    }
}