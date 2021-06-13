using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoreDapperventas.Model;

namespace CoreDapperventas.View
{
    public partial class Ventas : Form
    {

        VentasController ventasController = new VentasController();
        public Ventas()
        {
            InitializeComponent();
            UpdateControls();
            
            cb_categorias.DisplayMember = "Categoria";
            cb_categorias.ValueMember = "ID";

            cb_marcas.DisplayMember = "Marca";
            cb_marcas.ValueMember = "ID";
            

          
        }

       

        private void UpdateControls()
        {
            dgv_productos.DataSource = ventasController.GetProductos();

            cb_categorias.DataSource = ventasController.GetCategorias();

            cb_marcas.DataSource = ventasController.GetMarcas();
        }


       
        private string GetDgvID()
        {
            try
            {
                return dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {

                return dgv_productos.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
            ProductoView productoView = new ProductoView(GetDgvID());
            productoView.ShowDialog();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            ProductoView productoView = new ProductoView();
            productoView.ShowDialog();
            UpdateControls();
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {

        }

        private void btn_addCategoria_Click(object sender, EventArgs e)
        {
            //if (txtx_nuevacategoria.Text.Length > 0)
            //{
            //    ventasController.InsertCategoria(txtx_nuevacategoria.Text);
            //    txtx_nuevacategoria.Text = string.Empty;
            //    UpdateControls();

            //}
            //else
            //    MessageBox.Show("Ingrese una categoria", "Campo Vacio");
        }

        private void btn_addMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
