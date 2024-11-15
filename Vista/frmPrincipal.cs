using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TFI_Franco_TP1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        APIConexion apiFranConexion;
        public List<ApiProducts> Products;
        public List<string> Categories;
        public List<ApiProducts> FilteredProducts;



        public frmPrincipal()
        {

            InitializeComponent();
            var apiProducts = new ApiProducts();


            Products = new List<ApiProducts>();
            Categories = new List<string>();

            apiFranConexion = new APIConexion();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(apiFranConexion.GetProducts(Products));
            //Se asigna la api a utilizar para obtener los productos:
            FilteredProducts = new List<ApiProducts>(Products);
            //connectionApi.GetCategories(categories);

            //Se asigna la lista de productos con sus atributos:
            dgvGrilla.DataSource = FilteredProducts;

            MessageBox.Show(apiFranConexion.GetProducts(Products));
            FilteredProducts = new List<ApiProducts>(Products);
            apiFranConexion.GetCategories(Categories);

            dgvGrilla.DataSource = Products;
            
            
            //Yamil
            //APIConexion Con = new APIConexion();
            //dgvGrilla.DataSource = Con.GetProducts();
            //Con.GetCategories();


            //Se crea la variable categories para poder agregar All para poder filtrar las categorias.
            //Insertar en la posición 0 en una lista:
            Categories.Insert(0, "All");


            //DataSource: es una función de texto que devuelve el nombre de aplicación, de base de datos o de tabla de alias de una cuadrícula.

            cbxCategoria.DataSource = Categories;
            //cbxCategoria.DisplayMember = "Categories";
            //cbxCategoria.ValueMember = "Id";

            //Se asigna el elemento seleccionado para que sea All.
            //SelectedIndex: Obtiene o establece el índice que especifica el elemento seleccionado actualmente
            cbxCategoria.SelectedIndex = 0;

        }


        //Formulario adicional para agregar un nuevo producto:

        private void btn_Nuevo_producto_Click(object sender, EventArgs e)
        {
            //using: define un nuevo bloque de ámbito. Todas las variables declaradas dentro de una sentencia using son locales a ese bloque.
            //This: hacemos referencia al objeto que estamos usando. Un primer uso es dar valor a los atributos, incluso si los parámetros tienen el mismo nombre que éstos:

            using (frmNuevo formulario = new frmNuevo(this.Products, this.Categories))
            {
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    this.Products = formulario.newProducts;
                    this.Categories = formulario.newCategory;

                    cbxCategoria.DataSource = null;
                    cbxCategoria.DataSource = Categories;
                    dgvGrilla.Refresh();
                    cbxCategoria.SelectedIndex = 0;
                }
            }
            //Form formulario = new frmNuevo();

            //formulario.Show();
        }

        //Filtrar por categorías (ComboBox):

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxCategoria.SelectedItem != null)
            {

                string selectedCategory = cbxCategoria.SelectedItem.ToString();
                FilteredProducts = new List<ApiProducts>(Products);

                if (int.TryParse(tbxLimit.Text, out int limit) && limit > 0)
                {
                    if (selectedCategory == "All")
                    {
                        apiFranConexion.LimitResult(Products, limit);
                    }
                    else
                    {
                        apiFranConexion.GetInCategory(FilteredProducts, selectedCategory);
                        apiFranConexion.LimitResult(FilteredProducts, limit);
                    }
                }
                else
                {
                    if (selectedCategory == "All")
                    {
                        dgvGrilla.DataSource = Products;
                    }
                    else
                    {
                        apiFranConexion.GetInCategory(FilteredProducts, selectedCategory);
                    }
                }

                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = FilteredProducts;
            }
        }



         //Limitar la cantidad de productos a consultar:      

        private void tbxLimit_TextChanged(object sender, EventArgs e)
        {

            string selectedCategory = cbxCategoria.SelectedItem?.ToString();

            if (int.TryParse(tbxLimit.Text, out int limit) && limit > 0)
            {
                if (selectedCategory == "All")
                {
                    var limitedList = apiFranConexion.LimitResult(Products, limit);
                    dgvGrilla.DataSource = null;
                    dgvGrilla.DataSource = limitedList;
                }
                else
                {
                    var limitedList = apiFranConexion.LimitResult(FilteredProducts, limit);
                    dgvGrilla.DataSource = null;
                    dgvGrilla.DataSource = limitedList;
                }
            }
            else
            {
                if (selectedCategory == "All")
                {
                    dgvGrilla.DataSource = Products;
                }
                else
                {
                    dgvGrilla.DataSource = FilteredProducts;
                }

            }
        }

        //Ordenar de manera ascendente / descendente:

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            string selectedCategory = cbxCategoria?.SelectedItem?.ToString();

            if (selectedCategory != "All")
            {
                apiFranConexion.SortResults(Products, btn_Ordenar.Text);
                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = Products.Where(fra => fra.Category != null && fra.Category.Equals(selectedCategory)).ToList();
            }
            else
            {
                apiFranConexion.SortResults(Products, btn_Ordenar.Text);
                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = Products;
            }
            if (btn_Ordenar.Text == "Descendente")
            {
                btn_Ordenar.Text = "Ascendente";
            }
            else
            {
                btn_Ordenar.Text = "Descendente";
            }
        }

        
        //Buscar por Id:


        private void tbxBuscarId_TextChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbxCategoria.SelectedItem.ToString();

            if (int.TryParse(tbxBuscarId.Text, out int filterId))
            {
                if (selectedCategory == "All")
                {
                    var product = apiFranConexion.GetSingleProduct(FilteredProducts, filterId);
                    dgvGrilla.DataSource = new List<ApiProducts> { product };
                }
            }
            else
            {
                if (selectedCategory == "All")
                {
                    dgvGrilla.DataSource = null;
                    dgvGrilla.DataSource = Products;
                }
                else
                {
                    dgvGrilla.DataSource = null;
                    dgvGrilla.DataSource = FilteredProducts;

                }
            }
        }

        
        //Doble click en grilla para poder modificar:


        private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var filteredProducts = (List<ApiProducts>)dgvGrilla.DataSource;
            var selectedProduct = filteredProducts[e.RowIndex];

            using (frmActualizar form = new frmActualizar(selectedProduct, this.Products, this.Categories))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Categories = form.newCategory;

                    cbxCategoria.DataSource = null;
                    cbxCategoria.DataSource = Categories;
                    dgvGrilla.Refresh();
                    cbxCategoria.SelectedIndex = 0;
                }
            }
        }
    }
}

        