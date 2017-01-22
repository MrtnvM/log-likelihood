using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Log_Likelihood.Services
{
    static class StopWordFilterService
    {
        private static string _stopWordsFile = "stop_words.txt";

        public static IEnumerable<string> Filter(IEnumerable<string> words)
        {
            string stopWordsText;
            using (var sw = new StreamReader(_stopWordsFile))
            {
                stopWordsText = sw.ReadToEnd();
            }

            var stopWords = stopWordsText.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var filtredWords = words.Where(word => !stopWords.Contains(word));

            return filtredWords;
        }
    }
}
