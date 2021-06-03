using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace LaPractica.Clases
{
    public class ProductosDAL
    {
        IDbConnection _conn = BDCommon.Conexion();

        //metodo de agregar productos 
        public int pa_InsertProductos(ProductosEntidades pEN)
        {
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("pa_InsertProductos", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@Nombre", pEN.Nombre));
            _Comand.Parameters.Add(new SqlParameter("@Descripcion", pEN.Descripcion));
            _Comand.Parameters.Add(new SqlParameter("@Imagen", pEN.Imagen));
            _Comand.Parameters.Add(new SqlParameter("@Precio", pEN.Precio));
            int Resultado = _Comand.ExecuteNonQuery();
            _conn.Close();
            return Resultado;
        }

        //metodo de consulta 

        public List<ProductosEntidades> ConsultarProductos()
        {
            _conn.Open();
            SqlCommand _comand = new SqlCommand("pa_ProductosSelect", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
            List<ProductosEntidades> _lista = new List<ProductosEntidades>();
            while (_reader.Read())
            {

                ProductosEntidades pEN = new ProductosEntidades();
                //pEN.Id_Producto = _reader.GetInt64(0);
                pEN.Nombre = _reader.GetString(1);
                pEN.Descripcion = _reader.GetString(2);
                pEN.Imagen = _reader.GetString(3);
                pEN.Precio = _reader.GetInt32(4);

                _lista.Add(pEN);
            }
            _conn.Close();
            return _lista;
        }
    }
}