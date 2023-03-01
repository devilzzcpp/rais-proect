using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace cryptograph
{
    public partial class Form1 : Form
    {
        public class candle
        {
            public int max;
            public int open;
            public int close;
            public int min;
            public int color;
            public int x;
            public int y;
            Graphics g;
            public int level;
            public candle (Graphics g1,int level1)
            { 
                g = g1;
                level = level1;
            }
            public int draw(int wPen )
            {
                open = 100;
                close = 220;
                x = 100;
                int y0 = 100;
                y = level - y0 - Math.Abs(open - close);
                min = 85;
                max = 225;
                Color colorCandle;
                if (close > open) colorCandle = Color.Green;
                else colorCandle = Color.Red;
                Pen myWind = new Pen(colorCandle, wPen);
                SolidBrush myCorp = new SolidBrush(colorCandle);
                g.FillRectangle(myCorp, x, y, 30, Math.Abs(open - close));
                g.DrawLine(myWind, x+15, level - min, x+15, level - max);
                


                return 0;
            }


        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string path = "/Users/user/Documents/1.txt";
            StreamReader reader = new StreamReader(path);
            
                //string? line;
                /*
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    
                }
                */
            string line;
            line=reader.ReadLine();
            line = reader.ReadLine();
            MessageBox.Show(line);
            string[] open = line.Split('@');
            MessageBox.Show(open[0]);
            
            Graphics g = pictureBox1.CreateGraphics();
            candle cnd1 = new candle(g, pictureBox1.Height);
            cnd1.draw(2);

          
        }
    }
}