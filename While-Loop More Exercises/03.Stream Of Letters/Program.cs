using System;

namespace _03.Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentWord = string.Empty;
            string finalWord = string.Empty;
            bool metC = false;
            bool metO = false;
            bool metN = false;
            string letter = string.Empty;

            while (letter != "End")
            {
                char letter2 = char.Parse(letter);
                if (char.IsLetter(letter2))
                {
                    switch (letter2)
                    {
                        case 'c':

                            if (metC)
                            {
                                currentWord += letter;
                            }
                            else
                                metC = true;
                            break;
                        case 'o':

                            if (metO)
                                currentWord += letter;
                            else
                                metO = true;
                            break;
                        case 'n':

                            if (metN)
                                currentWord += letter;
                            else
                                metN = true;
                            break;
                        default:
                            currentWord += letter;
                            break;
                    }
                    if (metC && metN && metO)
                    {
                        finalWord += currentWord + " ";
                        metC = false;
                        metO = false;
                        metN = false;
                        currentWord = "";
                    }
                }
                letter = Console.ReadLine();
            }
            Console.WriteLine(finalWord);
        }
    }
}
