using System;

namespace Ordenacao.MetodosOrdenacao
{
    public class Quick
    {
        public TimeSpan TempoOrdenacao { get; set; }

        public int[] QuickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            DateTime inicial = DateTime.Now;

            QuickSort1(vetor, inicio, fim);

            DateTime final = DateTime.Now;

            TempoOrdenacao = final.Subtract(inicial);

            return vetor;
        }

        void QuickSort1(int[] vetor, int inicio, int fim)
        {
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

                QuickSort1(vetor, inicio, f - 1);

                QuickSort1(vetor, f + 1, fim);
            }
        }
    }
}
