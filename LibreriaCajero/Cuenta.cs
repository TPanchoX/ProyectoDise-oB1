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
        public string FKtarjeta;
        public int FKusuario = 0;

        public Enumt Tipo { get; set; } 

        public Cuenta() { }
        public Cuenta(string usuarioC, string contrasena, double saldo, Enumt t)
        {
            id = id + 1;
            this.usuarioC = usuarioC;
            this.contrasena = contrasena;
            this.saldo = saldo;
            this.Tipo = t;
        }

        public void Depositar(double valorDepositar) 
        {
            saldo = valorDepositar + saldo;
        }

        public void Retirar(double valorRetiro) 
        {
                saldo = saldo - valorRetiro;
        }


        public Boolean ValidarContra(string ContraIngresada) 
        {
            if (ContraIngresada == contrasena) 
            {
                return true;
            }
            return false;
        }
       
        public override string ToString() // Obliga al override.. que es sobrescritura
        {
            return usuarioC  + saldo + Tipo;
        }
    }
}
