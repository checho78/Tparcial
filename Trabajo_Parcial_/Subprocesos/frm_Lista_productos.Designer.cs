namespace Trabajo_Parcial_
{
    partial class frm_Lista_productos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.cbox_producto = new System.Windows.Forms.ComboBox();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.listv_product_add = new System.Windows.Forms.ListView();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_Unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relizarPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relizarPedidoToolStripMenuItem
            // 
            this.relizarPedidoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.relizarPedidoToolStripMenuItem.Name = "relizarPedidoToolStripMenuItem";
            this.relizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.relizarPedidoToolStripMenuItem.Text = "Realizar pedido";
            this.relizarPedidoToolStripMenuItem.Click += new System.EventHandler(this.relizarPedidoToolStripMenuItem_Click);
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(357, 34);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(96, 17);
            this.lbl_monto.TabIndex = 18;
            this.lbl_monto.Text = "Monto a Pagar";
            this.lbl_monto.Visible = false;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(240, 34);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(60, 17);
            this.lbl_cantidad.TabIndex = 17;
            this.lbl_cantidad.Text = "Cantidad";
            this.lbl_cantidad.Visible = false;
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(344, 59);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 25);
            this.txt_monto.TabIndex = 16;
            this.txt_monto.Visible = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(242, 57);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(47, 25);
            this.txt_cantidad.TabIndex = 15;
            this.txt_cantidad.Visible = false;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(97, 34);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(61, 17);
            this.lbl_producto.TabIndex = 14;
            this.lbl_producto.Text = "Producto";
            this.lbl_producto.Visible = false;
            // 
            // cbox_producto
            // 
            this.cbox_producto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_producto.FormattingEnabled = true;
            this.cbox_producto.Location = new System.Drawing.Point(25, 57);
            this.cbox_producto.Name = "cbox_producto";
            this.cbox_producto.Size = new System.Drawing.Size(203, 25);
            this.cbox_producto.TabIndex = 13;
            this.cbox_producto.Visible = false;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.Location = new System.Drawing.Point(492, 59);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_comprar.TabIndex = 12;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Visible = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // listv_product_add
            // 
            this.listv_product_add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.Nombre,
            this.Cantidad,
            this.Precio_Unitario});
            this.listv_product_add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listv_product_add.Location = new System.Drawing.Point(25, 100);
            this.listv_product_add.Name = "listv_product_add";
            this.listv_product_add.Size = new System.Drawing.Size(495, 315);
            this.listv_product_add.TabIndex = 11;
            this.listv_product_add.UseCompatibleStateImageBehavior = false;
            this.listv_product_add.View = System.Windows.Forms.View.Details;
            // 
            // N
            // 
            this.N.Text = "N";
            this.N.Width = 25;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 172;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 95;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.Text = "Precio Unitario";
            this.Precio_Unitario.Width = 95;
            // 
            // frm_Lista_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(586, 434);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.cbox_producto);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.listv_product_add);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Lista_productos";
            this.Text = "frm_Lista_productos";
            this.Load += new System.EventHandler(this.frm_Lista_productos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relizarPedidoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.ComboBox cbox_producto;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.ListView listv_product_add;
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio_Unitario;
    }
}