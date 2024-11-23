namespace ExercicioProposto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(S[j]);
                }
            }
            int somaD = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    somaD += matriz[i, j];
                }
            }
            Console.WriteLine(somaD);
        }

    }
}
