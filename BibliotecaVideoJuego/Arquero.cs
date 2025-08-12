using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVideoJuego
{
    public class Arquero : Personaje
    {

        public Arquero(string Nombre, int Nivel) : base(Nombre, Nivel)
        {

            Vida = 120 + ((Nivel - 1) * 12);
            Ataque = 25;
            Defensa = 10;
            Tipo = "arquero";

        }

        

        public override void Atacar(Personaje personajeAtacado, int daño)
        {



        }

        public override void RecibirDaño(Personaje personajeQueRecibeDaño, int danio)
        {



        }

    }

}
}
