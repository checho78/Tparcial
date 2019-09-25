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
    public partial class frm_Agregar_cliente : Form
    {
        //------------------------------------------------------------------------------------

        CControl_Operacion objControlOperacion;
        public frm_Agregar_cliente()
        {
            InitializeComponent();
            objControlOperacion = new CControl_Operacion();

        }

         private void frm_Agregar_cliente_Load(object sender, EventArgs e)
        {
            foreach (CCliente user in CControl_Operacion.cliente_n)
            {
                Add_cliente_en_lista(user);
            }
        }

        private void Add_cliente_en_lista(CCliente cli)
        {
            ListViewItem item = new ListViewItem(cli.nombre_cliente.ToString());
            item.SubItems.Add(Convert.ToString(cli.tarjeta_credito));
            item.SubItems.Add(cli.contraseña_user);
            item.SubItems.Add(cli.email_user);
            
            listv_product_add.Items.Add(item);
        }

        private void btn_inicio_sesion_Click_1(object sender, EventArgs e)
        {

            if (!(txt_nombre.Text == "" || txt_trajeta_credito.Text == "" || txt_email.Text == ""))
            {


                string nombre_ = txt_nombre.Text;
                string email_ = txt_email.Text;
                string contraseña_ = txt_trajeta_credito.Text;
                Int32 tarjeta_cre = Convert.ToInt32(txt_trajeta_credito.Text);

                CCliente cliente = new CCliente();
                cliente.nombre_cliente = nombre_;
                cliente.email_user = email_;
                cliente.contraseña_user = contraseña_;


                CControl_Operacion.cliente_n.Add(new CCliente()
                {
                    nombre_cliente = nombre_,
                    email_user = email_,
                    tarjeta_credito = tarjeta_cre,
                    contraseña_user = contraseña_
                });

                lbox_1.DisplayMember = "nombre_cliente";

                lbox_1.ValueMember = "email_user";
                lbox_1.DataSource = CControl_Operacion.cliente_n;



                //------------------------------------------------------------------------------------
                if (!(objControlOperacion.Existscliente(tarjeta_cre)))
                {
                    CCliente clienteee = new CCliente()
                    {
                        nombre_cliente = nombre_,
                        contraseña_user = contraseña_,
                        email_user = email_,
                        tarjeta_credito = tarjeta_cre
                    };

                    if (objControlOperacion.Agregar_cliente(clienteee))
                    {
                        Add_cliente_en_lista(clienteee);
                        MessageBox.Show(" Registro existoso ");
                        txt_nombre.Clear();
                        txt_contraseña.Clear();
                        txt_trajeta_credito.Clear();
                        txt_email.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ERROR¡¡¡. No se pudo registrar ");
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario ya se registro");

                }

                //------------------------------------------------------------------------------------
                //frm_Sesion_Usuario frm = new frm_Sesion_Usuario();
                //frm.Show();
                //Close();
            }
            else
            {
                MessageBox.Show(" Error en el proceso. Verifique bien los datos ");
            }
        }

        //------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


  

    
        private void lbox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CCliente _cliente_ = (CCliente)lbox_1.SelectedItem;
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void agregar_lista (CCliente prueba)
        {
            ListViewItem lista = new ListViewItem();
        }
        private void listv_product_add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
