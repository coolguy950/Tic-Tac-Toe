using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCheckService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCheckService.Tests
{
    [TestClass()]
    public class TicTacToeCheckTests
    {
        [TestMethod()]
        public void HorizontalIndexesTest()
        {
            TicTacToeCheck tic = new TicTacToeCheck();

            var result = tic.HorizontalIndexes(15, 5).ToList();
            Assert.IsTrue(result.Count == 5, $"result.Count == 5. Real : {result.Count}");
            Assert.IsTrue(result[0] == 15, "15");
            Assert.IsTrue(result[1] == 16, "16");
            Assert.IsTrue(result[2] == 17, "17");
            Assert.IsTrue(result[3] == 18, "18");
            Assert.IsTrue(result[4] == 19);

            result = tic.HorizontalIndexes(13, 5).ToList();
            Assert.IsTrue(result.Count == 5, $"result.Count == 5. Real : {result.Count}");
            Assert.IsTrue(result[0] == 10, "3");
            Assert.IsTrue(result[1] == 11, "8");
            Assert.IsTrue(result[2] == 12, "13");
            Assert.IsTrue(result[3] == 13, "18");
            Assert.IsTrue(result[4] == 14);

            result = tic.HorizontalIndexes(8, 3).ToList();
            Assert.IsTrue(result.Count == 3, $"result.Count == 8. Real : {result.Count}");
            Assert.IsTrue(result[0] == 6, "2");
            Assert.IsTrue(result[1] == 7, "5");
            Assert.IsTrue(result[2] == 8, "8");
        }

        [TestMethod()]
        public void VerticalIndexesTest()
        {
            TicTacToeCheck tic = new TicTacToeCheck();

            var result = tic.VerticalIndexes(15, 5).ToList();
            Assert.IsTrue(result.Count == 5, $"result.Count == 5. Real : {result.Count}");
            Assert.IsTrue(result[0] == 0, "0");
            Assert.IsTrue(result[1] == 5, "5");
            Assert.IsTrue(result[2] == 10, "10");
            Assert.IsTrue(result[3] == 15, "15");
            Assert.IsTrue(result[4] == 20);

            result = tic.VerticalIndexes(13, 5).ToList();
            Assert.IsTrue(result.Count == 5, $"result.Count == 5. Real : {result.Count}");
            Assert.IsTrue(result[0] == 3, "3");
            Assert.IsTrue(result[1] == 8, "8");
            Assert.IsTrue(result[2] == 13, "13");
            Assert.IsTrue(result[3] == 18, "18");
            Assert.IsTrue(result[4] == 23);

            result = tic.VerticalIndexes(8, 3).ToList();
            Assert.IsTrue(result.Count == 3, $"result.Count == 8. Real : {result.Count}");
            Assert.IsTrue(result[0] == 2, "2");
            Assert.IsTrue(result[1] == 5, "5");
            Assert.IsTrue(result[2] == 8, "8");
        }

        [TestMethod()]
        public void LeftDiagonalIndexesTest()
        {
            TicTacToeCheck tic = new TicTacToeCheck();

            var result = tic.LeftDiagonalIndexes(16, 5).ToList();
            Assert.IsTrue(result.Count == 5, $"result.Count == 5. Real : {result.Count}");
            Assert.IsTrue(result[0] == 4, "4");
            Assert.IsTrue(result[1] == 8, "8");
            Assert.IsTrue(result[2] == 12, "12");
            Assert.IsTrue(result[3] == 16, "16");
            Assert.IsTrue(result[4] == 20);

            result = tic.LeftDiagonalIndexes(6, 3).ToList();
            Assert.IsTrue(result.Count == 3, $"result.Count == 8. Real : {result.Count}");
            Assert.IsTrue(result[0] == 2, "2");
            Assert.IsTrue(result[1] == 4, "4");
            Assert.IsTrue(result[2] == 6, "6");

            var count = tic.LeftDiagonalIndexes(13, 5).Count();
            Assert.IsTrue(count == 0);

            count = tic.LeftDiagonalIndexes(3, 3).Count();
            Assert.IsTrue(count == 0);
        }

        [TestMethod()]
        public void RightDiagonalIndexesTest()
        {
            TicTacToeCheck tic = new TicTacToeCheck();

            var result = tic.RightDiagonalIndexes(6, 5).ToList();
            Assert.IsTrue(result.Count == 5, $"result.Count == 5. Real : {result.Count}");
            Assert.IsTrue(result[0] == 0, "0");
            Assert.IsTrue(result[1] == 6, "6");
            Assert.IsTrue(result[2] == 12, "12");
            Assert.IsTrue(result[3] == 18, "18");
            Assert.IsTrue(result[4] == 24);

            result = tic.RightDiagonalIndexes(8, 3).ToList();
            Assert.IsTrue(result.Count == 3, $"result.Count == 3. Real : {result.Count}");
            Assert.IsTrue(result[0] == 0, "0");
            Assert.IsTrue(result[1] == 4, "4");
            Assert.IsTrue(result[2] == 8, "8");

            var count = tic.RightDiagonalIndexes(13, 5).Count();
            Assert.IsTrue(count == 0);

            count = tic.RightDiagonalIndexes(3, 3).Count();
            Assert.IsTrue(count == 0);
        }

        [TestMethod()]
        public void GetCenterIndexTest()
        {
            TicTacToeCheck tic = new TicTacToeCheck();
            var result = tic.GetCenterIndex(5);
            Assert.IsTrue(result == 12);

            result = tic.GetCenterIndex(3);
            Assert.IsTrue(result == 4);

            result = tic.GetCenterIndex(4);
            Assert.IsTrue(result == -1);
        }
    }
}