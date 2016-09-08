using System.Media;
using System.Linq;
using System.Windows.Forms;

namespace Shotgun.Classes
{
    public class GameActions
    {
        static Form1 shotgunGame = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public static SoundPlayer sfxReload = new SoundPlayer(Properties.Resources.Reload);
        public static SoundPlayer sfxShoot = new SoundPlayer(Properties.Resources.Shoot);
        public static SoundPlayer sfxShotgun = new SoundPlayer(Properties.Resources.Shotgun);
        public static SoundPlayer sfxBlock = new SoundPlayer(Properties.Resources.Block);

        public static string aiAction = "ACTION";
        public static string playerAction = "ACTION";

        public static void AiReload()
        {
            aiAction = "RELOAD";
            sfxReload.Play();
            AiLabelsUpdate();

            if (PlayerActions.playerReload)
            {
                PlayerReload();
            }
            else if (PlayerActions.playerShoot)
            {
                PlayerShoot();
                WinOrLoss.WinRegular();
            }
            else if (PlayerActions.playerShotgun)
            {
                PlayerShotgun();
                WinOrLoss.WinShotgun();
            }
            else if (PlayerActions.playerBlock)
            {
                PlayerBlock();
            }
        }

        public static void AiShoot() //Porblem below in this method
        {
            aiAction = "SHOOT";  
            sfxShoot.Play(); // Won't play when application is running but works fine when there's a breakpoint infront of it 
            AiLabelsUpdate();

            if (PlayerActions.playerReload)
            {
                PlayerReload();
                WinOrLoss.LossRegular();
            }
            else if (PlayerActions.playerShoot)
            {
                PlayerShoot();
                WinOrLoss.Tie();
            }
            else if (PlayerActions.playerShotgun)
            {
                PlayerShotgun();
                WinOrLoss.WinShotgun();
            }
            else if (PlayerActions.playerBlock)
            {
                sfxBlock.Play();
                PlayerBlock();
            }
        }

        public static void AiShotgun()
        {
            aiAction = "SHOTGUN!";
            sfxShotgun.Play();
            AiLabelsUpdate();

            if (PlayerActions.playerShotgun)
            {
                PlayerShotgun();
                WinOrLoss.TieShotgun();
            }
            else
            {
                WinOrLoss.LossShotgun();
            }
        }

        public static void AiBlock()
        {
            aiAction = "BLOCK";
            AiLabelsUpdate();

            if (PlayerActions.playerReload)
            {
                PlayerReload();
            }
            else if (PlayerActions.playerShoot)
            {
                PlayerShoot();
                sfxBlock.Play();
            }
            else if (PlayerActions.playerShotgun)
            {
                PlayerShotgun();
                WinOrLoss.WinShotgun();
            }
            else if (PlayerActions.playerBlock)
            {
                PlayerBlock();
            }
        }

        public static void PlayerReload()
        {
            sfxReload.Play();
            PlayerActions.playerReload = false;
            playerAction = "RELOAD";
            PlayerLabelsUpdate();
        }

        public static void PlayerShoot()
        {
            sfxShoot.Play();
            --PlayerActions.bulletCount;
            PlayerActions.playerShoot = false;
            playerAction = "SHOOT";
            PlayerLabelsUpdate();
        }

        public static void PlayerShotgun()
        {
            sfxShotgun.Play();
            PlayerActions.bulletCount = 0;
            PlayerActions.playerShotgun = false;
            playerAction = "SHOTGUN!";
            PlayerLabelsUpdate();
        }

        public static void PlayerBlock()
        {
            PlayerActions.playerBlock = false;
            playerAction = "BLOCK";
            shotgunGame.lblAction.Text = GameActions.playerAction;
        }

        public static void PlayerLabelsUpdate()
        {
            shotgunGame.lblBulletCount.Text = PlayerActions.bulletCount.ToString();
            shotgunGame.lblAction.Text = GameActions.playerAction;
        }

        public static void AiLabelsUpdate()
        {
            shotgunGame.lblAIAction.Text = GameActions.aiAction;
            shotgunGame.lblAIBulletCount.Text = AiActions.aiBulletCount.ToString();
        }
    }
}
