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

namespace Vista
{
    public partial class frmActualizar : Form
    {

        private readonly ErrorProvider _errorProvider = new ErrorProvider();
        private readonly APIConexion _apiFranConexion;
        private ApiProducts _product;
        public List<ApiProducts> EditedProducts { get; private set; }
        public List<string> newCategory { get; private set; }



        public frmActualizar(ApiProducts product, List<ApiProducts> oldList, List<string> existingCategories)
        {
            InitializeComponent();
            _product = product;
            EditedProducts = oldList;
            newCategory = existingCategories;
            _apiFranConexion = new APIConexion();

            InitializeProductFields(product);
        }

        private void InitializeProductFields(ApiProducts product)
        {
            {
                tbxIdActualizar.Text = product.Id.ToString();
                tbxCategoriaActualizar.Text = product.Category;
                tbxDescripcionActualizar.Text = product.Description;
                tbxTituloActualizar.Text = product.Title;
                tbxPrecioActualizar.Text = product.Price.ToString();

            }



        }

        private void btn_AceptarActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Corregir errores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(tbxCategoriaActualizar.Text))
            {
                if (!newCategory.Contains(tbxCategoriaActualizar.Text))
                {
                    newCategory.Add(tbxCategoriaActualizar.Text);
                }
            }

            var updateProduct = GetUpdatedProductFromFields();
            MessageBox.Show(_apiFranConexion.PutProducts(EditedProducts, updateProduct));
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }


        private ApiProducts GetUpdatedProductFromFields()
        {
            return new ApiProducts
            {
                Id = int.Parse(tbxIdActualizar.Text),
                Title = tbxTituloActualizar.Text,
                Price = decimal.Parse(tbxPrecioActualizar.Text),
                Description = tbxDescripcionActualizar.Text,
                Category = tbxCategoriaActualizar.Text
            };
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbxTituloActualizar.Text))
            {
                _errorProvider.SetError(tbxTituloActualizar, "El título es obligatorio");
                isValid = false;
            }
            else
            {
                _errorProvider.SetError(tbxTituloActualizar, string.Empty);
            }

            if (!ValidatePrice())
            {
                isValid = false;
            }
            return isValid;

        }

        private bool ValidatePrice()
        {
            if (string.IsNullOrWhiteSpace(tbxPrecioActualizar.Text) || !decimal.TryParse(tbxPrecioActualizar.Text, out decimal price) || price <= 0)
            {
                _errorProvider.SetError(tbxPrecioActualizar, "El precio debe ser un valor válido y mayor que cero");
                return false;
            }
            else
            {
                _errorProvider.SetError(tbxPrecioActualizar, string.Empty);
                return true;

            }
        }

        private void btn_CancelarActualizar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
