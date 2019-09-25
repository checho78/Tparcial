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
    public partial class frm_Sesion_Usuario : Form
    {
        public frm_Sesion_Usuario()
        {
            InitializeComponent();
        }

        private void tusPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pedidos_clientes frm = new frm_Pedidos_clientes();
            frm.ShowDialog();
        }

        private void tuListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Lista_productos frm = new frm_Lista_productos();
            frm.ShowDialog();
        }
    }
}
