using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaPractica.Clases
{
    public class ProductosEntidades
    {
        public Int64 Id_Producto { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public Int64 Precio { get; set; }
    }
}