using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class Cuenta
    {
        private static int id = 0;
        public string usuarioC {  get; set; }
        public string contrasena { get; set; }
        private double saldo { get; set; }
        private string tipoC { get; set; }
        public string FKtarjeta;
        public int FKusuario = 0;

        public Cuenta(string usuarioC, string contrasena, double saldo, string tipoC)
        {
            id = id + 1;
            this.usuarioC = usuarioC;
            this.contrasena = contrasena;
            this.saldo = saldo;
            this.tipoC = tipoC;
        }

        public double Depositar(double valorDepositar) 
        {
            saldo = valorDepositar + saldo;
            return saldo;
        }

        public string Retirar(double valorRetiro) 
        {
            if (saldo >= valorRetiro)
            {
                saldo = saldo - valorRetiro;
                return "Retiro excitoso: su saldo es" + saldo;
            }
            else 
            {
                return "Su saldo es insuficiente para realizar esta transaccion" ;
            }
        }

        public void MenuAcciones() 
        {
            int opcion;


            do 
            {
                Console.WriteLine("Por favor, seleccione la opcion que desee:");
                Console.WriteLine("1.Retirar Dinero");
                Console.WriteLine("2.Depositar Dinero");
                Console.WriteLine("3.Mostrar saldo");
                Console.WriteLine("4.salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        double montoRetiro = double.Parse(Console.ReadLine());

                        Console.WriteLine(Retirar(montoRetiro));

                        break;

                    case 2:
                        Console.WriteLine("Ingrese el monto a depositar: ");
                        double montoDepositar = double.Parse(Console.ReadLine());

                        Depositar(montoDepositar);

                        break;

                    case 3:

                        Console.WriteLine("Su saldo es:" + saldo);

                        break;
                }
            }
            while ( opcion != 4);
            
        }



        public override string ToString() // Obliga al override.. que es sobrescritura
        {
            return usuarioC  + saldo + tipoC;
        }
    }
}
