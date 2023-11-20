using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW1
{
    public partial class Form1 : Form
    {
        int colorIndex = 0;
        Color[] colors = { Color.Red, Color.Yellow, Color.Green };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorIndex > 2) colorIndex = 0;
            Random rand = new();
            button1.Location = new Point(rand.Next(0, this.ClientSize.Width),//Изменение положения кнопки
                                         rand.Next(0, this.ClientSize.Height));
            this.Location = new Point(rand.Next(Screen.PrimaryScreen.Bounds.Width - this.Width),//Изменение положения окна
                                      rand.Next(Screen.PrimaryScreen.Bounds.Height - this.Height));
            button1.BackColor = colors[colorIndex];
            colorIndex++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
