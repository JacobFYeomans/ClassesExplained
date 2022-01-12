using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExplained
{
    class Player
    {
        // position
        public int playerX = 5; //x pos
        public int playerY = 5; //y pos
        public int playerHealth = 100; //player health
        public int playerShield = 100; //player shield

        //anything in this class is given to be player values, so you can remove a lot of the confusing syntax

        //constructor
        public Player(int initHealth)
        {
            playerX = 999;
            playerY = 999;
            playerHealth = initHealth;
            playerShield = 99;
        }
    }
}
