using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Parcial_
{
    public partial class frm_Lista_productos : Form
    {
        public frm_Lista_productos()
        {
            InitializeComponent();
        }

        private void frm_Lista_productos_Load(object sender, EventArgs e)
        {

        }

        private void relizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_cantidad.Visible = true;
            txt_monto.Visible = true;
            lbl_cantidad.Visible = true;
            lbl_monto.Visible = true;
            lbl_producto.Visible = true;
            btn_comprar.Visible = true;
            cbox_producto.Visible = true;
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            Close();
            frm_Sesion_Usuario frm = new frm_Sesion_Usuario();
            frm.ShowDialog();
        }
    }
}
