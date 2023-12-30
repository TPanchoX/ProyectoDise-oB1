using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class ListaUsuarios
    {
        public static Cuenta cuentaSeleccionada {  get; set; }
        public List<Usuario> Usuarios { get; set; }

        public ListaUsuarios() 
        {
            Usuarios = new List<Usuario>();
        }

        public void AgregarUsuarios(Usuario u) 
        {
            Usuarios.Add(u);
        }

        public Boolean ValidarTarjeta(string nTarjeta) 
        {
            foreach (var u in Usuarios) 
            {
                foreach (var cuenta in u.cuentas) 
                {
                    if (nTarjeta == cuenta.FKtarjeta) 
                    {
                        cuentaSeleccionada = cuenta;
                        return true;
                    }
                }
            }
            return false;
        }

        public Cuenta returnCuenta() 
        {
            return cuentaSeleccionada;
        }

        public string tostring() 
        {
            return cuentaSeleccionada.ToString();
        }
    }
}
