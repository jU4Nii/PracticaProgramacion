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
            Random random = new Random();
            int ataqueArquero = this.Ataque;
            if (random.NextDouble() < 0.25)
            {

                ataqueArquero *= 2;
                Console.WriteLine("¡Daño doble!");

            }
            int ataqueBackup = this.Ataque;

            this.Ataque = ataqueArquero;

            personajeAtacado.RecibirDaño(this);

            this.Ataque = ataqueBackup;

        }

        public override void RecibirDaño(Personaje personajeQueAtaca)
        {

            int daño = personajeQueAtaca.Ataque - this.Defensa;
            if (daño < 0) daño = 0;
            this.Vida = this.Vida - daño;

        }

    }


}
