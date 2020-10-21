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

            #region Outro método de ordenação
            #endregion
        }
    }
}
