using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Parcial_.Controlador;
using Trabajo_Parcial_.Model;
namespace Trabajo_Parcial_
{
    public partial class frm_Inicio_sesion : Form
    {
        CControl_Operacion objControlOperacion = new CControl_Operacion();
        CAdministrador objAdministrador = new CAdministrador();

        public frm_Inicio_sesion()
        {
            InitializeComponent();
        }

        private void btn_inicio_sesion_admi_Click(object sender, EventArgs e)
        {

            string nombre_ = txt_nombre.Text;
            string email = txt_email.Text;
            string contraseña_ = txt_contraseña.Text;
            objAdministrador.nombre_admi = nombre_;
            objAdministrador.correo = email;
            objAdministrador.contraseña = contraseña_;
            if (objControlOperacion.validar_administrador(objAdministrador))
            {
                frm_Sesion_Administrador frm = new frm_Sesion_Administrador();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Los datos ingresados no son correctos. Ingréselos nuevamente. ");
            }
        }
    }
}
