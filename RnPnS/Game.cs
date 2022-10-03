using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace RnPnS
{
    class Game
    {
        private Timer timer;
        public Player Player1 { get; }
        public Player Player2 { get; }

        public Game(int money)
        {
            Player1 = new Player(money);
            Player2 = new Player(money);
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var p1 = Player1.GetState();
            var p2 = Player2.GetState();

            if (p1 != p2)
            {
                if(p1 == PlayerState.Kámen)
                {
                    if(p2 == PlayerState.Nůžky)
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                    else
                    {
                        Player1.Lose();
                        Player2.Lose();
                    }
                }
                else if(p1 == PlayerState.Nůžky)
                {
                    if(p2 == PlayerState.Kámen)
                    {
                        Player1.Lose();
                        Player2.Win();
                    }
                    else
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                }
                else
                {
                    if(p2 == PlayerState.Nůžky)
                    {
                        Player1.Lose();
                        Player2.Win();
                    }
                    else
                    {
                        Player1.Win();
                        Player2.Lose();
                    }
                }
            }
            
        }

        public void Start()
        {
            timer.Start();
        }
    }
}
