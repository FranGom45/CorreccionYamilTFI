namespace Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Trabajo_Final_Integrador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLimit = new System.Windows.Forms.TextBox();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.lbl_Ordenar = new System.Windows.Forms.Label();
            this.lbl_Buscar_Id = new System.Windows.Forms.Label();
            this.tbxBuscarId = new System.Windows.Forms.TextBox();
            this.btn_Nuevo_producto = new System.Windows.Forms.Button();
            this.lbl_Crear_Producto = new System.Windows.Forms.Label();
            this.lbl_Filtrar_Categoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(0, 236);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(800, 214);
            this.dgvGrilla.TabIndex = 11;
            this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Trabajo_Final_Integrador);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 236);
            this.panel1.TabIndex = 12;
            // 
            // lbl_Trabajo_Final_Integrador
            // 
            this.lbl_Trabajo_Final_Integrador.AutoSize = true;
            this.lbl_Trabajo_Final_Integrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trabajo_Final_Integrador.Location = new System.Drawing.Point(13, 24);
            this.lbl_Trabajo_Final_Integrador.Name = "lbl_Trabajo_Final_Integrador";
            this.lbl_Trabajo_Final_Integrador.Size = new System.Drawing.Size(234, 24);
            this.lbl_Trabajo_Final_Integrador.TabIndex = 11;
            this.lbl_Trabajo_Final_Integrador.Text = "Trabajo Final Integrador";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxLimit);
            this.panel2.Controls.Add(this.btn_Ordenar);
            this.panel2.Controls.Add(this.lbl_Ordenar);
            this.panel2.Controls.Add(this.lbl_Buscar_Id);
            this.panel2.Controls.Add(this.tbxBuscarId);
            this.panel2.Controls.Add(this.btn_Nuevo_producto);
            this.panel2.Controls.Add(this.lbl_Crear_Producto);
            this.panel2.Controls.Add(this.lbl_Filtrar_Categoria);
            this.panel2.Controls.Add(this.cbxCategoria);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 82);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Limitar cantidad de productos";
            // 
            // tbxLimit
            // 
            this.tbxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLimit.Location = new System.Drawing.Point(610, 30);
            this.tbxLimit.Name = "tbxLimit";
            this.tbxLimit.Size = new System.Drawing.Size(55, 20);
            this.tbxLimit.TabIndex = 13;
            this.tbxLimit.TextChanged += new System.EventHandler(this.tbxLimit_TextChanged);
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ordenar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ordenar.Image")));
            this.btn_Ordenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ordenar.Location = new System.Drawing.Point(12, 30);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(125, 37);
            this.btn_Ordenar.TabIndex = 11;
            this.btn_Ordenar.Text = "A/D";
            this.btn_Ordenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // lbl_Ordenar
            // 
            this.lbl_Ordenar.AutoSize = true;
            this.lbl_Ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ordenar.Location = new System.Drawing.Point(14, 14);
            this.lbl_Ordenar.Name = "lbl_Ordenar";
            this.lbl_Ordenar.Size = new System.Drawing.Size(52, 13);
            this.lbl_Ordenar.TabIndex = 6;
            this.lbl_Ordenar.Text = "Ordenar";
            // 
            // lbl_Buscar_Id
            // 
            this.lbl_Buscar_Id.AutoSize = true;
            this.lbl_Buscar_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar_Id.Location = new System.Drawing.Point(496, 12);
            this.lbl_Buscar_Id.Name = "lbl_Buscar_Id";
            this.lbl_Buscar_Id.Size = new System.Drawing.Size(61, 13);
            this.lbl_Buscar_Id.TabIndex = 9;
            this.lbl_Buscar_Id.Text = "Buscar Id";
            // 
            // tbxBuscarId
            // 
            this.tbxBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarId.Location = new System.Drawing.Point(499, 30);
            this.tbxBuscarId.Name = "tbxBuscarId";
            this.tbxBuscarId.Size = new System.Drawing.Size(58, 20);
            this.tbxBuscarId.TabIndex = 4;
            this.tbxBuscarId.TextChanged += new System.EventHandler(this.tbxBuscarId_TextChanged);
            // 
            // btn_Nuevo_producto
            // 
            this.btn_Nuevo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo_producto.Image")));
            this.btn_Nuevo_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo_producto.Location = new System.Drawing.Point(191, 30);
            this.btn_Nuevo_producto.Name = "btn_Nuevo_producto";
            this.btn_Nuevo_producto.Size = new System.Drawing.Size(77, 37);
            this.btn_Nuevo_producto.TabIndex = 2;
            this.btn_Nuevo_producto.Text = "Nuevo";
            this.btn_Nuevo_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Nuevo_producto.UseVisualStyleBackColor = true;
            this.btn_Nuevo_producto.Click += new System.EventHandler(this.btn_Nuevo_producto_Click);
            // 
            // lbl_Crear_Producto
            // 
            this.lbl_Crear_Producto.AutoSize = true;
            this.lbl_Crear_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Crear_Producto.Location = new System.Drawing.Point(188, 12);
            this.lbl_Crear_Producto.Name = "lbl_Crear_Producto";
            this.lbl_Crear_Producto.Size = new System.Drawing.Size(91, 13);
            this.lbl_Crear_Producto.TabIndex = 7;
            this.lbl_Crear_Producto.Text = "Crear producto";
            // 
            // lbl_Filtrar_Categoria
            // 
            this.lbl_Filtrar_Categoria.AutoSize = true;
            this.lbl_Filtrar_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtrar_Categoria.Location = new System.Drawing.Point(314, 12);
            this.lbl_Filtrar_Categoria.Name = "lbl_Filtrar_Categoria";
            this.lbl_Filtrar_Categoria.Size = new System.Drawing.Size(98, 13);
            this.lbl_Filtrar_Categoria.TabIndex = 8;
            this.lbl_Filtrar_Categoria.Text = "Filtrar categoría";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(317, 30);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(124, 21);
            this.cbxCategoria.TabIndex = 3;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "TFI Gómez Franco";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Trabajo_Final_Integrador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Ordenar;
        private System.Windows.Forms.Label lbl_Buscar_Id;
        private System.Windows.Forms.TextBox tbxBuscarId;
        private System.Windows.Forms.Button btn_Nuevo_producto;
        private System.Windows.Forms.Label lbl_Crear_Producto;
        private System.Windows.Forms.Label lbl_Filtrar_Categoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.TextBox tbxLimit;
        private System.Windows.Forms.Label label1;
    }
}

