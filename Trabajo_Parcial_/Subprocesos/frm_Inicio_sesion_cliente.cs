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
    public partial class frm_Inicio_sesion_cliente : Form
    {
        public frm_Inicio_sesion_cliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_inicio_sesion_admi_Click(object sender, EventArgs e)
        {
            frm_Sesion_Usuario frm = new frm_Sesion_Usuario();
            frm.ShowDialog();
        }
    }
}
