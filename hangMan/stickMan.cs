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
        // Declaration ---------------------------------------------------------------------------------
        public int sLifes; //Guessing attempts left.
        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// stickMan class constructor, sets the value of the public integer "sLifes" based on the parameter "sLifes", making it global.
        /// </summary>
        /// <param name="sLifes"></param>
        public stickMan(int sLifes)
        {
            this.sLifes = sLifes;
        }

        //This region contains all the methods that handle the Hangman's drawing process.
        #region Hangman's Drawing methods region.

        /// <summary>
        /// Draws the Hangman's hang on the pictureBox backGround.
        /// </summary>
        /// <param name="g"></param>
        public void drawHang(Graphics g)
        {
            g.DrawLine(Pens.Yellow, new Point(50, 10), new Point(50, 80));
        }

        /// <summary>
        /// Draws the Hangman's head on the pictureBox backGround.
        /// </summary>
        /// <param name="g"></param>
        public void drawHead(Graphics g)
        {
            g.DrawEllipse(Pens.Black, new Rectangle(25, 80, 50, 50));
        }

        /// <summary>
        /// Draws the Hangman's body on the pictureBox backGround.
        /// </summary>
        /// <param name="g"></param>
        public void drawBody(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 130), new Point(50, 200));
        }

        /// <summary>
        /// Draws the Hangman's right arm on the pictureBox backGround.
        /// </summary>
        /// <param name="g"></param>
        public void drawRightArm(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 130), new Point(80, 160));
        }

        /// <summary>
        /// Draws the Hangman's left arm on the pictureBox backGround. 
        /// </summary>
        /// <param name="g"></param>
        public void drawLeftArm(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 130), new Point(20, 160));
        }

        /// <summary>
        /// Draws the Hangman's right leg on the pictureBox backGround.
        /// </summary>
        /// <param name="g"></param>
        public void drawRightLeg(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 200), new Point(80, 230));
        }

        /// <summary>
        /// Draws the Hangman's left leg on the pictureBox backGround.
        /// </summary>
        /// <param name="g"></param>
        public void drawLeftLeg(Graphics g)
        {
            g.DrawLine(Pens.Black, new Point(50, 200), new Point(20, 230));
        }
        #endregion
    }

}
