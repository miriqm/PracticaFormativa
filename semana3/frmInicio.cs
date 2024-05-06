using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaFormativa.semana3
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e,MessageBoxIcon messageBoxIcon)
        {
           
        }



        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIngPerro_Click(object sender, EventArgs e)
        {
            string nombre;
            string tipo;
            string medida;

            // Abre un messagebox con un inputbox

            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del Perro", "Carga de la clase");

            tipo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese raza", "Carga de la clase");

            medida = Microsoft.VisualBasic.Interaction.InputBox("Ingrese altura del Perro", "Carga de la clase");

            // INSTACIAMOS UN OBJETO DE LA CLASE PERRO

            Perro perrito = new Perro(nombre, tipo, medida);


            // MOstrar en cuadro de dialogo los datos de la clase ingresada
            MessageBox.Show("El perrito se llama:" + perrito.Nombre + " de raza " + perrito.Raza + " y su altura es: " + perrito.Altura, "salida de datos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            
            
            
            //Console.WriteLine(nombre);



        }
    }
}
