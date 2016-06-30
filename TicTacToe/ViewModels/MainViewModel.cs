using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using TicTacToe.Annotations;
using TicTacToe.Models;
using TicTacToeCheckService;

namespace TicTacToe.ViewModels
{
    public enum FieldSize
    {
        [Display(Name = "3x3")]
        Field3x3 = 9,
        [Display(Name = "4x4")]
        Field4x4 = 16,
        [Display(Name = "5x5")]
        FIeld5x5 = 25,
    }

    public class MainViewModel
    {
        private bool _isGameOver = false;

        private readonly ITicTacToeCheck _ticTacToeCheck;

        public MainViewModel(ITicTacToeCheck ticTacToeCheck)
        {
            _ticTacToeCheck = ticTacToeCheck;
            NewGame();
        }
       
        public virtual FieldSize FieldSize { get; set; } = FieldSize.Field3x3;

        public virtual State CurrentPlayer { get; set; }

        public virtual ObservableCollection<Cell> Field { get; set; }

        public virtual IMessageBoxService MessageBoxService => null;

        protected void OnFieldSizeChanged()
        {
            NewGame();
        }

        public void NewGame()
        {
            CreateField();
            _isGameOver = false;
            CurrentPlayer = State.Player1;
        }

        private void CreateField()
        {
            Field = new ObservableCollection<Cell>();
            for (int i = 0; i < (int)FieldSize; i++)
            {
                Field.Add(ViewModelSource.Create<Cell>());
            }
        }

        public void OnMove(Cell cell)
        {
            cell.State = CurrentPlayer;
            CheckField(Field.IndexOf(cell));
            if (_isGameOver)
            {
                return;
            }

            CurrentPlayer = CurrentPlayer == State.Player1 ? State.Player2 : State.Player1;
        }

        public bool CanOnMove(Cell cell)
        {
            return !_isGameOver && cell?.State == State.None;
        }

        public void CheckField(int cellIndex)
        {
            if (IsDiagonalWin(cellIndex) || IsVerticalWin(cellIndex) || IsHorizontalWin(cellIndex))
            {
                return;
            }

            if (IsTie(cellIndex))
            {
                _isGameOver = true;
                MessageBoxService.Show("Tie!");
            }
        }

        public bool IsDiagonalWin(int cellIndex)
        {
            var leftIndexes = _ticTacToeCheck.LeftDiagonalIndexes(cellIndex, (int) Math.Sqrt((int) FieldSize)).ToList();
            if (leftIndexes.Count != 0 && leftIndexes.All(index => Field[index].State == CurrentPlayer))
            {
                OnPlayerWin(leftIndexes);
                return true;
            }

            var rightIndexes = _ticTacToeCheck.RightDiagonalIndexes(cellIndex, (int)Math.Sqrt((int)FieldSize)).ToList();
            if (rightIndexes.Count != 0 && rightIndexes.All(index => Field[index].State == CurrentPlayer))
            {
                OnPlayerWin(rightIndexes);
                return true;
            }

            return false;
        }

        public bool IsVerticalWin(int cellIndex)
        {
            var indexes = _ticTacToeCheck.VerticalIndexes(cellIndex, (int)Math.Sqrt((int)FieldSize)).ToList();
            if (indexes.Count != 0 && indexes.All(index => Field[index].State == CurrentPlayer))
            {
                OnPlayerWin(indexes);
                return true;
            }

            return false;
        }

        public bool IsHorizontalWin(int cellIndex)
        {
            var indexes = _ticTacToeCheck.HorizontalIndexes(cellIndex, (int)Math.Sqrt((int)FieldSize)).ToList();
            if (indexes.Count != 0 && indexes.All(index => Field[index].State == CurrentPlayer))
            {
                OnPlayerWin(indexes);
                return true;
            }

            return false;
        }

        private void OnPlayerWin(List<int> indexes)
        {
            _isGameOver = true;
            indexes.ForEach(index => Field[index].IsWinningCell = true);

            MessageBoxService.Show($"{CurrentPlayer} wins!");
        }

        public bool IsTie(int cellIndex)
        {
            return Field.All(cell => cell.State != State.None);
        }
    }
}
