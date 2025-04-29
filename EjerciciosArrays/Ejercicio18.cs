namespace EjerciciosArrays
{
    internal class Ejercicio18
    {
        //Crear una nueva lista con los elementos invertidos.
        public static void Ejecutar()
        {
            List<int> listaNormal = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> listaInvertida = new List<int>();

            for (int i = listaNormal.Count - 1; i >= 0; i--)
            {

                listaInvertida.Add(listaNormal[i]);

            }

            foreach(int numero in listaInvertida)
            {

                Console.WriteLine(numero);

            }

        }

    }
}
