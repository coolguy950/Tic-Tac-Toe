using System.Collections.Generic;

namespace TicTacToeCheckService
{
    public interface ITicTacToeCheck
    {
        IEnumerable<int> HorizontalIndexes(int input, int sideLength);

        IEnumerable<int> VerticalIndexes(int input, int sideLength);

        IEnumerable<int> LeftDiagonalIndexes(int input, int sideLength);

        IEnumerable<int> RightDiagonalIndexes(int input, int sideLength);

        int GetCenterIndex(int fieldSize);
    }
}
