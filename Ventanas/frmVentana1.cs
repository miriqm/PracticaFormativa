using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormativa.Ventanas
{
    public partial class frmVentana1 : Form
    {
        public frmVentana1()
        {
            InitializeComponent();
        }

        private void btnNoModal_Click(object sender, EventArgs e)
        {
            Form formulario = new frmVentana2(); // variable del tipo Form
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new frmVentana2();
            formulario.ShowDialog();  
        }
    }
}
