using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace hangMan
{
    class stickMan
    {
        public int lives;

        public stickMan(int lives)
        {
            this.lives = lives;
        }

        public void drawHang(Graphics g)
        {
            g.DrawLine(Pens.Yellow, new Point(50, 10), new Point(50, 80));
        }

        public void drawHead(Graphics g)
        {
            g.DrawEllipse(Pens.Black, new Rectangle(25, 80, 50, 50));
        }

        public void drawBody(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 130), new Point(50, 200));
        }

        public void drawRightArm(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 130), new Point(80, 160));
        }

        public void drawLeftArm(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 130), new Point(20, 160));
        }

        public void drawRightLeg(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 200), new Point(80, 230));
        }

        public void drawLeftLeg(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 200), new Point(20, 230));
        }
    }

}
