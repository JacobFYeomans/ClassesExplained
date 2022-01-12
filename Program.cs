//namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//purpose of OOP (object-oriented programming)
//

namespace ClassesExplained
{
    class Program //this is a class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes Explained:");

            Console.WriteLine("Before Classes");
            ////before classes

            ////player
            //int x = 2; //player pos x
            //int y = 2; //player pos y
            //int health = 100; //player health
            //int shield = 100; //player shield

            ////enemy
            //int enemyX = 10;
            //int enemyY = 10;

            ////enemy #2
            //int enemy2X = 15;
            //int enemy2Y = 15;

            ////can't do this ^^^^

            ////enemies (array)
            //int numEnemies = 100;
            //int[] enemyArrayX = new int[100];
            //int[] enemyArrayY = new int[100];
            //for (int i = 0; i <= numEnemies - 1; i++) //0...numEnemies-1
            //{
            //    enemyArrayX[i] = i;
            //    enemyArrayY[i] = 1;
            //    Console.WriteLine("Enemy[" + i + "]: (" + enemyArrayX[i] + "," + enemyArrayY[i] + ")");
            //    // (0,0)... (99,99)
            //}



            //Console.WriteLine("Player Pos: (" + x + " " + y + ")");
            //Console.WriteLine("Enemy Pos: (" + enemyX + " " + enemyY + ")");
            //Console.WriteLine("Enemy #2 Pos: (" + enemy2X + " " + enemy2Y + ")");


            Console.WriteLine("After Classes");

            //this is calling on the entire created class
            Player player1; //declaration (size)
            player1 = new Player(75); //instantiation (elements)
            Enemy enemy1 = new Enemy(); //declaration & instantiation

            Console.WriteLine("Player: " + player1.playerX + "," + player1.playerY);
            Console.WriteLine("Player Health&Shield: " + player1.playerHealth + "," + player1.playerShield);

            player1.playerX = 20;
            player1.playerY = 15;

            Console.WriteLine("Player: " + player1.playerX + "," + player1.playerY);
            Console.WriteLine("Player Health&Shield: " + player1.playerHealth + "," + player1.playerShield);

            //same thing w/ enemies

            Console.WriteLine("Enemy 1: " + enemy1.enemyX + "," + enemy1.enemyY);

            enemy1.enemyX = 50;
            enemy1.enemyY = 50;

            Console.WriteLine("Enemy 1: " + enemy1.enemyX + "," + enemy1.enemyY);

            //personal testing

            TestingClass test = new TestingClass();

            for (int i = 0; i <= 6; i++)
            {
                //i can assign array values to an array that is declared and instantiated inside another C# file.
                test.array[i] = i;
                Console.WriteLine("The current values of the array is " + test.array[i]);
            }

            //I can split a string from another class within this C# file
            test.splitSentence = test.sentence.Split(';');

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(test.splitSentence[i]);
            }

            Console.ReadKey(true);
        }
    }
}
