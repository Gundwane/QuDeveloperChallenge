using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchApp.Core
{
    public class WordFinder : IWordFinder
    {
        #region Private Fields
        private readonly char[][] matrix;
        private readonly int rows;
        private readonly int cols;
        private readonly HashSet<string> precomputedWords;
        #endregion

        #region Constructor
        public WordFinder(IEnumerable<string> matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            this.matrix = matrix.Select(row => row?.ToCharArray() ?? throw new ArgumentNullException("Row cannot be null"))
                                .ToArray();
            this.rows = this.matrix.Length;
            this.cols = this.matrix[0].Length;

            // Validate that all rows have the same length
            for (int i = 0; i < this.rows; i++) 
            {
                if (this.matrix[i].Length != this.cols)
                    throw new ArgumentException($"Row {i} has length {this.matrix[i].Length}, expected {this.cols}");
            }

            // Precompute all possible words for maximum performance
            this.precomputedWords = PrecomputeAllWords();
        }
        #endregion

        #region Public Methods
        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            if (wordstream == null)
                return Enumerable.Empty<string>();

            // Single pass: count occurrences AND filter by matrix existence
            var foundWordCounts = new Dictionary<string, int>();

            foreach (var word in wordstream)
            {
                // Skip null/empty and words not in matrix (O(1) check)
                if (string.IsNullOrEmpty(word) || !precomputedWords.Contains(word))
                    continue;

                // Count occurrences of words that exist in matrix
                foundWordCounts.TryGetValue(word, out int currentCount);
                foundWordCounts[word] = currentCount + 1;
            }

            // Return top 10 most repeated words
            return foundWordCounts
                .OrderByDescending(kvp => kvp.Value)  // Most repeated first
                .ThenBy(kvp => kvp.Key)               // Alphabetical tiebreaker
                .Take(10)
                .Select(kvp => kvp.Key);
        }
        #endregion

        #region Private Methods
        private HashSet<string> PrecomputeAllWords()
        {
            var allWords = new HashSet<string>();

            // Horizontal words
            for (int row = 0; row < rows; row++)
            {
                ExtractWordsFromSequence(matrix[row], allWords);
            }

            // Vertical words
            for (int col = 0; col < cols; col++)
            {
                var columnChars = new char[rows];
                for (int row = 0; row < rows; row++)
                {
                    columnChars[row] = matrix[row][col];
                }
                ExtractWordsFromSequence(columnChars, allWords);
            }

            return allWords;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExtractWordsFromSequence(char[] sequence, HashSet<string> wordSet)
        {
            int length = sequence.Length;

            for (int start = 0; start < length; start++)
            {
                for (int wordLength = 2; wordLength <= length - start; wordLength++)
                {
                    var word = new string(sequence, start, wordLength);
                    wordSet.Add(word);
                }
            }
        }
        #endregion
    }
}
