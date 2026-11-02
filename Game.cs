// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Ship ship = new Ship();
        Shoot shoot = new Shoot();

        Enemy enemy = new Enemy();
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Sludge Invaders");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0, 0, 0);
            Stars();
            ship.Update();
            shoot.Update();
            enemy.Update();
            enemy.DrawAlien();
            
        }


        public void Stars()
        { 
            Draw.SetFillColor(Color.White);
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x, 20, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x - 50, 70, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x, 120, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x - 50, 170, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x, 220, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x - 50, 270, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x, 320, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x - 50, 370, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x, 420, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x - 50, 470, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x, 520, 5);
            }
            for (int i = 0; i < 10; i++)
            {
                int x = i * 100;
                Draw.Circle(x - 50, 570, 5);
            }

        }
    }

}
