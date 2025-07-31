using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesEntregableTorneos
{
    public class Equipo
    {

        public Equipo(string NombreEquipo, string CiudadEquipo)
        {

            this.NombreEquipo = NombreEquipo;

            this.CiudadEquipo = CiudadEquipo;

        }

        public string NombreEquipo { get; set; }

        public string CiudadEquipo { get; set; }

       public int Puntos { get; set; }

        public int GolesAFavor {  get; set; }

        public int GolesEnContra { get; set; }

        


    }
}
