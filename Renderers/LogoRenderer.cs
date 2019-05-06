using System;
using System.Collections.Generic;
using System.Text;

namespace MentorMateLogo.Renderers
{
    class LogoRenderer : IRenderer
    {
        public void Render(int n)
        {
            int sideSpace = n;
            int totalSpace = n * 5;
            int letterMidSpace = n;
            int lowerMidSpace = -1;

            for (int row = 0; row < n + 1; row++)
            {
                int additionalStars = (totalSpace - (2 * sideSpace + 2 * n + letterMidSpace)) / 2;

                Console.Write(new string('-', sideSpace));
                Console.Write(new string('*', n));
                if (letterMidSpace > 0)
                {
                    Console.Write(new string('*', additionalStars));
                    Console.Write(new string('-', letterMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', additionalStars));
                    Console.Write(new string('-', sideSpace * 2));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', additionalStars));
                    Console.Write(new string('-', letterMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', additionalStars));
                    Console.Write(new string('-', sideSpace));
                    letterMidSpace -= 2;
                }
                else
                {
                    lowerMidSpace += 2;

                    Console.Write(new string('-', lowerMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', n - lowerMidSpace));
                    Console.Write(new string('-', lowerMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('-', sideSpace * 2));
                    Console.Write(new string('*', n));
                    Console.Write(new string('-', lowerMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('*', n - lowerMidSpace));
                    Console.Write(new string('-', lowerMidSpace));
                    Console.Write(new string('*', n));
                    Console.Write(new string('-', sideSpace));



                }

                Console.WriteLine();

                sideSpace--;
            }
        }
    }
}
