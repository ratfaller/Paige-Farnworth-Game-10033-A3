using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D;

public class Enemy
{
    public void Setup()
    {

    }

    public void Update()
    {

        DrawAlien();
        
    }

    public void DrawAlien()
    {
        for (int i = 0; i < 3; i++)
        {
            int x = i * 300;
            Draw.SetFillColor(Color.Red);
            Draw.Circle(x + 100, 100, 50);
            Draw.SetFillColor(Color.Black);
            Draw.Circle(x + 120, 90, 10);
            Draw.Circle(x + 80, 90, 10);
            Draw.Rectangle(x + 80, 120, 30, 10);

        }
        
    }

}
