using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input your sentence: ");
            string sentence = Console.ReadLine();

            ReverseWords(sentence);

        }

        static string[] SplitText(string line)
        {

            line = line.Trim();

            int spaceCount = 0;

            bool isPeviousSymbolSpace = false;
            foreach (char symbol in line)
            {

                if (symbol == ' ' && isPeviousSymbolSpace)
                {
                    continue;
                }
                else if (symbol == ' ')
                {
                    isPeviousSymbolSpace = true;
                    spaceCount++;
                }
                else
                {
                    isPeviousSymbolSpace = false;
                }

            }

            string[] words = new string[spaceCount + 1];

            spaceCount = 0;
            string word = "";
            foreach (char symbol in line)
            {

                if (symbol == ' ' && isPeviousSymbolSpace)
                {
                    continue;
                }
                else if (symbol == ' ')
                {
                    isPeviousSymbolSpace = true;
                    words[spaceCount] = word;
                    word = "";
                    spaceCount++;
                }
                else
                {
                    isPeviousSymbolSpace = false;
                    word += symbol;
                }

            }

            if (word != "") words[words.Length - 1] = word;

            return words;

        }

        static string Reverse(string text)
        {

            string[] words = SplitText(text);
            string reversedSentence = "";
            for (int wordIndex = words.Length - 1; wordIndex >= 0; wordIndex--)
            {

                reversedSentence += words[wordIndex] + (wordIndex == 0 ? "" : " ");

            }

            return reversedSentence;
        
        }

        static void ReverseWords(string sentence) 
        {

            Console.WriteLine(
                Reverse(sentence)    
            );
        
        }

    }
}
