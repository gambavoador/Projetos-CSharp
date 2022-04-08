using System;

namespace Atividade_AED_10_11_2021_IS_BS_SS_String
{
    class Program
    {
        static void InsertionSort(string[] arrayNumeros)
        {
            int indice02;
            string atual;

            for (int indice = 1; indice < arrayNumeros.Length; indice++)
            {
                atual = arrayNumeros[indice];

                for (indice02 = indice; indice02 > 0 && (arrayNumeros[indice02 - 1].CompareTo(atual)) > 0; indice02--)
                    arrayNumeros[indice02] = arrayNumeros[indice02 - 1];

                if (indice02 != indice)
                    arrayNumeros[indice02] = atual;
            }
        }


        static void SelectionSort(string[] arrayNumeros)
        {
            int indiceMaior;
            string aux;

            for (int indice = arrayNumeros.Length - 1; indice >= 0; indice--)
            {
                indiceMaior = indice;

                for (int indice02 = indice - 1; indice02 >= 0; indice02--)
                    if (arrayNumeros[indice02].CompareTo(arrayNumeros[indiceMaior]) > 0)
                        indiceMaior = indice02;

                if (indiceMaior != indice)
                {
                    aux = arrayNumeros[indiceMaior];
                    arrayNumeros[indiceMaior] = arrayNumeros[indice];
                    arrayNumeros[indice] = aux;
                }
            }
        }

        static void BubbleSort(string[] arrayNumeros)
        {
            string aux;

            for (int indice = 0; indice < arrayNumeros.Length; indice++)
            {
                for (int indice02 = 0; indice < arrayNumeros.Length - (indice02 + 1); indice02++)
                {
                    if (arrayNumeros[indice02].CompareTo(arrayNumeros[indice02 + 1]) > 0)
                    {
                        aux = arrayNumeros[indice02];
                        arrayNumeros[indice02] = arrayNumeros[indice02 + 1];
                        arrayNumeros[indice02 + 1] = aux;
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            string[] arrayNumeros = new string[4] { "roger", "brian", "john", "freddie" };

            InsertionSort(arrayNumeros);
            SelectionSort(arrayNumeros);
            BubbleSort(arrayNumeros);
        }
    }
}
