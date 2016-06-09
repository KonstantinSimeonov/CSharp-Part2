namespace _3.Lover_of_3
{
    using System;
    using System.Linq;

    class LoverOf3
    {
        static bool IsInsideMatrix (int row, int col, bool[,] matrix)
        {

            bool rowIsInField = 0 <= row && row < matrix.GetLength(0);
            bool colIsInField = 0 <= col && col < matrix.GetLength(1);

            return rowIsInField && colIsInField;
        }
        static void Main(string[] args)
        {
            var fieldsize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rowsCount = fieldsize[0];
            var colsCount = fieldsize[1];

            var field = new bool[rowsCount, colsCount];

            var n = int.Parse(Console.ReadLine());

            long result = 0;
            int row = rowsCount - 1;
            int col = 0;
            int currentCell = 0;

            for (int i = 0; i < n; i++)
            {
                var move = Console.ReadLine().Split(' ');
                var direction = move[0];
                var repeats = int.Parse(move[1]);

                var deltaRow = direction.Contains("U") ? -1 : 1;
                var deltaCol = direction.Contains("L") ? -1 : 1;

                for (int j = 0; j < repeats - 1; j++)
                {
                    if (IsInsideMatrix(row + deltaRow, col + deltaCol, field))
                    {
                        //go to the cell
                        row += deltaRow;
                        col += deltaCol;

                        if (deltaRow == -1 && deltaCol == 1)
                        {
                            currentCell += 6;
                        }
                        else if (deltaRow == 1 && deltaCol == -1)
                        {
                            currentCell -= 6;
                        }

                        //if not collected
                        if (!field[row, col])
                        {
                            //result += col * 3 + (rowsCount - 1 - row) * 3;
                            result += currentCell;
                            field[row, col] = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
