using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaCajero;

namespace Pruebas1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2002, 8, 6);
            DateTime dtTarjeta = new DateTime(2026, 11, 6);
            Usuario u1 = new Usuario("Francisco Imbaquinga", "1722696539", dt);
            Tarjeta t1 = new Tarjeta("423035360015859", "577", dtTarjeta);
            Cuenta c1 = new Cuenta("Francis5642", "2569", 40, "Co");

            
            DateTime dtTarjeta2 = new DateTime(2024, 7, 20);
            Tarjeta t2 = new Tarjeta("5321987654321098", "123", dtTarjeta2);
            Cuenta c2 = new Cuenta("Maria_95", "contraseña123", 100, "Ahorros");

            t1.setearFK(c1);
            u1.AgregarCuentas(c1);
            u1.setearFK(c1);
            t2.setearFK(c2);
            u1.AgregarCuentas(c2);
            u1.setearFK(c2);





            string numeroTingresado = Console.ReadLine();
            u1.validarTarjeta(numeroTingresado);
        }
    }
}
