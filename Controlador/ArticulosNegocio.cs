using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
   public class ArticuloNegocio
    {
        public List<Articulo> listar() {
            List<Articulo> Lista  = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConsulta("Select Codigo, Nombre, A.Descripcion, ImagenUrl, precio, M.Descripcion Tipo, C.Descripcion Cat from Articulos A, MARCAS M, CATEGORIAS C where a.Idmarca = m.Id and a.IdCategoria = c.Id");
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Articulo aux = new Articulo();
                //aux.Id = (int)datos.Lector["Id"];
                aux.Codigo = (string)datos.Lector["Codigo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                //aux.IdMarca = (int)datos.Lector["IdMarca"];
                //aux.idCategoria= (int)datos.Lector["IdCategoria"];
                aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                aux.Precio = (decimal)datos.Lector["Precio"];
                aux.Marca = new Marca();
                aux.Marca.descripcion = (string)datos.Lector["Tipo"];
                aux.Categoria = new Categoria();
                aux.Categoria.descripcion = (string)datos.Lector["Cat"];

                Lista.Add(aux);
            }
                
            return Lista;
    }



    }
}
