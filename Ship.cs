using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Ship
    {
        float x;
        float speed = 200;
        public void Setup()
        {
            x = 350;
        }

        public void Update()
        {
            DrawShip();

            if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
            {
                x += speed * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
            {
                x -= speed * Time.DeltaTime;
            }
        }

        public void DrawShip()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Green);
            Draw.Rectangle(x, 500, 100, 50);
            Draw.Rectangle(x + 40, 480, 20, 30);
        }
    }
}

