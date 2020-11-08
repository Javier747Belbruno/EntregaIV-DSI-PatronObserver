namespace CU132
{
    partial class PantallaFinalizarPreparacionPedido
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FinalizarPrepPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDeMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSeleccionarDetallesPedidos = new System.Windows.Forms.Button();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FinalizarPrepPedido
            // 
            this.btn_FinalizarPrepPedido.Location = new System.Drawing.Point(494, 187);
            this.btn_FinalizarPrepPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FinalizarPrepPedido.Name = "btn_FinalizarPrepPedido";
            this.btn_FinalizarPrepPedido.Size = new System.Drawing.Size(353, 150);
            this.btn_FinalizarPrepPedido.TabIndex = 0;
            this.btn_FinalizarPrepPedido.Text = "Finalizar Preparación de Pedido";
            this.btn_FinalizarPrepPedido.UseVisualStyleBackColor = true;
            this.btn_FinalizarPrepPedido.Click += new System.EventHandler(this.btn_FinalizarPrepPedido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.NroDeMesa,
            this.Producto,
            this.Cantidad,
            this.CheckBox,
            this.id_detalle});
            this.dataGridView1.Location = new System.Drawing.Point(146, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 501);
            this.dataGridView1.TabIndex = 1;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 150;
            // 
            // NroDeMesa
            // 
            this.NroDeMesa.HeaderText = "Mesa";
            this.NroDeMesa.MinimumWidth = 8;
            this.NroDeMesa.Name = "NroDeMesa";
            this.NroDeMesa.ReadOnly = true;
            this.NroDeMesa.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Nombre Producto/Menu";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "CheckBox";
            this.CheckBox.MinimumWidth = 8;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 150;
            // 
            // btnSeleccionarDetallesPedidos
            // 
            this.btnSeleccionarDetallesPedidos.Location = new System.Drawing.Point(529, 531);
            this.btnSeleccionarDetallesPedidos.Name = "btnSeleccionarDetallesPedidos";
            this.btnSeleccionarDetallesPedidos.Size = new System.Drawing.Size(273, 68);
            this.btnSeleccionarDetallesPedidos.TabIndex = 2;
            this.btnSeleccionarDetallesPedidos.Text = "Seleccionar Detalles de Pedidos";
            this.btnSeleccionarDetallesPedidos.UseVisualStyleBackColor = true;
            this.btnSeleccionarDetallesPedidos.Click += new System.EventHandler(this.btnSeleccionarDetallesPedidos_Click);
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "id";
            this.id_detalle.MinimumWidth = 8;
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.Visible = false;
            this.id_detalle.Width = 150;
            // 
            // PantallaFinalizarPreparacionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 626);
            this.Controls.Add(this.btnSeleccionarDetallesPedidos);
            this.Controls.Add(this.btn_FinalizarPrepPedido);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaFinalizarPreparacionPedido";
            this.Text = "Pantalla Finalizar Preparación Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FinalizarPrepPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.Button btnSeleccionarDetallesPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
    }
}

