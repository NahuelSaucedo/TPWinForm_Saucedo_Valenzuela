﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
  public class Articulos
    {
        public int Id { get; set; }
        public string  Codigo { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int idCategoria { get; set; }
        public string ImagenUrl { get; set;}
        public decimal Precio { get; set; }

    }
}