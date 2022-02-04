using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3E
{
    internal class Persona
    {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public object Fechanacimiento { get; internal set; }

        public int edad()
        {
            //calcular la edad

            DateTime hoy = DateTime.Now;
            int anios = hoy.Year - FechaNacimiento.Year;
            if (hoy < FechaNacimiento.AddYears(anios)) anios--;

            return (anios);
        }

        public void normalizarNombre()
        {
            Nombre = Nombre.Trim();
            Apellido = Apellido.Trim();
            DPI = DPI.Trim();

            Nombre = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Nombre);
            //Nombre.SelectionStart = Nombre.Length;

            Apellido = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Apellido);
            //Apellido.SelectionStart = Apellido.Length;

            DPI = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DPI);
            //DPI.SelectionStart = DPI.Length;
        }
    }
}
