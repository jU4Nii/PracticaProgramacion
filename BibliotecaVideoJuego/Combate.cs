using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVideoJuego
{
    public class Combate
    {

        public Combate(Personaje Personaje1, Personaje Personaje2)
        {
            this.Personaje1 = Personaje1;

            this.Personaje2 = Personaje2;


        }

        public Personaje Personaje1 { get; set; }

        public Personaje Personaje2 { get; set; }

        public Personaje Ganador { get; set; }

        public Personaje Perdedor { get; set; }

        public int NumeroTurnos { get ; set; }

        public void Combatir()
        {
            while (Personaje1.Vida > 0 && Personaje2.Vida > 0)
            {

                Personaje1.Atacar(Personaje2);
                Personaje1.DañoTotalInflingido += (Personaje1.Ataque - Personaje2.Defensa);
                Personaje2.DañoRecibido += (Personaje1.Ataque - Personaje2.Defensa);
                if (Personaje2.Vida <= 0) break;
                Personaje2.Atacar(Personaje1);
                Personaje2.DañoTotalInflingido += (Personaje2.Ataque - Personaje1.Defensa);
                Personaje1.DañoRecibido += (Personaje2.Ataque - Personaje1.Defensa);
                if (Personaje1.Vida <= 0) break;
                NumeroTurnos++;

            }

            Personaje1.CantidadDeCombates++;
            Personaje2.CantidadDeCombates++;
            
            if (Personaje1.Vida <= 0)
            {

                Ganador = Personaje2;
                Perdedor = Personaje1;
                Personaje2.CantVictorias++;
                Personaje1.CantDerrotas++;
                

            }
            else if (Personaje2.Vida <= 0)
            {

                Ganador = Personaje1;
                Perdedor = Personaje2;
                Personaje1.CantVictorias++;
                Personaje2.CantDerrotas++;

            }



        }



    }
}
