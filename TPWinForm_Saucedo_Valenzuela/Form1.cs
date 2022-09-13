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
        private List<Articulos> listaArticulos;

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
            ArticulosNegocio negocio = new ArticulosNegocio();
      
                listaArticulos = negocio.listar();
                dgvDatos.DataSource = listaArticulos;
                
         
  
            

        }
    }
}
