using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                if (!(datos.Lector["Codigo"] is DBNull))
                    aux.Codigo = (string)datos.Lector["Codigo"];
                if (!(datos.Lector["Nombre"] is DBNull))
                    aux.Nombre = (string)datos.Lector["Nombre"];
                if (!(datos.Lector["Descripcion"] is DBNull))
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                //aux.IdMarca = (int)datos.Lector["IdMarca"];
                //aux.idCategoria= (int)datos.Lector["IdCategoria"];
                if (!(datos.Lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                if (!(datos.Lector["Precio"] is DBNull))
                    aux.Precio = (decimal)datos.Lector["Precio"];
                if (!(datos.Lector["Tipo"] is DBNull))
                    aux.Marca = new Marca();
                    aux.Marca.descripcion = (string)datos.Lector["Tipo"];
                if (!(datos.Lector["Cat"] is DBNull))
                    aux.Categoria = new Categoria();
                    aux.Categoria.descripcion = (string)datos.Lector["Cat"];

                Lista.Add(aux);
            }
                
            return Lista;
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("insert into Articulos(codigo, nombre, descripcion)values ('','','','')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
