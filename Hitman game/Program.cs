 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitman_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Jump", "Programming", "Sky", "Picture", "River", "start", "Grass", "Facebook", "Google", "Clearane", "Thango", "Tebogo" };
            Random random = new Random();
            int randomIndex = random.Next(0, 8);
            string selectedword = words[randomIndex];
            string hiddenWord = "";


            for (int i = 0; i < selectedword.Length; i++)
            {
                hiddenWord += "*";
            }
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0}", hiddenWord);
                Console.Write("Guess a latter >> ");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;

                for (int i = 0; i < selectedword.Length; i++)
                {
                    if(selectedword[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }
                }
                if (containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes! {0} in the word", letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry!, {0} is not in the word", letter);
                }
                Console.ResetColor();

            }
            Console.WriteLine("Congratulations! You have aced the word and the correct word is {0}", hiddenWord);
            Console.ReadLine();
        }
    }
}
