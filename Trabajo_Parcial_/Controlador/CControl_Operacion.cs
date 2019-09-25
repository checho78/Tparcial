using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Parcial_.Model;


namespace Trabajo_Parcial_.Controlador
{
    class CControl_Operacion
    {

        public  static List<CCliente> cliente_n { get; set; }
        public static List<CAdministrador> administrador_n{ get; set; }
        public static List<CCProducto> producto_n { get; set; }

        public CControl_Operacion()
        {
            if (administrador_n == null) administrador_n = new List<CAdministrador>();
            if (cliente_n == null) cliente_n = new List<CCliente>();
            if (producto_n == null) producto_n = new List<CCProducto>();
                    
        }

        public bool validar_administrador(CAdministrador admi)
        {
            administrador_n.Add(admi);
            if (admi.nombre_admi == "Sergio" || admi.nombre_admi == "Alessandro" || admi.nombre_admi == "Rafael"
                && admi.correo == "checho_admi@games.com" || admi.correo == "Ale_admi@games.com" || admi.correo == "rafita_admi@games.com"
                && admi.contraseña == "contraseña_de_admi")
            {
                return true;
            }
            return false;
            
        }




        public bool  Agregar_cliente(CCliente cli)
        {
            if (!Existscliente(cli.tarjeta_credito))
            {
                cliente_n.Add(cli);
                return true;
            }
            return false;
        }
        public void Agregar_producto(CCProducto pro)
        {
            producto_n.Add(pro);
        }

        public bool Existscliente(Int32 tarjeta)
        {
            return cliente_n.Exists(delegate (CCliente cliente_a) {
                return cliente_a.tarjeta_credito == tarjeta;

            });
        }




    }
}
