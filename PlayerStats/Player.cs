using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore = 0f;
        private int playedGames;
        private int wonGames;
        private string name;


        public Player (string name)
        {
            this.name = name;
            
        }

        public float HighScore
        {
            get 
            { 
                return highScore; 
            }
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
        public string Name { get => name; }

        public float WinRate 
        { 
            get
            { if(playedGames == 0)
                {
                    return 0f;
                }
                else
                {
                    return GetWinRate(wonGames, playedGames);
                }
            }  
        }

        public float GetWinRate(int wonGames, int playedGames)
        {
            float winRate;
            float wins = Convert.ToSingle(wonGames);
            float numGames = Convert.ToSingle(playedGames);
            winRate = wins / numGames;
            return winRate;
        }

        public void PlayGame(bool win)
        {
            
            playedGames++;
            if (win == true)
            {
                wonGames++;
            }
        }
    }
}