using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace Inlamningsuppgift_2
{
    class RandomTones
    {
        public static void RandomTonePlayer()
        {
            Random rand = new Random();
            int randTone = rand.Next(200, 450);
            int randLength = rand.Next(125, 250);

            for (int i = 0; i < 20; i++)
            {
                Console.Beep(randTone, randLength);
                if (i == 5 || i == 10 ||i == 15)
                {
                    Thread.Sleep(250);
                }
                else if (i == 7 || i == 12 || i == 18)
                {
                    Thread.Sleep(75);
                }
                else
                    Thread.Sleep(150);

                randTone = rand.Next(200, 450);
                randLength = rand.Next(125, 250);
            }
        }
    }
}
