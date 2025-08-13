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



        public override void Atacar(Personaje personajeAtacado)
        {

            Console.WriteLine($"El mago {this.Nombre} ataca al {personajeAtacado.Tipo} {personajeAtacado.Nombre}");
            Random random = new Random();
            int ataqueMago = this.Ataque;
            if(random.NextDouble() < 0.25)
            {

                ataqueMago *= 2;
                Console.WriteLine("¡Daño doble!");

            }
            int ataqueBackup = this.Ataque;

            this.Ataque = ataqueMago;

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
