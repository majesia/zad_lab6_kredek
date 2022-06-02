using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_lab6
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private int red = 0;
        private int blue = 0;
        private int brown = 0;
        private int aqua = 0;
        private int gold = 0;
        private int runTime = 0;

        private void start_button_Click(object sender, EventArgs e)
        {
           
            int number = 0;
            Random rand = new Random();
            int randomNumber = rand.Next(0, 5);
            Color color = GetColor(randomNumber);
            start_button.ForeColor = color;

            if (color == Color.Red) { ++red; number = red; }
            if (color == Color.Blue) { ++blue; number = blue; }
            if (color == Color.Brown){ ++brown; number = brown;}
            if (color == Color.Aqua) { ++aqua; number = aqua; }
            if (color == Color.Gold) { ++gold; number = gold; }

            string numberString = Convert.ToString(number) ;
            label1.Text = String.Concat(ReturnColor(color), ":", GetNumber(number));

            if (number == 10)
            {
                Picture picture = new Picture();
                picture.Show();
                red = 0;
                blue = 0;
                brown = 0;
                aqua = 0;
                gold = 0;
            }
        }

        private Color GetColor(int colorNumber)
        {
            Color color = Color.White;
            switch (colorNumber)
            {
                case 0:
                    color = Color.Red;
                    break;
                case 1:
                    color = Color.Blue;
                    break;
                case 2:
                    color = Color.Brown;
                    break;
                case 3:
                    color = Color.Aqua;
                    break;
                case 4:
                    color = Color.Gold;
                    break;
            }

            return color;
        }

        private String GetNumber(int number)
        {
            String number1;
            number1 = number.ToString();
            return number1;
        }

        private String ReturnColor(Color color)
        {
            String colorString = null;
            if (color == Color.Red) colorString = "Czerwony";
            if (color == Color.Blue) colorString = "Niebieski";
            if (color == Color.Brown) colorString = "Brązowy";
            if (color == Color.Aqua) colorString = "Morski";
            if (color == Color.Gold) colorString = "Złoty";

            return colorString;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            runTime += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            toolTip2.SetToolTip(timeButton, getTime(runTime) );
        }

        private string getTime(int time1)
        {
            string time = null;
            time = time1.ToString();

            return time;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
