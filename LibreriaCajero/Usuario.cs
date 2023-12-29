using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class Usuario
    {

        public static int id = 0;
        private string name { get; set; }
        private string ci {  get; set; }
        private DateTime fNacimiento { get; set; }

        public List<Cuenta> cuentas { get; set; }

        public Usuario( string name, string ci, DateTime fNacimiento)
        {
            id = id + 1 ;
            this.name = name;
            this.ci = ci;
            this.fNacimiento = fNacimiento;
            cuentas = new List<Cuenta>();
        }

        public void AgregarCuentas(Cuenta c1) 
        {
            cuentas.Add(c1);
        }

        public void setearFK(Cuenta c1)
        {
            c1.FKusuario = id;
        }

        public void validarTarjeta(string numeroingresado) 
        {
            string contraIngresada;
            foreach (var cuenta in cuentas) 
            {
                if (numeroingresado == cuenta.FKtarjeta)
                {
                    Console.WriteLine("Usuario = " + cuenta.usuarioC);
                    Console.WriteLine("Por favor, Ingrese la clave de la cuenta bancaria : ");
                    contraIngresada = Console.ReadLine();
                    if (contraIngresada == cuenta.contrasena)
                    {
                        Console.WriteLine("Ingreso a la cuenta exitoso");
                        cuenta.MenuAcciones();
                    }
                    else 
                    {
                        Console.WriteLine("Contrasena incorrecta");
                        break;
                    }
                }
                else 
                {
                    Console.WriteLine("No se encontro ningun usuario o cuenta asociada a esa tarjeta");
                }

            }
        }

    }
}
