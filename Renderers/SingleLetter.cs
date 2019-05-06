using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMateLogo.Renderers
{
    class SingleLetter : IRenderer
    {
        public void Render(int n)
        {
            int sideSpace = n;
            int totalSpace = n * 5;
            int midSpace = n;
            int lowerMidSpace = -1;

            for (int row = 0; row < n + 1; row++)
            {
                int additionalStars = (totalSpace - (2 * sideSpace + 2 * n + midSpace)) / 2;

                Console.Write(new string('-', sideSpace));
                Console.Write(new string('*', n));
                if (midSpace > 0)
                {
                    Console.Write(new string('*', additionalStars));
                    Console.Write(new string('-', midSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', additionalStars));
                    midSpace -= 2;
                }
                else
                {
                    lowerMidSpace += 2;

                    Console.Write(new string('-', lowerMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', n - lowerMidSpace));
                    Console.Write(new string('-', lowerMidSpace));
                    Console.Write(new string('*', n));

                }

                Console.Write(new string('-', sideSpace));

                Console.WriteLine();

                sideSpace--;
            }
        }
    }
}
