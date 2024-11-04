using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFI_Franco_TP1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        APIConexion connectionApi;
        public List<ApiProducts> Products;
        public List<string> Categories;
        public List<ApiProducts> FilteredProducts;



        public frmPrincipal()
        {

            InitializeComponent();
            var apiProducts = new ApiProducts();


            Products = new List<ApiProducts>();
            Categories = new List<string>();
            connectionApi = new APIConexion();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Se asigna la api a utilizar para obtener los productos:
            FilteredProducts = new List<ApiProducts>(Products);
            //connectionApi.GetCategories(categories);

            //Se asigna la lista de productos con sus atributos:
            dgvGrilla.DataSource = FilteredProducts;


            //Yamil
            APIConexion Con = new APIConexion();
            dgvGrilla.DataSource = Con.GetProducts();
            Con.GetCategories();


            //Se crea la variable categories para poder agregar All para poder filtrar las categorias:
            //var categories = Products.Select(p => p.Category).Distinct().ToList();
            Categories.Insert(0, "All");


            cbxCategoria.DataSource = Categories;
            cbxCategoria.DisplayMember = "Categories";
            //cbxCategoria.ValueMember = "Id";

            //Se asigna el elemento seleccionado para que sea All:
            cbxCategoria.SelectedIndex = 0;

        }




        private void btn_Nuevo_producto_Click(object sender, EventArgs e)
        {
            Form formulario = new frmNuevo();

            formulario.Show();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoty = cbxCategoria.SelectedItem.ToString();
            FilteredProducts = new List<ApiProducts>(Products);
        }
    }
}

        