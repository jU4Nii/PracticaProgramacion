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

            //5. string palabraReLarga = buscarPalabraMasLarga("");

            //6. int sumaDeDigitos = SumaDigitos("345");

            //7. int[] tablaMultiplicacion = tablaDeMultiplicar(10);

            //8. int cantLetraEnTexto = ContarLetra("Me llamo Juani", 'q');

            //10. NumerosParesEntreDosValoresDados(5, 9);

            //11. int[] array = { 1, 2, 3, 4, 5, 6,9,19,29213 };
            //ArregloInverso(array);

            //12. TipoNumero(-1000.003);

            //13. Rectangulo(10, 9);

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

            for (int i = 0; i < tablas.Length; i++)
            {

                int multiplicacion = num * (i+1);
                tablas[i] = multiplicacion;

            } 

            foreach(int i in tablas)
            {

                Console.WriteLine(i);

            }
            return tablas;
        }

        //8. Crea una función que devuelva cuántas veces aparece una letra específica en un texto.
        static int ContarLetra(string texto, char letra)
        {
            string textoMinuscula = texto.ToLower();
            char minuscula = char.ToLower(letra);

            int contador = 0;

            for (int i = 0; i<texto.Length; i++)
            {
                if (textoMinuscula[i] == minuscula) contador++;
            }
            Console.WriteLine($"La letra {letra} aparece {contador} vez/veces en '{texto}'");
            return contador;

        }

        //10. Función que muestra todos los números pares entre dos valores dados (inclusive).
        static void NumerosParesEntreDosValoresDados(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //11. Función que imprime los elementos de un array en orden inverso.
        static void ArregloInverso(int[] arreglo)
        {
            Array.Reverse(arreglo);
            foreach(int i in arreglo)
            {

                Console.WriteLine(i);

            }
        }

        //12. Función que imprime el tipo de número recibido. (Positivo, negativo o cero)
        static void TipoNumero(double num)
        {

            if (num > 0) Console.WriteLine("Número positivo");
            else if (num < 0) Console.WriteLine("Número negativo");
            else Console.WriteLine("Cero");

        }

        //13. Función que dibuja un rectángulo de ancho x alto usando asteriscos
        static void Rectangulo(int alto, int ancho)
        {

            int[,] matriz = new int[alto,ancho];

            for (int i = 0; i < alto; i++)
            {
                
                for (int j = 0; j < ancho; j++)
                {

                    Console.Write("*");

                }
                Console.Write("\n");

            }

        }

    }
}
