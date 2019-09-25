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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Inicio_sesion frm = new frm_Inicio_sesion();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Inicio_sesion_cliente frm = new frm_Inicio_sesion_cliente();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Agregar_cliente frm1 = new frm_Agregar_cliente();
            frm1.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inicioSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
