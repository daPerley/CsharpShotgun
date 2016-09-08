using Shotgun.Classes;
using System;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            GameActions.sfxReload.LoadAsync();
            GameActions.sfxShoot.LoadAsync();
            GameActions.sfxShotgun.LoadAsync();
            GameActions.sfxBlock.LoadAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            PlayerActions.PlayerReload();
        }

        private void picShoot_Click(object sender, EventArgs e)
        {
            PlayerActions.PlayerShoot();
        }

        private void picBlock_Click(object sender, EventArgs e)
        {
            PlayerActions.PlayerBlock();
        }

        private void AIBulletDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
