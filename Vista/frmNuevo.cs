using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFI_Franco_TP1
{
    public partial class frmNuevo : Form
    {
        public frmNuevo()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;


            this.Dispose();
        }
    }
}
