using System.ComponentModel.DataAnnotations;

namespace PrácticaFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. double probandoSuma = Sumar(64, 2.5);

            //2. List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            //int sumaNumerosLista = SumarLista(list);

            //3. double a = Multiplicar(2, 3);

            //4. int cantidadVocales = ContarVocales("juani");

            //5. string palabraReLarga = buscarPalabraMasLarga("A la Pili le encanta el sexo ANAAAAAAAAAL");

            //6. int sumaDeDigitos = SumaDigitos("345");

            int[] tablaMultiplicacion = tablaDeMultiplicar(5);
            
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

        //3. Crea una función que reciba 2 números y devuelva su multiplicación.
        static double Multiplicar(double n1, double n2)
        {

            double multiplicar = n1 * n2;

            Console.WriteLine($"La multiplicación entre {n1} y {n2} es {multiplicar}");

            return multiplicar;

        }

        //4. Crea una función que reciba un string y devuelva la cantidad de vocales que contiene.
        static int ContarVocales(string palabra)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            int contadorVocales = 0;

            palabra = palabra.ToLower();

            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 0; j < vocales.Length; j++)
                {

                    if (palabra[i] == vocales[j])
                    {

                        contadorVocales++;

                    }
                }
            }

            Console.WriteLine($"La cantidad de vocales que tiene la palabra es {contadorVocales}");

            return contadorVocales;
        }

        //5. Crea una función que reciba un texto con varias palabras separadas por espacios y devuelve la palabra más larga.
        static string buscarPalabraMasLarga(string texto)
        {
            
            string[] palabras = texto.Split(' ');

            List<string> palabrasLimpias = new List<string>();

            foreach (string palabra in palabras)
            {
                string limpia = new string(palabra.Where(char.IsLetterOrDigit).ToArray());
                palabrasLimpias.Add(limpia);
            }

            int maxPalabra = 0;
            string palabraDeMasLongitud = string.Empty;

            for (int i = 0; i < palabrasLimpias.Count; i++)
            {
                if (palabrasLimpias[i].Length > maxPalabra)
                {

                    maxPalabra = palabrasLimpias[i].Length;

                    palabraDeMasLongitud = palabrasLimpias[i];

                }

            }

            Console.WriteLine($"La palabra más larga que hay en la frase es {palabraDeMasLongitud}");

            return palabraDeMasLongitud;

        }

        //6. Crea una función que reciba un número entero y devuelve la suma de sus dígitos.
        static int SumaDigitos(string num1)
        {
            int sumarDigitos = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                int num = int.Parse(num1[i].ToString()); 
                sumarDigitos += num;

            }

            Console.WriteLine($"La suma de los digitos de {num1} es {sumarDigitos}");
            return sumarDigitos;

        }

        //7. Crea una función que devuelva un array con la tabla de multiplicar de un número recibido hasta el 10.
        static int[] tablaDeMultiplicar(int num)
        {
            int[] tablas = new int[10];

            for (int i = 1; i < tablas.Length; i++)
            {

                int multiplicacion = num * i;
                tablas[i] = multiplicacion;

            } 

            foreach(int i in tablas)
            {

                Console.WriteLine(i);

            }
            return tablas;
        }

    }
}
