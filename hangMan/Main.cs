using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangMan
{
    public partial class Main : Form
    {
        stickMan s; 
        int wordComplexity;
        List<TextBox> word;
        String tempWord = "cacca"; //that rude
        
        public Main()
        {
            InitializeComponent();
            s = new stickMan(6); //initiate stickMan instance with 6 lives
            genWord();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            initText();
        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (s.lives)
            {
                case 6:
                    s.drawHang(g);
                    break;
                case 5:
                    s.drawHang(g);
                    s.drawHead(g);
                    break;
                case 4:
                    s.drawHang(g);
                    s.drawHead(g);
                    s.drawBody(g);
                    break;
                case 3:
                    s.drawHang(g);
                    s.drawHead(g);
                    s.drawBody(g);
                    s.drawRightArm(g);
                    break;
                case 2:
                    s.drawHang(g);
                    s.drawHead(g);
                    s.drawBody(g);
                    s.drawRightArm(g);
                    s.drawLeftArm(g);
                    break;
                case 1:
                    s.drawHang(g);
                    s.drawHead(g);
                    s.drawBody(g);
                    s.drawRightArm(g);
                    s.drawLeftArm(g);
                    s.drawRightLeg(g);
                    break;
                case 0:
                    s.drawHang(g);
                    s.drawHead(g);
                    s.drawBody(g);
                    s.drawRightArm(g);
                    s.drawLeftArm(g);
                    s.drawRightLeg(g);
                    s.drawLeftLeg(g);
                    defeat();
                    break;
            }

        }

        private void check_Click(object sender, EventArgs e)
        {
            checkString();
            backGround.Invalidate();
        }

        private void genWord()
        {
            Random rand = new Random();
            wordComplexity = rand.Next(3, 8);
        }

        private void initText()
        {
            word = new List<TextBox>();
            for (int i = 0; i < wordComplexity; i++)
            {
                word.Add(new TextBox());
                word[i].Size = new Size(20, 20);
                word[i].Location = new Point(10 + (i * 21), 120);
                word[i].Visible = true;
                word[i].MaxLength = 1;
                this.Controls.Add(word[i]);
            }
        }

        private void defeat()
        {
            MessageBox.Show("Fai schifo");
            reset();
        }

        private void victory()
        {
            MessageBox.Show("Brav");
            reset();
        }

        private void checkString()
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < wordComplexity; i++)
            {
                 sb.Append(word[i].Text);
            }

            if (sb.ToString().Equals(tempWord))
            {
                victory();
            }
            else
            {
                s.lives--;
            }
        }

        private void reset()
        {
            word = null;
            s.lives = 6;
            genWord();
            initText();
            this.Invalidate();
            backGround.Invalidate();
        }


    }
}
