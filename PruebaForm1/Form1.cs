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
//using CapaAccesoDatos;

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


            list1 = new ListaUsuarios();

            list1.AgregarUsuarios(u1);
            
            

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
