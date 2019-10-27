using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
   
    class Program
    {
        static bool CuatroVocalesDistintas(string cadena)
        {
            bool res = false;
            string copia = cadena;
            string vocaleSinRepetir = "";
            string vocales = "aeiou";

            for (int i = 0; i < copia.Length; i++)
            {
                for (int j = 0; j < vocales.Length; j++)
                {
                    if (!vocaleSinRepetir.Contains(copia[i]) && copia[i] == vocales[j])
                    {
                        vocaleSinRepetir = vocaleSinRepetir + copia[i];
                    }
                }
            }

            if (vocaleSinRepetir.Length > 3)
            {
                res = true;
            }

            return res;
        }
       
        static int NumeroPalabrasCuatroVocalesDiferentes(string[] arrayString)
        {
            int res = 0;
            string palabra = "";

            for (int i = 0; i < arrayString.Length; i++)
            {
                palabra = arrayString[i]; //Guardamos palabra del array ( guardará una a una por iteración de bucle )
                if(CuatroVocalesDistintas(palabra))
                {
                    res++;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            //Leemos los datos 
            Console.WriteLine("Escribe una frase: ");
            string frase = Console.ReadLine();

            //Palabras que tiene la frase
            string[] arrayFrase = frase.Split(' ');
            Console.WriteLine($"La frase tiene {arrayFrase.Length} palabras");

            //Devolvemos número de palabras que cumplan la regla:
            //Deben tener 4 o más vocales diferentes
            int numeroPalabrasEncontradas = NumeroPalabrasCuatroVocalesDiferentes(arrayFrase);
            Console.WriteLine($"{numeroPalabrasEncontradas} palabras encontradas que cumplen la regla");       
                    
            Console.ReadKey();
        }
    }
}
