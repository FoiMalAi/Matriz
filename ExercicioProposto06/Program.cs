namespace ExercicioProposto06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' '); 
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(S[j]); 
                }
            }




        }
    }
}
