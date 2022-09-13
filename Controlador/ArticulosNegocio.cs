using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    class ArticulosNegocio
    {
        public List<Articulos> listar() {
        List<Articulos> Lista  = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.ImagenUrl, A.precio  from Articulos as A");
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Articulos aux = new Articulos();
                aux.Id = (int)datos.Lector["Id"];
                aux.Codigo = (string)datos.Lector["Codigo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                aux.IdMarca = (int)datos.Lector["IdMarca"];
                aux.idCategoria= (int)datos.Lector["IdCategoria"];
                aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                aux.Precio = (decimal)datos.Lector["Precio"];
                Lista.Add(aux);
            }
                
            return Lista;
    }



    }
}
