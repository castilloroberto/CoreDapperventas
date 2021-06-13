using CoreDapperventas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace CoreDapperventas.Controller
{
    public class ProductoController
    {

        public ProductoInsert GetProducto(string ID)
        {
            using (IDbConnection db = new SqlConnection(DBConnection.GetRobertString()))
            {
                return db.QuerySingle<ProductoInsert>("select * from Productos where ID = @ID ", new { ID });
            }
        }

        public void InsertProducto(ProductoInsert producto)
        {
            using (IDbConnection db = new SqlConnection(DBConnection.GetRobertString()))
            {
                db.Execute("Insert into Productos values(@ID,@Producto,@Precio,@IDMarca,@IDCategoria)", producto);
            }
        }
    }
}
