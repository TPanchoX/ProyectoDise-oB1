using System;
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
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Cuenta cuentaselect1;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            cuentaselect1 = Form1.Instance.cuentaselect;
            lblNombreCuenta.Text = cuentaselect1.usuarioC;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidarClave_Click(object sender, EventArgs e)
        {
            string claveUsuario = txtClaveCuenta.Text;
            if (cuentaselect1.ValidarContra(claveUsuario) == true) 
            {
                Form3 transacciones = new Form3();
                transacciones.Show();
                Form2.Instance.Hide();
            }
            else 
            {
                MessageBox.Show("Clave incorrecta");
            }
        }
    }
}
