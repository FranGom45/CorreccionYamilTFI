using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFI_Franco_TP1
{
    public partial class frmNuevo : Form
    {
        //Utilizar error provider

        private ErrorProvider _errorProvider = new ErrorProvider();
        public List<ApiProducts> newProducts { get; private set; }
        public List<string> newCategory { get; private set; }

        public frmNuevo(List<ApiProducts> existingProducts, List<string> existingCategories)
        {
            InitializeComponent();
            this.newProducts = existingProducts;
            this.newCategory = existingCategories;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void frmNuevo_Load(object sender, EventArgs e)
        {
            tbxId.Text = GetNextProductId().ToString();

        }



        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            APIConexion apiapiFranConexion = new APIConexion();

            string title = tbxTitulo.Text;
            string priceText = tbxPrecio.Text;
            decimal price = Convert.ToDecimal(priceText);

            if (!ValidateFields())
            {
                MessageBox.Show("Corregir errores.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(tbxId.Text);

            if (!string.IsNullOrEmpty(tbxCategoria.Text))
            {
                if (!newCategory.Contains(tbxCategoria.Text))
                {
                    newCategory.Add(tbxCategoria.Text);
                }
            }


            ApiProducts products = new ApiProducts
            {
                Id = id,
                Title = title,
                Price = price,
                Description = tbxDescripcion.Text,
                Category = tbxCategoria.Text,

            };

            MessageBox.Show(apiapiFranConexion.PostProducts(newProducts, products));
            this.DialogResult = DialogResult.OK;
            this.Dispose();

        }

        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbxTitulo.Text))
            {
                _errorProvider.SetError(tbxTitulo, "Complete el campo");
                isValid = false;
            }
            else
            {
                _errorProvider.SetError(tbxPrecio, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(tbxPrecio.Text) || !decimal.TryParse(tbxPrecio.Text, out decimal price) || price <= 0)
            {
                _errorProvider.SetError(tbxPrecio, "Ingrese un número válido mayor que cero");
                isValid = false;
            }
            else
            {
                _errorProvider.SetError(tbxPrecio, string.Empty);

            }
            return isValid;
        }





        private int GetNextProductId()
        {
            if (newProducts != null && newProducts.Count > 0)
            {
                
                    return newProducts.Max(x => x.Id) + 1;
                }
                return 1;

            }

        }
    }


