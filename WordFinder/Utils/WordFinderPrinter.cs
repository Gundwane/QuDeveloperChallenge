using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchApp.Utils
{
    public class WordFinderPrinter
    {
        public static void PrintMatrix(IEnumerable<string> matrix, string title = "Matrix")
        {
            Console.WriteLine($"\n=== {title} ===");
            var matrixList = matrix.ToList();

            for (int i = 0; i < matrixList.Count; i++)
            {
                Console.WriteLine($"{string.Join(" ", matrixList[i].ToCharArray())}");
            }
            Console.WriteLine(new string('-', 30));
        }

        public static void PrintFoundWords(IEnumerable<string> foundWords, string title = "Found Words")
        {
            Console.WriteLine($"\n=== {title} ===");

            var wordsList = foundWords.ToList();

            if (!wordsList.Any())
            {
                Console.WriteLine("No words found in the matrix.");
                return;
            }

            Console.WriteLine($"Total words found: {wordsList.Count}");
            Console.WriteLine("Words (ordered by frequency):");

            for (int i = 0; i < wordsList.Count; i++)
            {
                Console.WriteLine($"{i + 1,2}. {wordsList[i]}");
            }

            Console.WriteLine(new string('-', 30));
        }

        public static void PrintWordsToSearch(IEnumerable<string> words, string title = "Words to Search")
        {
            Console.WriteLine($"\n=== {title} ===");
            var wordsList = words.ToList();

            if (!wordsList.Any())
            {
                Console.WriteLine("No words to search.");
                return;
            }

            Console.WriteLine($"Total words to search: {wordsList.Count}");

            for (int i = 0; i < wordsList.Count; i++)
            {
                Console.WriteLine($"{i + 1,2}. {wordsList[i]}");
            }

            Console.WriteLine(new string('-', 30));
        }
    }
}
