using System.Media;

namespace Shotgun.Classes
{
    public class PlayerActions
    {
        static SoundPlayer sfxEmptyMag = new SoundPlayer(Properties.Resources.EmptyMag); 

        public static int bulletCount = 0;
        public static bool playerReload = false;
        public static bool playerShoot = false;
        public static bool playerShotgun = false;
        public static bool playerBlock = false;

        public static void PlayerReload()
        {
            ++bulletCount;
            playerReload = true;
            AiActions.AiActionControl();
        }

        public static void PlayerShoot()
        {
             if (bulletCount >= 3)
            {
                playerShotgun = true;
                AiActions.AiActionControl();
            }
            else if (bulletCount >= 1)
            {
                playerShoot = true;
                AiActions.AiActionControl();
            }
            else
            {
                sfxEmptyMag.Play();
            }
        }

        public static void PlayerBlock()
        {
            playerBlock = true;
            AiActions.AiActionControl();
        }
    }
}
