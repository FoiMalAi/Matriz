namespace ExercicioProposto01
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

            //coleta de dados da matriz
            for (int i = 0; i < M; i++)
            {
                S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(S[j]);
                }
            }

            //valores negativos

            Console.WriteLine("Valores Negativos: ");

            for (int i = 0;i < M; i++)
            {
                
                for (int j = 0;j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        Console.WriteLine(A[i, j]);
                    } 
                }
            }            
        }
    }
}
