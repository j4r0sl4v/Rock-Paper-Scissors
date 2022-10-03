using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnPnS
{
    public class Player
    {
        private Random random = new Random();

        public int Money { get; internal set; }
        public Player(int money)
        {
            Money = money;
        }

        public PlayerState GetState()
        {
            int value = random.Next(0, 3);
            return (PlayerState)value;
        }

        public void Win()
        {
            Money++;
        }

        public void Lose()
        {
            Money--;
        }
    }

    public enum PlayerState
    {
        Kámen,
        Nůžky,
        Papír
    }
}
