using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Spagoolimans
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            /*TODO
            meme

             */
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmGameMain game = new frmGameMain();
            game.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer mainSong = new System.Media.SoundPlayer();

            mainSong.SoundLocation = "pizzapie.wav";
            mainSong.Play();

            
        }
    }
}
