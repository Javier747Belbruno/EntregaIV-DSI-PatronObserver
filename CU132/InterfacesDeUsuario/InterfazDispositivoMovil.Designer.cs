namespace CU132.InterfacesDeUsuario
{
    partial class InterfazDispositivoMovil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazDispositivoMovil));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroPlatos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProdListos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxBell = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platos Para Servir";
            // 
            // lblNumeroPlatos
            // 
            this.lblNumeroPlatos.AutoSize = true;
            this.lblNumeroPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.lblNumeroPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPlatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumeroPlatos.Location = new System.Drawing.Point(205, 264);
            this.lblNumeroPlatos.Name = "lblNumeroPlatos";
            this.lblNumeroPlatos.Size = new System.Drawing.Size(14, 15);
            this.lblNumeroPlatos.TabIndex = 2;
            this.lblNumeroPlatos.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroMesa,
            this.cantProdListos});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(21, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(350, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // numeroMesa
            // 
            this.numeroMesa.HeaderText = "Numero de Mesa";
            this.numeroMesa.MinimumWidth = 8;
            this.numeroMesa.Name = "numeroMesa";
            this.numeroMesa.ReadOnly = true;
            this.numeroMesa.Width = 150;
            // 
            // cantProdListos
            // 
            this.cantProdListos.HeaderText = "Cantidad de Productos";
            this.cantProdListos.MinimumWidth = 8;
            this.cantProdListos.Name = "cantProdListos";
            this.cantProdListos.ReadOnly = true;
            this.cantProdListos.Width = 150;
            // 
            // pictureBoxBell
            // 
            this.pictureBoxBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBell.Image = global::CU132.Properties.Resources.blackbell2;
            this.pictureBoxBell.Location = new System.Drawing.Point(10, 180);
            this.pictureBoxBell.Name = "pictureBoxBell";
            this.pictureBoxBell.Size = new System.Drawing.Size(361, 222);
            this.pictureBoxBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBell.TabIndex = 1;
            this.pictureBoxBell.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CU132.Properties.Resources.edit_profile_icon_22;
            this.pictureBox1.Location = new System.Drawing.Point(286, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CU132.Properties.Resources.Hamburger_icon_svg;
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CU132.Properties.Resources.Restaurant;
            this.pictureBox3.Location = new System.Drawing.Point(142, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // InterfazDispositivoMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 652);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNumeroPlatos);
            this.Controls.Add(this.pictureBoxBell);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfazDispositivoMovil";
            this.Text = "InterfazDispositivoMovil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBell;
        private System.Windows.Forms.Label lblNumeroPlatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProdListos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}