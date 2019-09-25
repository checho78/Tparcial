namespace Trabajo_Parcial_
{
    partial class frm_Sesion_Usuario
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
            this.tuCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tusPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuCuentaToolStripMenuItem,
            this.tusPedidosToolStripMenuItem,
            this.tuListaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tuCuentaToolStripMenuItem
            // 
            this.tuCuentaToolStripMenuItem.Name = "tuCuentaToolStripMenuItem";
            this.tuCuentaToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.tuCuentaToolStripMenuItem.Text = "Tu cuenta";
            // 
            // tusPedidosToolStripMenuItem
            // 
            this.tusPedidosToolStripMenuItem.Name = "tusPedidosToolStripMenuItem";
            this.tusPedidosToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.tusPedidosToolStripMenuItem.Text = "Tus pedidos";
            this.tusPedidosToolStripMenuItem.Click += new System.EventHandler(this.tusPedidosToolStripMenuItem_Click);
            // 
            // tuListaToolStripMenuItem
            // 
            this.tuListaToolStripMenuItem.Name = "tuListaToolStripMenuItem";
            this.tuListaToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.tuListaToolStripMenuItem.Text = "Lista Productos";
            this.tuListaToolStripMenuItem.Click += new System.EventHandler(this.tuListaToolStripMenuItem_Click);
            // 
            // frm_Sesion_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 458);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Sesion_Usuario";
            this.Text = "frm_Sesion_Usuario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tuCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tusPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuListaToolStripMenuItem;
    }
}