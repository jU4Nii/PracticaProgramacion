using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    internal class Ejercicio19
    {
        //Mostrar los nombres que comienzan con vocal.
        public static void Ejecutar()
        {

            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            List<string> nombres = new List<string> { "ana", "juani", "ernesto","esteban","roberto","ariel","uriel" };

            List<string> nombresConVocal = new List<string>();

            string nombreAnalizado;

            for (int i = 0; i < nombres.Count; i++)
            {
                nombreAnalizado = nombres[i];

                for (int j = 0; j < 5; j++)

                if(nombreAnalizado[0] == vocales[j])
                    {

                    nombresConVocal.Add(nombreAnalizado);

                }
            }

            foreach (string nombre in nombresConVocal)
            {

                Console.WriteLine(nombre);

            }

        }

    }
}
