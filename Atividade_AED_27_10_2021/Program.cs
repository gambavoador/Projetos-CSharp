using System;
using System.Diagnostics;


namespace Atividade_AED_27_10_2021
{
    class Program
    {
		class HeapSort
		{
		
			private int heapSize;

			private void ConstruirMaxHeap(int[] arr)
			{
				heapSize = arr.Length - 1;
				for (int i = heapSize / 2; i >= 0; i--)
				{
					ExecutarMaxHeap(arr, i);
				}
			}

			private void Trocar(int[] arr, int x, int y)
			{
				int temp = arr[x];
				arr[x] = arr[y];
				arr[y] = temp;
			}

			private void ExecutarMaxHeap(int[] arr, int index)
			{
				int noEsquerdo = 2 * index + 1;
				int noDireito = 2 * index + 2;
				int maior = index;

				if (noEsquerdo <= heapSize && arr[noEsquerdo] > arr[index])
				{
					maior = noEsquerdo;
				}

				if (noDireito <= heapSize && arr[noDireito] > arr[maior])
				{
					maior = noDireito;
				}

				if (maior != index)
				{
					Trocar(arr, index, maior);
					ExecutarMaxHeap(arr, maior);
				}
			}

			public void ExecutarHeapSort(int[] arr)
			{
				ConstruirMaxHeap(arr);
				for (int i = arr.Length - 1; i >= 0; i--)
				{
					Trocar(arr, 0, i);
					heapSize--;
					ExecutarMaxHeap(arr, 0);
				}

				MostrarArray(arr);
			}

			private void MostrarArray(int[] arr)
			{
				for (int i = 0; i < arr.Length; i++)
				{ Console.Write("[{0}]", arr[i]); }
			}

		}

		class MergeSort
		{
			private void Mesclar(int[] numbers, int esquerda, int meio, int direita)
			{
				int[] temp = new int[numbers.Length];
				int i, esquerda_end, num_elements, tmp_pos;

				esquerda_end = (meio - 1);
				tmp_pos = esquerda;
				num_elements = (direita - esquerda + 1);

				while ((esquerda <= esquerda_end) && (meio <= direita))
				{
					if (numbers[esquerda] <= numbers[meio])
						temp[tmp_pos++] = numbers[esquerda++];
					else
						temp[tmp_pos++] = numbers[meio++];
				}

				while (esquerda <= esquerda_end)
					temp[tmp_pos++] = numbers[esquerda++];

				while (meio <= direita)
					temp[tmp_pos++] = numbers[meio++];

				for (i = 0; i < num_elements; i++)
				{
					numbers[direita] = temp[direita];
					direita--;
				}
			}

			public void MergeSort_Recursivo(int[] numbers, int esquerda, int direita)
			{
				int meio;

				if (direita > esquerda)
				{
					meio = (direita + esquerda) / 2;
					MergeSort_Recursivo(numbers, esquerda, meio);
					MergeSort_Recursivo(numbers, (meio + 1), direita);

					Mesclar(numbers, esquerda, (meio + 1), direita);
				}
			}
		}


		static void InsertionSort(int[] arrayNumeros)
		{
			int atual, indice02;

			for (int indice = arrayNumeros.Length - 2; indice >= 0; indice--)
			{
				atual = arrayNumeros[indice];

				for (indice02 = indice; indice02 < arrayNumeros.Length - 1 && arrayNumeros[indice02 + 1] > atual; indice02++)
					arrayNumeros[indice02] = arrayNumeros[indice02 + 1];

				if (indice02 != indice)
					arrayNumeros[indice02] = atual;
			}
		}

		static void SelectionSort(int[] arrayNumeros)
		{
			int indiceMaior, aux;

			for (int indice = arrayNumeros.Length - 1; indice >= 0; indice--)
			{
				indiceMaior = indice;

				for (int indice02 = indice - 1; indice02 >= 0; indice02--)
					if (arrayNumeros[indice02] > arrayNumeros[indiceMaior])
						indiceMaior = indice02;

				if (indiceMaior != indice)
				{
					aux = arrayNumeros[indiceMaior];
					arrayNumeros[indiceMaior] = arrayNumeros[indice];
					arrayNumeros[indice] = aux;
				}
			}
		}

		static void BubbleSort(int[] arrayNumeros)
		{
			int aux;

			for (int indice = 0; indice < arrayNumeros.Length; indice++)
			{
				for (int indice02 = 0; indice < arrayNumeros.Length - (indice02 + 1); indice02++)
				{
					if (arrayNumeros[indice02] > arrayNumeros[indice02 + 1])
					{
						aux = arrayNumeros[indice02];
						arrayNumeros[indice02] = arrayNumeros[indice02 + 1];
						arrayNumeros[indice02 + 1] = aux;
					}
				}
			}
		}

