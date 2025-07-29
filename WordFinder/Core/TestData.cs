using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchApp.Core
{
    public static class TestData
    {
        public static readonly string[] Matrix = {
            "computerhappyxz",
            "abcdefghijklmno",
            "rstuvwxyzabcdef",
            "elephantghijklm",
            "nopqrstuvwxyzab",
            "cdefghijklmnopq",
            "musicabcdefghij",
            "klmnopqrstuvwxy",
            "dancelightabcde",
            "fghijklmnopqrst",
            "waterabcdefghij",
            "klmnopqrstuvwxy",
            "nightabcdefghij",
            "klmnopqrstuvwxy",
            "worldabcdefghij"
        };

        public static readonly List<string> WordsToSearch = new List<string> {
            "smart", "planet", "home", "tower", "river", "ocean",
            "fish", "music", "book", "light", "dance", "water",
            "school", "park", "green", "farm", "bridge", "car",
            "forest", "quick", "brown", "love", "joy", "peace",
            "hope", "dreams", "bright", "future", "dog", "night",
            "study", "table", "under", "youth", "ancient", "code", 
            "data", "elephant", "computer", "programming", 
            "algorithm", "javascript", "database", "software", "internet",
            "keyboard", "monitor", "telephone", "television",
            "refrigerator", "microwave", "airplane", "helicopter"
        };
    }
}
