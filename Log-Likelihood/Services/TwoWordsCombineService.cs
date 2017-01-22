using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Likelihood.Services
{
    static class TwoWordsCombineService
    {
        public static IEnumerable<string> Combine(IEnumerable<string> words)
        {
            var wordsArray = words.ToArray();
            var wordPairs = new List<string>(wordsArray.Length);

            for (var i = 0; i < wordsArray.Length - 1; i++)
            {
                var wordPair = wordsArray[i] + " " + wordsArray[i + 1];
                wordPairs.Add(wordPair);
            }

            return wordPairs;
        }
    }
}
