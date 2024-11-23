namespace ExercicioProposto03
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
                    matriz[i,j] = int.Parse(S[j]);
                }
            }
            for (int i = 0;i < N; i++)
            {
                int maior = matriz[i,0];
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine(maior);   
            }
        }
    }
}
