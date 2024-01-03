using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace LibreriaCajero
{
    public class CreacionDatos
    {
        public ListaUsuarios getretornoLista()
        {
            AccesoDatos datos = new AccesoDatos();
            return datos.retornoLista();
        }
    }
}
