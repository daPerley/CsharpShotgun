using System.Linq;
using System.Windows.Forms;

namespace Shotgun.Classes
{
    public class WinOrLoss
    {
        static Form1 shotgunGame = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        static DialogResult keepPlaying;
        public static int winCount = 0;
        private static string playAgain = "Would you like to play again?";

        public static void WinCounter()
        {
            winCount++;
            shotgunGame.lblWinCount.Text = WinOrLoss.winCount.ToString();
        }

        public static void WinRegular()
        {
            WinCounter();
            keepPlaying = MessageBox.Show("You've won!\n\n" + playAgain, "Victory", MessageBoxButtons.YesNo);
            PlayAgain();
        }

        public static void WinShotgun()
        {
            WinCounter();
            keepPlaying = MessageBox.Show("You fired a shotgun, you win!\n\n" + playAgain, "Victory", MessageBoxButtons.YesNo);
            PlayAgain();
        }

        public static void LossRegular()
        {
            keepPlaying = MessageBox.Show("You've lost..!\n\n" + playAgain, "Loss", MessageBoxButtons.YesNo);
            PlayAgain();
        }

        public static void LossShotgun()
        {
            keepPlaying = MessageBox.Show("The enemy fired a shotgun, you lose..!\n\n" + playAgain, "Loss", MessageBoxButtons.YesNo);
            PlayAgain();
        }

        public static void Tie()
        {
            keepPlaying = MessageBox.Show("It's a tie..!\n\n" + playAgain, "Tie", MessageBoxButtons.YesNo);
            PlayAgain();
        }

        public static void TieShotgun()
        {
            keepPlaying = MessageBox.Show("Both used Shotgun, it's a tie..!\n\n" + playAgain, "Tie Shotgun", MessageBoxButtons.YesNo);
            PlayAgain();
        }

        public static void PlayAgain()
        {
            if (keepPlaying == DialogResult.Yes)
            {
                PlayerActions.bulletCount = 0;
                GameActions.playerAction = "ACTION";
                AiActions.aiBulletCount = 0;
                GameActions.aiAction = "ACTION";
                GameActions.PlayerLabelsUpdate();
                GameActions.AiLabelsUpdate();
            } else if (keepPlaying == DialogResult.No)
            {
                shotgunGame.Close();
            }
        }
    }
}
