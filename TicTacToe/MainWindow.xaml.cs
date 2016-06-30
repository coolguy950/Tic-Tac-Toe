using System.Windows;
using DevExpress.Mvvm.POCO;
using TicTacToe.ViewModels;
using TicTacToeCheckService;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public bool IsPlayer1 = true;
        //public bool IsGameOver = false;
        //public int GamesPlayed = 0;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModelSource.Create(() => new MainViewModel(new TicTacToeCheck()));
        }

        //private void OnNewGame()
        //{
        //    button1.Content = string.Empty;
        //    button1.IsEnabled = true;
        //    button2.Content = string.Empty;
        //    button2.IsEnabled = true;
        //    button3.Content = string.Empty;
        //    button3.IsEnabled = true;
        //    button4.Content = string.Empty;
        //    button4.IsEnabled = true;
        //    button5.Content = string.Empty;
        //    button5.IsEnabled = true;
        //    button6.Content = string.Empty;
        //    button6.IsEnabled = true;
        //    button7.Content = string.Empty;
        //    button7.IsEnabled = true;
        //    button8.Content = string.Empty;
        //    button8.IsEnabled = true;
        //    button9.Content = string.Empty;
        //    button9.IsEnabled = true;

        //    IsPlayer1 = true;
        //    IsGameOver = false;
        //    gamesFinishedText.Text = "Games Finished: " + GamesPlayed.ToString();
        //}

        //public void CheckIfWin()
        //{
        //    CheckPlayer(IsPlayer1 ? "X" : "O");
        //    CheckTie();

        //    if (IsGameOver)
        //    {
        //        GamesPlayed++;
        //        OnNewGame();
        //    }
        //}

        //private void CheckTie()
        //{
        //    if (button1.Content != string.Empty && button2.Content != string.Empty && button3.Content != string.Empty && button4.Content != string.Empty &&
        //        button5.Content != string.Empty && button6.Content != string.Empty && button7.Content != string.Empty && button8.Content != string.Empty &&
        //        button9.Content != string.Empty)
        //    {
        //        MessageBox.Show("Tie!");
        //        IsGameOver = true;
        //    }
        //}

        //private void CheckPlayer(string symbol)
        //{
        //    if (CheckHorizontalWins(symbol) || CheckVerticalWins(symbol) || CheckDiagonalWins(symbol))
        //    {
        //        MessageBox.Show($"Player {(symbol == "X" ? 1 : 2)} wins!");
        //        IsGameOver = true;
        //    }
        //}


        //private bool CheckDiagonalWins(string symbol)
        //{
        //    if (button5.Content != symbol)
        //    {
        //        return false;
        //    }

        //    if (button1.Content == symbol && button9.Content == symbol)
        //    {
        //        return true;
        //    }

        //    if (button3.Content == symbol && button7.Content == symbol)
        //    {
        //        return true;
        //    }

        //    return false;
        //}  

        //private bool CheckHorizontalWins(string symbol)
        //{
        //    if (button1.Content == symbol && button2.Content == symbol && button3.Content == symbol)
        //    {
        //        return true;
        //    }

        //    if (button4.Content == symbol && button5.Content == symbol && button6.Content == symbol)
        //    {
        //        return true;
        //    }

        //    if (button7.Content == symbol && button8.Content == symbol && button9.Content == symbol)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //private bool CheckVerticalWins(string symbol)
        //{
        //    if (button1.Content == symbol && button4.Content == symbol && button7.Content == symbol)
        //    {
        //        return true;
        //    }

        //    if (button2.Content == symbol && button5.Content == symbol && button8.Content == symbol)
        //    {
        //        return true;
        //    }

        //    if (button3.Content == symbol && button6.Content == symbol && button9.Content == symbol)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //private void OnMove(Button btn)
        //{
        //    btn.Content = IsPlayer1 ? "X" : "O";

        //    btn.IsEnabled = false;

        //    CheckIfWin();

        //    IsPlayer1 = !IsPlayer1;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button1);
        //}
      
        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button2);
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button3);
        //}

        //private void Button_Click_3(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button4);
        //}

        //private void Button_Click_4(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button5);
        //}

        //private void Button_Click_5(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button6);
        //}

        //private void Button_Click_6(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button7);
        //}

        //private void Button_Click_7(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button8);
        //}

        //private void Button_Click_8(object sender, RoutedEventArgs e)
        //{
        //    OnMove(button9);
        //}

        //private void Button_Click_9(object sender, RoutedEventArgs e)
        //{
        //    OnNewGame();
        //}
    }
}
