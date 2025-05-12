using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masEjercicios
{
    class Ejercicio8
    {
        //8- Generar 10 números aleatorios entre 1 y 20 sin repetir. Mostrarlos en una lista. 
        public static void Ejecutar()
        

            
        {
            Random num = new Random();
            List<int> lista = new List<int>();

            while (lista.Count < 10)
            {
                int aleatorio = num.Next(1, 21);
                int contador = 0;

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i] == aleatorio)
                    {
                        contador++;
                    }
                }

                if (contador == 0)
                {
                    lista.Add(aleatorio);
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }



    }


}
