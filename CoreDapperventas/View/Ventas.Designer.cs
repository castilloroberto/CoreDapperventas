
namespace CoreDapperventas.View
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_addMarca = new System.Windows.Forms.Button();
            this.btn_addCategoria = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_marcas = new System.Windows.Forms.ComboBox();
            this.cb_categorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(91, 242);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(1010, 335);
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(839, 597);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 29);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.Location = new System.Drawing.Point(949, 597);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(152, 29);
            this.btn_addProduct.TabIndex = 6;
            this.btn_addProduct.Text = "Agregar Producto";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackColor = System.Drawing.Color.Crimson;
            this.btn_desactivar.FlatAppearance.BorderSize = 0;
            this.btn_desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_desactivar.ForeColor = System.Drawing.Color.White;
            this.btn_desactivar.Location = new System.Drawing.Point(724, 597);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(94, 29);
            this.btn_desactivar.TabIndex = 6;
            this.btn_desactivar.Text = "Desactivar";
            this.btn_desactivar.UseVisualStyleBackColor = false;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_addMarca
            // 
            this.btn_addMarca.BackColor = System.Drawing.Color.White;
            this.btn_addMarca.FlatAppearance.BorderSize = 0;
            this.btn_addMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMarca.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addMarca.ForeColor = System.Drawing.Color.Black;
            this.btn_addMarca.Location = new System.Drawing.Point(267, 179);
            this.btn_addMarca.Name = "btn_addMarca";
            this.btn_addMarca.Size = new System.Drawing.Size(77, 29);
            this.btn_addMarca.TabIndex = 41;
            this.btn_addMarca.Text = "Nueva";
            this.btn_addMarca.UseVisualStyleBackColor = false;
            this.btn_addMarca.Click += new System.EventHandler(this.btn_addMarca_Click);
            // 
            // btn_addCategoria
            // 
            this.btn_addCategoria.BackColor = System.Drawing.Color.White;
            this.btn_addCategoria.FlatAppearance.BorderSize = 0;
            this.btn_addCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCategoria.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addCategoria.ForeColor = System.Drawing.Color.Black;
            this.btn_addCategoria.Location = new System.Drawing.Point(1024, 178);
            this.btn_addCategoria.Name = "btn_addCategoria";
            this.btn_addCategoria.Size = new System.Drawing.Size(77, 29);
            this.btn_addCategoria.TabIndex = 42;
            this.btn_addCategoria.Text = "Nueva";
            this.btn_addCategoria.UseVisualStyleBackColor = false;
            this.btn_addCategoria.Click += new System.EventHandler(this.btn_addCategoria_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(91, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(848, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Categoria";
            // 
            // cb_marcas
            // 
            this.cb_marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_marcas.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_marcas.FormattingEnabled = true;
            this.cb_marcas.Location = new System.Drawing.Point(91, 179);
            this.cb_marcas.Name = "cb_marcas";
            this.cb_marcas.Size = new System.Drawing.Size(151, 28);
            this.cb_marcas.TabIndex = 43;
            // 
            // cb_categorias
            // 
            this.cb_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_categorias.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_categorias.FormattingEnabled = true;
            this.cb_categorias.Location = new System.Drawing.Point(848, 178);
            this.cb_categorias.Name = "cb_categorias";
            this.cb_categorias.Size = new System.Drawing.Size(151, 28);
            this.cb_categorias.TabIndex = 44;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 797);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_marcas);
            this.Controls.Add(this.cb_categorias);
            this.Controls.Add(this.btn_addMarca);
            this.Controls.Add(this.btn_addCategoria);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_productos);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_addMarca;
        private System.Windows.Forms.Button btn_addCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_marcas;
        private System.Windows.Forms.ComboBox cb_categorias;
    }
}