using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVideoJuego
{
    public abstract class Personaje
    {
        public Personaje(string nombre, int Nivel)
        {

            this.Nombre = Nombre;

            this.Nivel = Nivel;

        }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        public int Nivel { get; set; }

        public int Vida {  get; set; }

        public int Ataque { get; set; }

        public int Defensa { get; set; }

        public int CantidadDeCombates { get; set; }

        public int CantVictorias { get; set; }

        public int CantDerrotas { get; set; }

        public int DañoTotalInflingido { get; set; }

        

        public int DañoRecibido { get; set; }

        public abstract void Atacar(Personaje personajeAtacado);

        public abstract void RecibirDaño(Personaje personajeQueAtaca);
        



    }
}
