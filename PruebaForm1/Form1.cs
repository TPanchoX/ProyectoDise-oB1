using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCajero;
using CapaAccesoDatos;

namespace PruebaForm1
{

    public partial class Form1 : Form
    {

        public static Form1 Instance;
        public ListaUsuarios list1;
        public Cuenta cuentaselect;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            CreacionDatos datos = new CreacionDatos();
            list1 = datos.getretornoLista();
        }

        private void btnValidarTarjeta_Click(object sender, EventArgs e)
        {

            string NumeroTarjetaIngresada = txtNtarjeta.Text;

            if (list1.ValidarTarjeta(NumeroTarjetaIngresada) == true)
            {
                cuentaselect = list1.returnCuenta();
                
                Form2 usuarioclave = new Form2();
                this.Hide();
                usuarioclave.Show();

            }
            else 
            {
                MessageBox.Show("Ingreso sin exito");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
