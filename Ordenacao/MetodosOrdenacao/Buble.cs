using System;

namespace Ordenacao.MetodosOrdenacao
{
    public class Buble
    {
        public TimeSpan TempoOrdenacao { get; set; }

        public int[] BubleSort(int[] vetor)
        {
            int aux;
            bool ordenado = false;

            DateTime inicial = DateTime.Now;

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

            DateTime final = DateTime.Now;

            TempoOrdenacao = final.Subtract(inicial);

            return vetor;
        }
    }
}
