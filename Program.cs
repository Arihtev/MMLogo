using MentorMateLogo.Renderers;
using System;

namespace MentorMateLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isValid = false;
            Console.Write("Please enter N: ");
            
            while (isValid == false)
            {
                string input = Console.ReadLine();

                if(int.TryParse(input, out n))
                {
                    if (n > 2 && n < 10000 && n % 2 == 1)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Number must be odd and in interval 2-10 000!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
                
            }
            string rendererType = null;
            Console.WriteLine("Enter the letter of a specific renderer: ");
            Console.WriteLine("L - write MM logo");
            Console.WriteLine("M - write a single M letter");
            while (string.IsNullOrEmpty(rendererType))
            {
                rendererType = Console.ReadLine().ToLower();
                if (rendererType == "l" || rendererType == "m")
                {
                    break;
                }
                else
                {
                    rendererType = null;
                    Console.WriteLine("Please enter valid renderer type (I/M)!");
                }
            }

            IRenderer renderer = GenerateRenderer(rendererType);

            renderer.Render(n);

            Console.ReadLine();
        }

        static IRenderer GenerateRenderer(string rendererType)
        {
            switch (rendererType)
            {
                case "l": return new LogoRenderer();
                case "m": return new SingleLetter();
                default: return null;
            }
        }
    }    
}
