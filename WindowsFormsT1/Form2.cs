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
    public partial class Form2 : Form
    {
        private readonly PictureBox pictureBox = new PictureBox();
        private readonly Timer timer = new Timer();

        public Form2()
        {
            InitializeComponent();
            Controls.Add(pictureBox);            

            lblWelcome.ForeColor = ColorTranslator.FromHtml("#99C24D");
            SetTransparentText(lblWelcome, "Welcome");
            btnBaku_Click(btnBaku, new EventArgs());
        }

        private void SetVisibilityToLabelAndButtons(bool flag)
        {
            lblWelcome.Visible = flag;
            btnBaku.Visible = flag;
            btnLondon.Visible = flag;
        }

        private void SetPictureBoxWidthAndHeightToWindowWidthAndHeight()
        {
            pictureBox.Width = Width;
            pictureBox.Height = Height;
        }

        private void SetBackgroundImage(string path)
        {
            SetVisibilityToLabelAndButtons(false);
            SetPictureBoxWidthAndHeightToWindowWidthAndHeight();
            pictureBox.BackgroundImage = new Bitmap(path);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private  void SetTransparentText(Label label, string text)
        {
            var pos = PointToScreen(label.Location);
            pos = pictureBox.PointToClient(pos);
            label.Parent = pictureBox;
            label.Location = pos;
            label.BackColor = Color.Transparent;
            label.Visible = true;
            label.Text = text;
        }
        private void btnBaku_Click(object sender, EventArgs e)
        {            
            SetBackgroundImage("../../Photos/Huseyn Derya.jpg");
            btnBaku.BackColor = Color.GreenYellow;
            btnLondon.BackColor = Color.White;

            timer.Start();            
            timer.Tick += Timer_Tick_For_Baku;

            SetVisibilityToLabelAndButtons(true);
        }

        private void btnLondon_Click(object sender, EventArgs e)
        {
            SetBackgroundImage("../../Photos/2pac.jpg");
            btnBaku.BackColor = Color.White;
            btnLondon.BackColor = Color.GreenYellow;


            timer.Start();
            timer.Tick += Timer_Tick_For_London;

            SetVisibilityToLabelAndButtons(true);
        }

        private void Timer_Tick_For_London(object sender, EventArgs e)
        {
            Text = $"{DateTime.Now.AddHours(4):F},  {"Best Rapper Picture in London => 2pac Shakur => Greatest of all Time"}";
        }

        private void Timer_Tick_For_Baku(object sender, EventArgs e)
        {
            Text = $"{DateTime.Now:F},  {"Best Azerbaijan Rapper => Hüseyn Dərya => Greatest of all Time"}";
        }

    }
}
