using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa.semana3
{
    internal class Perro
    {
        private string nombre;
        private string raza;
        private string altura;

        public Perro(string nombre, string raza, string altura)
        {
            Nombre = nombre;
            Raza = raza;
            Altura = altura;
            Nombre = nombre;
            Raza = raza;
            Altura = altura;
        }   

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Altura { get => altura; set => altura = value; }
    }
}
