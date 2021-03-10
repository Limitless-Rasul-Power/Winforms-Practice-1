using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsT1
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        PictureBox pictureBox = new PictureBox
        {
            Image = Image.FromFile("../../Photos/CopCar.png")
        };
        public Form1()
        {
            InitializeComponent();
            Cursor = new Cursor(((Bitmap)pictureBox.Image).GetHicon());            
        }

        private void btnCatchMeIfYouCan_MouseHover(object sender, EventArgs e)
        {
            btnCatchMeIfYouCan.Location = new Point(random.Next(Width - 300), random.Next(Height - 200));
        }

        private void btnCatchMeIfYouCan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It isn't count, i am resting", "#Catch me if you can");
            btnCatchMeIfYouCan.Click += btnCatchMeIfYouCan_MouseHover;
        }
    }
}
