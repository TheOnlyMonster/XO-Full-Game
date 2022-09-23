using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XO_Full_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int P1_Counter = 1;
        static int P2_Counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool check(string m)
        {
            if (First.Content==m && Second.Content==m && Third.Content==m)
            {
                return true;
            }
            else if (Fourth.Content==m && Fifth.Content==m && Sixth.Content==m)
            {
                return true;
            }
            else if (First.Content == m && Fourth.Content == m && Seventh.Content == m)
            {
                return true;
            }
            else if (Second.Content == m && Fifth.Content == m && Eighth.Content == m)
            {
                return true;
            }
            else if (Third.Content == m && Sixth.Content == m && Nineth.Content == m)
            {
                return true;
            }
            else if (First.Content == m && Fifth.Content == m && Nineth.Content == m)
            {
                return true;
            }
            else if (Third.Content == m && Fifth.Content == m && Seventh.Content == m)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DrawCheck()
        {
            if (check("X")==false && check("O")==false && P1_Counter+P2_Counter==10)
            {
                MessageBox.Show("Draw... \n sadge :(");
                Environment.Exit(0);
            }
        }
        private string turns()
        {
            if (P1_Counter>P2_Counter)
            {
                P2_Counter++;
                return "X";
            }
            else
            {
                P1_Counter++;
                return "O";
            }
        }
        private void First_Click(object sender, RoutedEventArgs e)
        {

            if (turns()=="X")
            {
                X_Turn x = new X_Turn(First, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(First, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Second, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Second, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Third_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Third, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Third, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Fourth_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Fourth, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Fourth, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Fifth_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Fifth, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Fifth, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Sixth_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Sixth, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Sixth, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Seventh_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Seventh, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Seventh, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Eighth_Click(object sender, RoutedEventArgs e)
        {
            if (turns() == "X")
            {
                X_Turn x = new X_Turn(Eighth, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Eighth, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }

        private void Nineth_Click(object sender, RoutedEventArgs e)
        {
            if (turns()=="X")
            {
                X_Turn x = new X_Turn(Nineth, PlayerTurn);
            }
            else
            {
                O_Turn o = new O_Turn(Nineth, PlayerTurn);
            }
            if (check("X"))
            {
                MessageBox.Show("Player 1 Has Won!!");
                Environment.Exit(0);
            }
            else if (check("O"))
            {
                MessageBox.Show("Player 2 Has Won!!");
                Environment.Exit(0);
            }
            DrawCheck();
        }
    }
}
