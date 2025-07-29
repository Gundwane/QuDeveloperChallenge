# Word Finder

## Overview
Word Finder is a C# application designed to search for specific words in a character matrix. It identifies words that appear horizontally (from left to right) and vertically (from top to bottom). This application is highly efficient and tailored for a performance-oriented search in large word streams.

## Features
- Detects words in both directions in a character matrix.
- Returns the top 10 most common words found in a provided word stream.
- Handles a matrix size of up to 64x64 efficiently.

## Getting Started

### Prerequisites
- .NET Core SDK (version 3.1 or later)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/WordFinder.git
   cd WordFinder
2. Open the solution in your preferred IDE (such as Visual Studio or JetBrains Rider).

### Usage
The main entry point of the application is in Program.cs. You can customize the TestData class to change the matrix or the words to search.

To execute the program:

   ```bash
   git clone https://github.com/yourusername/WordFinder.git
   cd WordFinder
   ```

### Example
The default TestData includes a matrix and a list of words. Upon running the program, it will print the found words from the stream that are present in the matrix.

## Code Details
### Classes
**WordFinder:** The main class for searching words within the matrix.

**WordFinderPrinter:** A utility class for printing the matrix and found words.

**TestData:** Contains test data for the matrix and the words to search.

### Performance Evaluation
The implementation ensures high performance by utilizing a set for quick lookups of precomputed words, allowing for efficient filtering of the word stream.
