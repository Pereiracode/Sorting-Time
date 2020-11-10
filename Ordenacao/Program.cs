using System;

namespace Ordenacao
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region Gerando aleatórios e vetor dinâmico
            Random r = new Random();

            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vet = new int[tamanho];

            for (int i = 0; i <= vet.Length - 1; i++)
            {
                vet[i] = r.Next(1, 10000);
            }

            int[] ordenado = new int[tamanho]; 
            
            ordenado = InsertionSort(vet);

            for (int i = 0; i <= ordenado.Length - 1; i++)
            {
                Console.WriteLine(ordenado[i]);
            }


            #endregion

            #region Método BubleSort
            int[] BubleSort(int[] vetor)
            {
                int aux;
                bool ordenado = false;

                while (ordenado == false)
                {
                    ordenado = true;
                    for (int i = 0; i < vetor.Length - 1; i++)
                    {
                        if (vetor[i] > vetor[i + 1])
                        {
                            aux = vetor[i + 1];
                            vetor[i + 1] = vetor[i];
                            vetor[i] = aux;
                            ordenado = false;
                        }
                    }
                }

                ordenado = true;
                return vetor;
            }
            #endregion

            #region Método QuickSort
            /*static int[] QuickSort(int[] vetor, int inicio, int fim)
            {
                inicio = 0;
                fim = vetor.Length - 1;

                if (inicio < fim)
                {
                    int p = vetor[inicio];
                    int i = inicio + 1;
                    int f = fim;

                    while (i <= f)
                    {
                        if (vetor[i] <= p)
                        {
                            i++;
                        }
                        else if (p < vetor[f])
                        {
                            f--;
                        }
                        else
                        {
                            int troca = vetor[i];
                            vetor[i] = vetor[f];
                            vetor[f] = troca;
                            i++;
                            f--;
                        }
                    }

                    vetor[inicio] = vetor[f];

                    vetor[f] = p;

                    QuickSort(vetor, inicio, f - 1);

                    QuickSort(vetor, f + 1, fim);
                }

            }*/
            #endregion

            #region Método InsertionSort
            int[] InsertionSort(int[] vetor)
            {
                if (vetor.Length <= 1) return vetor;

                int j, key;

                for (int i = 1; i <= vetor.Length - 1; i++)
                {
                    j = i - 1;
                    key = vetor[i];

                    while (j >= 0 && key < vetor[j])
                    {
                        vetor[j + 1] = vetor[j];
                        j--;
                        vetor[j + 1] = key;
                    }
                }
                return vetor;
            }

            #endregion
        }

    }
}
