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
    public partial class frm_Actualizar_lista : Form
    {
        public frm_Actualizar_lista()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cantidad.Clear();
            txt_nombre_objeto.Clear();
            txt_precio.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (!(txt_cantidad.Text == "" && txt_nombre_objeto.Text == "" && txt_precio.Text == ""))
            {
                string nombre_ = txt_nombre_objeto.Text;
                Int16 cantidad_ = Convert.ToInt16(txt_cantidad.Text);
                Int16 precio_ = Convert.ToInt16(txt_precio.Text);


                CControl_Operacion.producto_n.Add(new CCProducto()
                {
                    nombre_producto = nombre_,
                    cantidad = cantidad_,
                    precio_unitario = precio_
                });

                txt_cantidad.Clear();
                txt_nombre_objeto.Clear();
                txt_precio.Clear();


            }
            else
            MessageBox.Show("Datos insuficientes, porfavor revisar los recuadros ");
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
