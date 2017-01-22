using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Log_Likelihood.Properties;
using Log_Likelihood.Services;

namespace Log_Likelihood
{
    public partial class LogLikelihoodForm : Form
    {
        private string _fileForAnalysis = "input.txt";
        private Dictionary<string, double> _loglikelihoods;

        public LogLikelihoodForm()
        {
            InitializeComponent();

            tbFile.Text = _fileForAnalysis;
            lbLikelihood.MouseWheel += (s, e) => ((HandledMouseEventArgs)e).Handled = true;
            lbTwowords.MouseWheel += (s, e) => ((HandledMouseEventArgs)e).Handled = true;

            lbTwowords.Scroll += (s, args) => lbLikelihood.TopIndex = lbTwowords.TopIndex;
            lbLikelihood.Scroll += (s, args) => lbTwowords.TopIndex = lbLikelihood.TopIndex;

            LemmalizationService.LemmalizationCompleted += OnWordsLemmalized;
        }

        private void OnWordsLemmalized(IEnumerable<string> lemms)
        {
            var words = StopWordFilterService.Filter(lemms);
            var wordPairs = TwoWordsCombineService.Combine(words);

            _loglikelihoods = new LogLikelihoodService(wordPairs).Analize();
            var list = _loglikelihoods.ToList();
            list.Sort((first, second) =>
            {
                if (first.Value > second.Value)
                    return -1;
                if (first.Value < second.Value)
                    return 1;
                return 0;
            });

            lbTwowords.DataSource = list.Select(l => l.Key).ToList();
            lbLikelihood.DataSource = list.Select(l => l.Value.ToString("F2")).ToList();

            lbTwowords.Refresh();
            lbLikelihood.Refresh();

            activityIndicatorFront.Hide();
        }

        private void LogLikelihoodForm_Load(object sender, EventArgs e) { }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdBrowse.ShowDialog() == DialogResult.Cancel)
                return;

            _fileForAnalysis = ofdBrowse.FileName;
            tbFile.Text = _fileForAnalysis.Split('\\').LastOrDefault();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            activityIndicatorFront.Show();

            LemmalizationService.Lemmalize(_fileForAnalysis);
        }
    }
}
