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
    }
}