		static void ShellSort(int[] vetor)
		{
			int indiceAux, aux;
			int pulo = 2;

			while (pulo > 0)
			{
				for (int indice = 0; indice < vetor.Length; indice++)
				{
					indiceAux = indice;
					aux = vetor[indice];

					while ((indiceAux >= pulo) && (vetor[indiceAux - pulo] > aux))
					{
						vetor[indiceAux] = vetor[indiceAux - pulo];
						indiceAux = indiceAux - pulo;
					}
					vetor[indiceAux] = aux;
				}

				if (pulo / 2 != 0)
					pulo = pulo / 2;
				else if (pulo == 1)
					pulo = 0;
				else
					pulo = 1;
			}

			// exemplo recursividade
			static int fatorial(int numero)
			{
				if (numero == 1)
					return 1;

				return numero * fatorial(numero - 1);
			}

			// Método de Ordenação HEAP SORT

		}
			// Método de Ordenação QUICK SORT
			static void QuickSort(int[] vetor, int primeiro, int ultimo)
			{
				int baixo, alto, meio, pivo, repositorio;
				baixo = primeiro;
				alto = ultimo;
				meio = (int)((baixo + alto) / 2);

				pivo = vetor[meio];

				while (baixo <= alto)
				{
					while (vetor[baixo] < pivo)
						baixo++;
					while (vetor[alto] > pivo)
						alto--;
					if (baixo < alto)
					{
						repositorio = vetor[baixo];
						vetor[baixo] = vetor[alto];
						vetor[alto] = repositorio;

						baixo++;
						alto--;
					}
					else
					{
						if (baixo == alto)
						{
							baixo++;
							alto--;
						}
					}
				}

				if (alto > primeiro)
					QuickSort(vetor, primeiro, alto);
				if (baixo < ultimo)
					QuickSort(vetor, baixo, ultimo);
			}


		


		static void Main(string[] args)
		{
			Random random = new Random();

			int[] arrayNumeros = new int[100000];

			for (int indice = 0; indice < arrayNumeros.Length - 1; indice++)
			{
				arrayNumeros[indice] = random.Next(0, arrayNumeros.Length);
			}

			/*-----------------------------------------------------------------------------------*/

			Stopwatch sw = new Stopwatch();			

			sw.Start();

			HeapSort heapSort = new HeapSort();
			heapSort.ExecutarHeapSort(arrayNumeros);
			sw.Stop();

			TimeSpan tempo = sw.Elapsed;

			Console.WriteLine($"\n\nTempo de Execução Heap Sort: {tempo}");
			Console.WriteLine("---------------------------------------------");

			sw.Reset();

			/*-----------------------------------------------------------------------------------*/

			sw.Start();

			MergeSort mergeSort = new MergeSort();
			mergeSort.MergeSort_Recursivo(arrayNumeros, 0, arrayNumeros.Length - 1);
			sw.Stop();

			tempo = sw.Elapsed;

			Console.WriteLine($"Tempo de Execução Merge Sort: {tempo}");
			Console.WriteLine("---------------------------------------------");

			sw.Reset();

			/*-----------------------------------------------------------------------------------*/

			sw.Start();

			InsertionSort(arrayNumeros);
			
			sw.Stop();

			tempo = sw.Elapsed;

			Console.WriteLine($"Tempo de Execução Insertion Sort: {tempo}");
			Console.WriteLine("---------------------------------------------");

			sw.Reset();

			/*-----------------------------------------------------------------------------------*/


			sw.Start();

			SelectionSort(arrayNumeros);

			sw.Stop();

			tempo = sw.Elapsed;

			Console.WriteLine($"Tempo de Execução SelectionSort: {tempo}");
			Console.WriteLine("---------------------------------------------");

			sw.Reset();

			/*-----------------------------------------------------------------------------------*/

			sw.Start();

			BubbleSort(arrayNumeros);

			sw.Stop();

			tempo = sw.Elapsed;

			Console.WriteLine($"Tempo de Execução Bubble Sort: {tempo}");
			Console.WriteLine("---------------------------------------------");
			sw.Reset();

			/*-----------------------------------------------------------------------------------*/

			sw.Start();

			ShellSort(arrayNumeros);

			sw.Stop();

			tempo = sw.Elapsed;

			Console.WriteLine($"Tempo de Execução Shell Sort: {tempo}");
			Console.WriteLine("---------------------------------------------");
			sw.Reset();


			/*-----------------------------------------------------------------------------------*/

			sw.Start();

			QuickSort(arrayNumeros, 0, arrayNumeros.Length - 1);

			sw.Stop();

			tempo = sw.Elapsed;

			Console.WriteLine($"Tempo de Execução Quick Sort: {tempo}");
			Console.WriteLine("---------------------------------------------");
			sw.Reset();

		}
	}
}
  
