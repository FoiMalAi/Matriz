namespace ExercicioProposto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] S = Console.ReadLine().Split(' ');
            M = int.Parse(S[0]);
            N = int.Parse(S[1]);

            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++) // Leitura de dados matriz A
            {
                S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(S[j]);
                }
            }

            int[,] B = new int[M, N]; // Leitura de dados matriz B
            for (int i = 0;i < M; i++)
            {
                S = Console.ReadLine().Split(' ');
                for (int j = 0;j < N; j++)
                {
                    B[i,j] = int.Parse(S[j]);
                }
            }

            int[,] C = new int[M, N];// Leitura de dados matriz C, ja com as somas
            for (int i = 0; i < M; i++)
            {                
                for (int j = 0; j < N; j++)
                {
                    C[i,j] = A[i,j] + B[i,j];
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                   Console.Write(C[i,j] + " ");
                }
                Console.WriteLine();
            }





        }
    }
}
