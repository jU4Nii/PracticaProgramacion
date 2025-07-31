using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasesEntregableTorneos
{
    public static class TablaDePosiciones
    {

        public static List<Equipo> TablaDeEquipos = new List<Equipo>();

        public static void VerEquipos()
        {

            Console.WriteLine("Equipos registrados en el sistema:");
            for (int i = 0; i < TablaDeEquipos.Count; i++)
            {

                Console.WriteLine($"{i+1}. {TablaDeEquipos[i].NombreEquipo}");


            }

        }

        public static void MostrarTabla()
        {
            Console.WriteLine("Posición: - Equipo: - Puntos: - Goles a favor: - Goles en contra");
            for (int i = 0; i < TablaDeEquipos.Count; i++)
            {

                Console.WriteLine($"{i + 1}° - {TablaDeEquipos[i].NombreEquipo} - {TablaDeEquipos[i].Puntos} - {TablaDeEquipos[i].GolesAFavor} - {TablaDeEquipos[i].GolesEnContra}");


            }

        }

       public static void OrdenarTabla()
        {

            TablaDeEquipos = TablaDeEquipos.OrderByDescending(x=> x.Puntos).ThenByDescending(x => x.GolesAFavor - x.GolesEnContra).ThenByDescending(x => x.GolesAFavor).ToList();

        }

        }

    }

