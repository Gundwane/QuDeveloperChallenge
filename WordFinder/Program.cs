using WordSearchApp.Core;
using WordSearchApp.Utils;

WordFinderPrinter.PrintMatrix(TestData.Matrix);
WordFinderPrinter.PrintWordsToSearch(TestData.WordsToSearch);

var wordFinder = new WordFinder(TestData.Matrix);

var foundWords = wordFinder.Find(TestData.WordsToSearch);
WordFinderPrinter.PrintFoundWords(foundWords);