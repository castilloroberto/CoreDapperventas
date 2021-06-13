using System;
using System.Collections.Generic;
using System.Text;
// necesario
using CoreDapperventas.Model;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CoreDapperventas
{
    public class VentasController
    {

        //IEnumerable<Productos>
        public IEnumerable<Productos> GetProductos()
        {
            using (IDbConnection db = new SqlConnection(DBConnection.GetRobertString()))
            {
                return db.Query<Productos>("dbo.sp_getProductos");
            }
        }


        public IEnumerable<Categoirias> GetCategorias()
        {
            using (IDbConnection db = new SqlConnection(DBConnection.GetRobertString()))
            {
                return db.Query<Categoirias>("Select * from categorias");
            }
        }

        public void InsertCategoria(string categoria)
        {
            using (IDbConnection db = new SqlConnection(DBConnection.GetRobertString()))
            {
                db.Execute("Insert into Categorias values(@categoria)",new { categoria});
            }
        }

        

        public IEnumerable<Marcas> GetMarcas()
        {
            using (IDbConnection db = new SqlConnection(DBConnection.GetRobertString()))
            {
                return db.Query<Marcas>("Select * from Marcas");
            }
        }






    }
}
