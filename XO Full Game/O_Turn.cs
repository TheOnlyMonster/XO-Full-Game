using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace XO_Full_Game
{
    internal class O_Turn:IGame
    {

        Button b;
        Label l;
        public O_Turn()
        {
            string s = "O";
        }
        public O_Turn(Button b, Label l)
        {
            this.b = b;
            this.l = l;
            Player();
        }
        public void Player()
        {

            b.IsEnabled = false;
            b.Content = "O";
            l.Content = "Player 1, choose your field:";
        }
    }
}
