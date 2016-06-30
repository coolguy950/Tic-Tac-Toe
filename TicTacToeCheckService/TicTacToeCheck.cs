using System.Collections.Generic;
using System.Linq;

namespace TicTacToeCheckService
{
    public class TicTacToeCheck : ITicTacToeCheck
    {
        public IEnumerable<int> HorizontalIndexes(int input, int sideLength)
        {
            var firstIndex = GetFirstIndexInRow(input, sideLength);
            return Enumerable.Range(firstIndex, sideLength);
        }

        public IEnumerable<int> VerticalIndexes(int input, int sideLength)
        {
            int column = input - GetFirstIndexInRow(input, sideLength);
            for (int i = column; i <= GetLastColumnIndex(column, sideLength); i += sideLength)
            {
                yield return i;
            }
        }

        public IEnumerable<int> LeftDiagonalIndexes(int input, int sideLength)
        {
            if (!IsOnLeftDiagonal(input, sideLength))
            {
                yield break;
            }

            for (int i = sideLength - 1; i <= sideLength * sideLength - sideLength; i += sideLength - 1)
            {
                yield return i;
            }
        }

        public IEnumerable<int> RightDiagonalIndexes(int input, int sideLength)
        {
            if (!IsOnRightDiagonal(input, sideLength))
            {
                yield break;
            }

            for (int i = 0; i < sideLength * sideLength; i += sideLength + 1)
            {
                yield return i;
            }
        }

        public int GetCenterIndex(int sideLength)
        {
            if (sideLength % 2 == 0)
            {
                return -1;
            }

            return ((sideLength * sideLength) - 1) /2;
        }

        private static int GetFirstIndexInRow(int input, int sideLength)
        {
            int row = input/sideLength;
            int firstIndex = sideLength*row;
            return firstIndex;
        }

        private static int GetLastColumnIndex(int column, int sideLength)
        {
            int firstIndexOfLastRowIndex = (sideLength - 1) * sideLength;
            return firstIndexOfLastRowIndex + column;
        }

        private static bool IsOnRightDiagonal(int input, int sideLength)
        {
            return input % (sideLength + 1) == 0;
        }

        private static bool IsOnLeftDiagonal(int input, int sideLength)
        {
            return input % (sideLength - 1) == 0;
        }
    }
}
