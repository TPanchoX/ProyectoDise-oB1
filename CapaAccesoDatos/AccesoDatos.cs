using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaCajero;

namespace CapaAccesoDatos
{
    public class AccesoDatos
    {
        ListaUsuarios list1 = new ListaUsuarios();
        public AccesoDatos() 
        {
            DateTime dt = new DateTime(2002, 8, 6);
            DateTime dtTarjeta = new DateTime(2026, 11, 6);
            Usuario u1 = new Usuario("Francisco Imbaquinga", "1722696539", dt);
            Tarjeta t1 = new Tarjeta("423035360015859", "577", dtTarjeta);
            Cuenta c1 = new Cuenta("Francis5642", "2569", 40, Enumt.Corriente);


            DateTime dtTarjeta2 = new DateTime(2024, 7, 20);
            Tarjeta t2 = new Tarjeta("5321987654321098", "123", dtTarjeta2);
            Cuenta c2 = new Cuenta("Sebas5642", "2569", 100, Enumt.Ahorros);

            t1.setearFK(c1);
            u1.AgregarCuentas(c1);
            u1.setearFK(c1);
            t2.setearFK(c2);
            u1.AgregarCuentas(c2);
            u1.setearFK(c2);


            list1.AgregarUsuarios(u1);
        }

        public ListaUsuarios retornoLista() 
        {
            return list1;
        } 
    }
}
