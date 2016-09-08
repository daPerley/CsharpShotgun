using System;

namespace Shotgun.Classes
{
    public class AiActions
    {
        static Random random = new Random();
        static int randomNumber;
        public static int aiBulletCount = 0;

        public static void AiActionControl ()
        {
            AiLogic();

            switch (randomNumber)
            {
                case 1:
                    AiReload();
                    GameActions.AiReload();
                    break;

                case 2:
                    AiShoot();
                    break;

                case 3:
                    GameActions.AiBlock();
                    break;
                default:
                    break;
            }
        }

        public static void AiLogic()
        {
            randomNumber = random.Next(1, 4);

            if (aiBulletCount >= 3)
            {
                randomNumber = 2;
            }
            else if (aiBulletCount == 0 && PlayerActions.bulletCount == 0)
            {
                randomNumber = 1;
            }
            else if (aiBulletCount == 0 && randomNumber == 2)
            {
                randomNumber = 1;
            }
        }

        public static void AiReload()
        {
            ++aiBulletCount;
        }

        public static void AiShoot()
        {
            if (aiBulletCount >= 3)
            {
                aiBulletCount = 0;
                GameActions.AiShotgun();
            }
            else if  (aiBulletCount >= 1)
            {
                --aiBulletCount;
                GameActions.AiShoot();
            }
        }
    }
}
