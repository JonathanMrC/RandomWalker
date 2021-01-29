using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWalker
{
    public class Walker
    {
        float x, y;
        float limitsX, limitsY;
        int radio;

        public Walker(float limit_X, float limit_Y, int radio_)
        {
            limitsX = limit_X;
            limitsY = limit_Y;
            x = limitsX / 2;
            y = limitsY / 2;
            radio = radio_;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float LimitsX { get => limitsX; set => limitsX = value; }
        public float LimitY { get => limitsY; set => limitsY = value; }
        public int Radio { get => radio; set => radio = value; }

        public void Walk(Random r)
        {
            switch(r.Next(1, 5))
            {
                case 1:
                    {
                        X -= 10;
                        if (X < radio) X = limitsX - radio;
                    }
                    break;
                case 2:
                    {
                        X += 10;
                        if (X > (limitsX - radio)) X = radio;
                    }
                    break;
                case 3:
                    {
                        Y -= 10;
                        if (Y < radio) Y = limitsY - radio;
                    }
                    break;
                case 4:
                    {
                        Y += 10;
                        if (Y > (limitsY - radio)) Y = radio;
                    }
                    break;
                default:
                    {
                        X = radio;
                        Y = radio;
                    }
                    break;
            }
        }

        public void IncreaseRadio(int increase)
        {
            radio += increase;
            if (radio > limitsX / 20) radio = int.Parse(""+limitsX / 10);
        }

        public void DecreaseRadio(int increase)
        {
            radio -= increase;
            if (radio < 5) radio = 2;
        }

    }
}
