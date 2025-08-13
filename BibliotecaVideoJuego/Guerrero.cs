using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVideoJuego
{
    public class Guerrero : Personaje
    {
        public Guerrero(string Nombre, int Nivel) : base(Nombre, Nivel) 
        {

            Vida = 150 + ((Nivel -1) * 15);
            Ataque = 30;
            Defensa = 15;
            Tipo = "guerrero";
        
        }

        

        public override void Atacar(Personaje personajeAtacado)
        {

            Console.WriteLine($"El guerrero {this.Nombre} ataca al {personajeAtacado.Tipo} {personajeAtacado.Nombre}");
            personajeAtacado.RecibirDaño(this);

        }

        public override void RecibirDaño(Personaje personajeQueAtaca)
        {
            int daño = personajeQueAtaca.Ataque - this.Defensa;
            if (daño < 0) daño = 0;
            this.Vida = this.Vida - daño;

        }

    }
}
