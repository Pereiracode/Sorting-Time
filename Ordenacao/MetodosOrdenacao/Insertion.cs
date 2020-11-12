using System;

namespace Ordenacao.MetodosOrdenacao
{
    public class Insertion
    {
        public TimeSpan TempoOrdenacao { get; set; }

        public int[] InsertionSort(int[] vetor)
        {
            if (vetor.Length <= 1) return vetor;

            DateTime inicial = DateTime.Now;

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

            DateTime final = DateTime.Now;

            TempoOrdenacao = final.Subtract(inicial);
            return vetor;
        }
    }
}
