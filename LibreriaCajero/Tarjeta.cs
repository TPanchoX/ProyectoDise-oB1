using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class Tarjeta
    {

        private string numeroT {  get; set; }
        private string cvv { get; set; }
        private DateTime fExpiracion { get; set; }

        public Tarjeta(string numeroT, string cvv, DateTime fExpiracion)
        {
            this.numeroT = numeroT;
            this.cvv = cvv;
            this.fExpiracion = fExpiracion;
        }

        public void setearFK(Cuenta c1) 
        {
            c1.FKtarjeta = numeroT;
        }
    }
}
