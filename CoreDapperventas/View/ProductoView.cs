using CoreDapperventas.Controller;
using CoreDapperventas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreDapperventas.View
{
    public partial class ProductoView : Form
    {
        VentasController ventasController = new VentasController();
        ProductoController productoController = new ProductoController();
        public ProductoView(string ID = null)
        {
            InitializeComponent();

            if (ID != null)
                CargarProducto(ID);
            UpdateControls();
            cb_categorias.DisplayMember = "Categoria";
            cb_categorias.ValueMember = "ID";

            cb_marcas.DisplayMember = "Marca";
            cb_marcas.ValueMember = "ID";

        }

        private void CargarProducto(string id)
        {

            ProductoInsert p = productoController.GetProducto(id);

            
        }

        private void UpdateControls()
        {
            

            cb_categorias.DataSource = ventasController.GetCategorias();

            cb_marcas.DataSource = ventasController.GetMarcas();
        }

    

        private void btn_SaveProducto_Click(object sender, EventArgs e)
        {
            ProductoInsert p = new ProductoInsert
            {
                ID = txt_id.Text,
                Producto = txt_productName.Text,
                Precio = float.Parse(txt_precio.Text),
                IDMarca = cb_marcas.SelectedValue.GetHashCode(),
                IDCategoria = cb_categorias.SelectedValue.GetHashCode()
            };
            productoController.InsertProducto(p);
            this.Close();
        }
    }
}
