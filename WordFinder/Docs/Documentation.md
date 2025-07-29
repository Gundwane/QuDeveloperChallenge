# Documentation for WordFinder

## Overview
The WordFinder project is designed to efficiently search for specific words in a character matrix. 

## Class Analysis

### WordFinder Class
The `WordFinder` class is designed to efficiently search for words from a provided word stream within a character matrix. Here's a breakdown of its key components:

1. **Constructor**
   - **Input Validation:** Takes an `IEnumerable<string>` representing the character matrix and ensures all rows are of equal length. Converts rows into character arrays for efficient access.
   - **Word Precomputation:** Builds a `HashSet<string>` of all possible words formed horizontally and vertically in the matrix, reducing search time.

2. **Find Method**
   - **Input Handling:** Accepts a word stream, filtering out null or empty strings and those not in the precomputed word set.
   - **Counting Occurrences:** Uses a dictionary to count occurrences of unique words found.
   - **Return Value:** Returns the top 10 most common words based on frequency, sorted alphabetically in case of ties.

3. **Private Helper Methods**
   - **PrecomputeAllWords:** Extracts all possible words from the matrix and stores them in a set.
   - **ExtractWordsFromSequence:** Generates all possible substrings of length 2 or more from a character sequence.

## Performance Analysis
The class handles a maximum matrix size of 64x64 through precomputation, allowing O(1) checks against the precomputed words. Building the word set has a complexity of O(N^2) in the worst case (N being the matrix side length). Finding words in the stream operates in linear time relative to the stream's size.