using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int speed = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (player.Location.X - speed > 0)
                        player.Location = new Point(player.Location.X - speed, player.Location.Y);
                    break;
                case Keys.W:
                    if (player.Location.Y - speed > 0)
                        player.Location = new Point(player.Location.X, player.Location.Y - speed);
                    break;
                case Keys.S:
                    if (player.Location.Y + speed < this.ClientSize.Height - player.Size.Height)
                        player.Location = new Point(player.Location.X, player.Location.Y + speed);
                    break;
                case Keys.D:
                    if (player.Location.X + speed < this.ClientSize.Width - player.Size.Width)
                        player.Location = new Point(player.Location.X + speed, player.Location.Y);
                    break;
            }
        }
    }
}
