using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVideoJuego
{
    public class Mago : Personaje
    {

        public Mago(string Nombre, int Nivel) : base(Nombre, Nivel)
        {

            Vida = 100 + ((Nivel - 1) * 10);
            Ataque = 50;
            Defensa = 5;
            Tipo = "mago";

        }

        

        public override void Atacar(Personaje personajeAtacado, int daño)
        {



        }

        public override void RecibirDaño(Personaje personajeQueRecibeDaño, int danio)
        {



        }
    }


}
