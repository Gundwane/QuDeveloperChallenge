using WordSearchApp.Core;
using WordSearchApp.Utils;

var wordFinder = new WordFinder(TestData.Matrix);

var foundWords = wordFinder.Find(TestData.WordsToSearch);
WordFinderPrinter.PrintFoundWords(foundWords);