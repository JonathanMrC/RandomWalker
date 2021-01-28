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
            switch(r.Next(0, 4))
            {
                case 0:
                    X-=10;
                    if (x <= radio) x = limitsX - radio;
                    break;
                case 3:
                    X+= 10;
                    if (x > limitsX-radio) x = radio;
                    break;
                case 1:
                    Y-= 10;
                    if (y <= radio) y = limitsY - radio;
                    break;
                case 2:
                    Y+= 10;
                    if (y > limitsY-radio) x = radio;
                    break;
                default:
                    X = limitsX/2;
                    Y = limitsY/2;
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
