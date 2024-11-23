namespace ExercicioResolvido01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] =  int.Parse(S[j]);
                }
            }
            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i,i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0;i < N; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (A[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Quantididade de negativos: " + cont);
        }
    }
}
