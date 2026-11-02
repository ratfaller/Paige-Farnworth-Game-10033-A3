using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MohawkGame2D
{
    public class Shoot
    {
        float y = 480;
        float x;
        float speed = 200;
        float bulletSpeed = 0;

        public void Setup()
        {

        }
        public void Update()
        {

            DrawBullet();

            if(Input.IsKeyboardKeyDown(KeyboardKey.Right))
            {
                x += speed * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
            {
                x -= speed * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyPressed(KeyboardKey.Up))
            {
                bulletSpeed = -100;
            }

            y += bulletSpeed * Time.DeltaTime;

            
        }
        public void DrawBullet()
        {
            Draw.SetFillColor(Color.Green);
            Draw.Circle(x + 50, y, 10);
        }
    }
}
