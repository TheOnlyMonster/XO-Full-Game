using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace XO_Full_Game
{
    internal class X_Turn:IGame
    {
        Button a;
        Label l;
        public X_Turn()
        {
            string s = "X";
        }
        public X_Turn(Button a,Label l)
        {
            this.a = a;
            this.l = l;
            Player();
        }
        public void Player()
        {
            
            a.IsEnabled = false;
            a.Content = "X";
            l.Content = "Player 2, choose your field:";
        }
    }
}
