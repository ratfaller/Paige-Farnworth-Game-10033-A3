// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

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
            ship.Update();
            shoot.Update();
        }
    }

}
