using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDapperventas.Model
{
    public class ProductoInsert
    {

        public string ID { get; set; }

        public string Producto { get; set; }

        public float Precio { get; set; }

        public int IDMarca { get; set; }

        public int IDCategoria { get; set; }

    }
}
