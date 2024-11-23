using System.Runtime.Serialization;

namespace ExercicioResolvido02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;

            string[] S = Console.ReadLine().Split(' ');
            M = int.Parse(S[0]);
            N = int.Parse(S[1]);

            int[,] A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(S[j]);
                }
            }
            
            int[] vet = new int[M];
            
            for (int i = 0; i < M; i++)
            {
                int somaL = 0;
                for (int j = 0;j < N; j++)
                {
                    somaL += somaL + A[i,j]; 
                }
                vet[i] = somaL;
            }

            for (int i = 0;i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadLine();
        }
    }
}
