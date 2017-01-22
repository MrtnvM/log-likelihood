using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Log_Likelihood.Services
{
    static class LemmalizationService
    {
        private static readonly SynchronizationContext Context = SynchronizationContext.Current;
        private static readonly string _outputFile = "output.txt";

        public static event Action<IEnumerable<string>> LemmalizationCompleted;

        public static void Lemmalize(string inputTextFile)
        {
            Process.Start("mystem.exe", " -n -l " + inputTextFile + " " +_outputFile);

            var lemmalization = new Task(() =>
            {
                string lemmalizedText;
                using (var sr = new StreamReader(_outputFile))
                {
                    lemmalizedText = sr.ReadToEnd();
                }

                var lemms = lemmalizedText.Split(new[] {'\r', '\n', '}'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(w => w.Split(new[] {'|', '?'}, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault())
                    .Select(w => w.ToLower());

                Context.Post(l =>
                {
                    LemmalizationCompleted?.Invoke((IEnumerable<string>)l);
                }, lemms);
            });

            lemmalization.Wait(4000);
            lemmalization.Start();
        }
    }
}
