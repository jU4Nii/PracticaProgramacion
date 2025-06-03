namespace PrácticaFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. double probandoSuma = Sumar(64, 2.5);

            //2.List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            //int sumaNumerosLista = SumarLista(list);


            

        }

        //1. Crea una función que reciba 2 números y los sume.
        static double Sumar(double num1, double num2)
        {

            double suma = num1 + num2;

            Console.WriteLine($"La suma entre {num1} y {num2} es {suma}");

            return suma;

        }

        //2. Crea una función que reciba una lista de números y devuelve la suma de los mismos.
        static int SumarLista(List<int> lista) 
        {
            int sumaLista = 0;
            for (int i = 0; i < lista.Count; i++)
            {

                sumaLista += lista[i];

            }

            Console.WriteLine($"La suma de los números de la lista es {sumaLista}");

            return sumaLista;

        }

        //3. 

    }
}
