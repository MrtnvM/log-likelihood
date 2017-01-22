using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Log_Likelihood.Services
{
    class LogLikelihoodService
    {
        private readonly List<string> _wordPairs = new List<string>();
        private readonly Dictionary<string, int> _wordPairCount = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _leftLemmCounts = new Dictionary<string, int>(); 
        private readonly Dictionary<string, int> _rightLemmCounts = new Dictionary<string, int>(); 
        private readonly Dictionary<string, int> _otherBigrmsForWordPairCounts = new Dictionary<string, int>(); 

        public LogLikelihoodService(IEnumerable<string> wordPairs)
        {
            _wordPairs.AddRange(wordPairs);
        }

        public Dictionary<string, double> Analize()
        {
            AnalyzeWordPairsFrequency();
            AnalyzeLeftLemInPairsFrequancy();
            AnalyzeRightLemInPairsFrequancy();
            AnalyzeOtherBigramsCountFrequancy();

            var loglikelihoodResults = new Dictionary<string, double>();

            var uniqueWordPairs = _wordPairs.Distinct().ToArray();

            foreach (var wordPair in uniqueWordPairs)
            {
                var a = _wordPairCount[wordPair];
                var b = _leftLemmCounts[GetLeftLem(wordPair)];
                var c = _rightLemmCounts[GetRightLem(wordPair)];
                var d = _otherBigrmsForWordPairCounts[wordPair];

                var loglikelihood = a*Log(a + 1) + b*Log(b + 1) + c*Log(c + 1) + d*Log(d + 1) -
                    (a + b)*Log(a + b + 1) - (a + c)*Log(a + c + 1) - (b + d)*Log(b + d + 1) - (c + d)*Log(c + d + 1) +
                    (a + b + c + d)*Log(a + b + c + d + 1);

                loglikelihoodResults.Add(wordPair, loglikelihood);
            }

            return loglikelihoodResults;
        }

        private string GetLeftLem(string wp) => wp.Split(' ').First();
        private string GetRightLem(string wp) => wp.Split(' ').Last();

        private void AnalyzeWordPairsFrequency()
        {
            foreach (var wordPair in _wordPairs)
            {
                if (_wordPairCount.ContainsKey(wordPair))
                    _wordPairCount[wordPair]++;
                else
                    _wordPairCount.Add(wordPair, 1);
            }
        }

        private void AnalyzeLeftLemInPairsFrequancy()
        {
            var leftLems = _wordPairs.Select(wordPair => wordPair.Split(' ').First());

            foreach (var leftLem in leftLems)
            {
                if (_leftLemmCounts.ContainsKey(leftLem))
                    _leftLemmCounts[leftLem]++;
                else
                    _leftLemmCounts.Add(leftLem, 0);
            }
        }

        private void AnalyzeRightLemInPairsFrequancy()
        {
            var rightLems = _wordPairs.Select(wordPair => wordPair.Split(' ').Skip(1).First());

            foreach (var rightLem in rightLems)
            {
                if (_rightLemmCounts.ContainsKey(rightLem))
                    _rightLemmCounts[rightLem]++;
                else
                    _rightLemmCounts.Add(rightLem, 0);
            }
        }

        private void AnalyzeOtherBigramsCountFrequancy()
        {
            var uniqueWordPairs = _wordPairs.Distinct().ToArray();

            foreach (var wordPair in uniqueWordPairs)
            {
                var leftLem = wordPair.Split(' ').First();
                var rightLem = wordPair.Split(' ').Skip(1).First();

                var count = uniqueWordPairs.Where(wp =>
                {
                    var wpLeftLem = wp.Split(' ').First();
                    var wpRightLem = wp.Split(' ').Skip(1).First();

                    return wpRightLem != rightLem && wpLeftLem != leftLem;
                }).Count();

                _otherBigrmsForWordPairCounts.Add(wordPair, count);
            }
        }
    }
}
