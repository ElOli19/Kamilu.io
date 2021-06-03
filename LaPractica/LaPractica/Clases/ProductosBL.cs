using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaPractica.Clases
{
    public class ProductosBL
    {
        ProductosDAL dal = new ProductosDAL();

        public int pa_InsertProductos(ProductosEntidades pEN)
        {
            return dal.pa_InsertProductos(pEN);
        }

        public List<ProductosEntidades> ConsultarProductos()
        {
            return dal.ConsultarProductos();
        }
    }
}