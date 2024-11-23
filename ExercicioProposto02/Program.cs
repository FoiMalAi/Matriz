using System.Runtime.Serialization;

namespace ExercicioProposto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i,j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + matriz[i,j];
                }

                Console.WriteLine(soma);
            }         
        }
    }
}
