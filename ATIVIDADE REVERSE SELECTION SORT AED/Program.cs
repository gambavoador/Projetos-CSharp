using System;

namespace AULA_15_09_2021
{
    class Program
    {

        static void SelectionSort(int[] arrayNumeros)
        {
            int indiceMenor, aux;

            for (int indice = arrayNumeros.Length - 1; indice > 0; indice--)
            {
                indiceMenor = indice;
                for (int indice02 = indice - 1; indice02 >= 0; indice02--)
                    if (arrayNumeros[indice02] < arrayNumeros[indiceMenor])
                        indiceMenor = indice02;

                if (indiceMenor != indice)
                {
                    aux = arrayNumeros[indiceMenor];
                    arrayNumeros[indiceMenor] = arrayNumeros[indice];
                    arrayNumeros[indice] = aux;
                }

            }
        }

        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[4] { 1, 2, 3, 4 };
            SelectionSort(arrayNumeros);
        }
    }
}