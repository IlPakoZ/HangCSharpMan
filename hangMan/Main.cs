using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        String parola;
        public Main()
        {
            InitializeComponent();
            s = new stickMan(6);
            genWord();
            randString();
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
            wordComplexity = rand.Next(3, 9); //Il massimo è esclusivo, quindi i valori sono comunque da 3 a 8
        }

        private void initText()
        {
            word = new List<TextBox>();
            for (int i = 0; i < wordComplexity; i++)
            {
                word.Add(new TextBox());
                word[i].Size = new Size(20, 20);
                word[i].Location = new Point(1 + (i * 21), 120);
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

            for (int i = 0; i < wordComplexity; i++)
            {
                sb.Append(word[i].Text);
            }
            if (sb.ToString().ToUpper().Equals(parola))
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
            foreach (TextBox words in word)
            {
                words.Dispose();
            };
            this.Invalidate();
            backGround.Invalidate();
            s.lives = 6;
            genWord();
            randString();
            initText();
            this.Invalidate();
            backGround.Invalidate();
        }

        private void randString()
        {
            List<string> strings = new List<string>(); //è una lista operchè ho intenzione di fare altro in futuro...
            Random random = new Random();
            foreach(String parola_temp in LoadString.loadFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Insert(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Length, "//Stringhe.txt")))

            {
                if (parola_temp.Length == wordComplexity && !(parola_temp.Equals("File not found")))
                {
                    strings.Add(parola_temp);
                    
                }
            }

            if (random.Next(1, 3) == 1)
            {
                parola = strings[0];
            }
            else
            {
                parola = strings[1];
            }
        }
    }
}