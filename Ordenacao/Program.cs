using System;
using Ordenacao.MetodosOrdenacao;

namespace Ordenacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            Buble buble = new Buble();
            Insertion insertion = new Insertion();
            Quick quick = new Quick();

            
            do {

                Console.Write("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vet = new int[tamanho];

                for (int i = 0; i <= vet.Length - 1; i++)
                {
                    vet[i] = r.Next(1, 100000);
                }

                Console.WriteLine("=== Vetor Desordenado ===");
                for (int i = 0; i <= vet.Length - 1; i++)
                {
                    Console.WriteLine(vet[i]);
                }

                Console.WriteLine
                    ("\nQual método você quer usar para ordenação?\n1-BubleSort\n2-InsertionSort\n3-QuickSort\n0-Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int [] vetorBuble = buble.BubleSort(vet);

                        Console.WriteLine("=== Vetor Ordenado ===");

                        for (int i = 0; i <= vetorBuble.Length - 1; i++)
                        {
                            Console.WriteLine(vetorBuble[i]);
                        }

                        Console.WriteLine("Tempo de ordenação: " + buble.TempoOrdenacao);
                        break;

                    case 2:
                        int[] vetorInsertion = insertion.InsertionSort(vet);

                        Console.WriteLine("=== Vetor Ordenado ===");

                        for (int i = 0; i <= vetorInsertion.Length - 1; i++)
                        {
                            Console.WriteLine(vetorInsertion[i]);
                        }

                        Console.WriteLine("Tempo de ordenação: " + insertion.TempoOrdenacao);
                        break;

                    case 3:
                        int[] vetorQuick = quick.QuickSort(vet);

                        Console.WriteLine("=== Vetor Ordenado ===");

                        for (int i = 0; i <= vetorQuick.Length - 1; i++)
                        {
                            Console.WriteLine(vetorQuick[i]);
                        }

                        Console.WriteLine("Tempo de ordenação: " + quick.TempoOrdenacao);


                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida !");
                        break;
                }

                
            } while (true);




        }

    }
}
