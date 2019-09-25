namespace Trabajo_Parcial_
{
    partial class frm_Actualizar_lista
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_precio_unit = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_nombre_objeto = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.listv_product_add = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_Unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_salir.Location = new System.Drawing.Point(446, 193);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(95, 27);
            this.btn_salir.TabIndex = 30;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(160, 131);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 26);
            this.txt_precio.TabIndex = 29;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(31, 81);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(78, 19);
            this.lbl_cantidad.TabIndex = 28;
            this.lbl_cantidad.Text = "Cantidad: ";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(160, 78);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 26);
            this.txt_cantidad.TabIndex = 27;
            // 
            // lbl_precio_unit
            // 
            this.lbl_precio_unit.AutoSize = true;
            this.lbl_precio_unit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_unit.Location = new System.Drawing.Point(31, 134);
            this.lbl_precio_unit.Name = "lbl_precio_unit";
            this.lbl_precio_unit.Size = new System.Drawing.Size(111, 19);
            this.lbl_precio_unit.TabIndex = 26;
            this.lbl_precio_unit.Text = "Precio unitario:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_limpiar.Location = new System.Drawing.Point(279, 193);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(103, 27);
            this.btn_limpiar.TabIndex = 25;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(150, 193);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(110, 27);
            this.btn_agregar.TabIndex = 24;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_nombre_objeto
            // 
            this.txt_nombre_objeto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_objeto.Location = new System.Drawing.Point(160, 26);
            this.txt_nombre_objeto.Name = "txt_nombre_objeto";
            this.txt_nombre_objeto.Size = new System.Drawing.Size(100, 26);
            this.txt_nombre_objeto.TabIndex = 23;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(31, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(72, 19);
            this.lbl_nombre.TabIndex = 22;
            this.lbl_nombre.Text = "Nombre: ";
            // 
            // listv_product_add
            // 
            this.listv_product_add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Cantidad,
            this.Precio_Unitario,
            this.Precio_Total});
            this.listv_product_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listv_product_add.Location = new System.Drawing.Point(14, 237);
            this.listv_product_add.Name = "listv_product_add";
            this.listv_product_add.Size = new System.Drawing.Size(564, 185);
            this.listv_product_add.TabIndex = 21;
            this.listv_product_add.UseCompatibleStateImageBehavior = false;
            this.listv_product_add.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 172;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 106;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.Text = "Precio Unitario";
            this.Precio_Unitario.Width = 130;
            // 
            // Precio_Total
            // 
            this.Precio_Total.Text = "Precio Total";
            this.Precio_Total.Width = 108;
            // 
            // frm_Actualizar_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(602, 449);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_precio_unit);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_nombre_objeto);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.listv_product_add);
            this.Name = "frm_Actualizar_lista";
            this.Text = "frm_Actualizar_lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_precio_unit;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_nombre_objeto;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ListView listv_product_add;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio_Unitario;
        private System.Windows.Forms.ColumnHeader Precio_Total;
    }
}