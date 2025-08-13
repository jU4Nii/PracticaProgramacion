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



        public override void Atacar(Personaje personajeAtacado)
        {

            Console.WriteLine($"El arquero {this.Nombre} ataca al {personajeAtacado.Tipo} {personajeAtacado.Nombre}");
            personajeAtacado.RecibirDaño(this);

        }

        public override void RecibirDaño(Personaje personajeQueAtaca)
        {

            this.Vida = this.Vida - (personajeQueAtaca.Ataque - this.Defensa);

        }

    }

}
}
