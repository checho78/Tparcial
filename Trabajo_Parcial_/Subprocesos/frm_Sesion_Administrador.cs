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
    public partial class frm_Sesion_Administrador : Form
    {
        public frm_Sesion_Administrador()
        {
            InitializeComponent();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Actualizar_lista frm = new frm_Actualizar_lista();
            frm.ShowDialog();
        }

        private void inicioSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
