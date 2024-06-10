namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int col = 3;

            int[,] matrix = new int[row, col];

            int num = 1;
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }

            Print(matrix, row, col);
        }

        static void Print(int[,] matrix, int row, int col)
        {
            for(int i=0; i<row;i++)
            {
                for (int j=0; j<col;j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }

        }
    }
}
