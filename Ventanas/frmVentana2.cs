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
    public partial class frmVentana2 : Form
    {
        public frmVentana2()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new frmVentana1();
            principal.Show();
            this.Close();
        }
    }
}
