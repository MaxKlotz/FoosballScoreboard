using FoosballScoreboard.BusinessLogic.Interfaces;
using FoosballScoreboard.Settings;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace FoosballScoreboard.Forms
{
    public partial class Main : Form
    {
        private readonly IMatchLoader _matchLoader;
        private readonly FoosScoreboardSettings _settings;

        public Main(IMatchLoader matchLoader, IOptions<FoosScoreboardSettings> settings)
        {
            _matchLoader = matchLoader;
            _settings = settings.Value;
            
            InitializeComponent();
        }

        private async Task InitDataBinding()
        {
            await _matchLoader.LoadMatch();

            TxtGreenTeamName1.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenName1),
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            TxtGreenTeamName2.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenName2),
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            TxtGreenGoals.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenGoals),
                                true);
            TxtGreenSets.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenSets),
                                true);

            TxtBlackTeamName1.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.BlackName1),
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            TxtBlackTeamName2.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.BlackName2),
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            TxtBlackGoals.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.BlackGoals),
                                true);
            TxtBlackSets.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.BlackSets),
                                true);
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await InitDataBinding();
        }

        private void BtnGreenUp_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.IncrementGreenGoals();
        }

        private void BtnGreenDown_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.DecrementGreenGoals();
        }

        private void BtnBlackGoalUp_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.IncrementBlackGoals();
        }

        private void BtnBlackDown_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.DecrementBlackGoals();
        }

        private async void BtnResetScore_Click(object sender, EventArgs e)
        {
            await _matchLoader.CurrentMatch.ResetScore();
        }

        private void BtnGreenSetUp_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.IncrementGreenSets();
        }

        private void BtnGreenSetDown_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.DecrementGreenSets();
        }

        private void BtnBlackSetUp_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.IncrementBlackSets();
        }

        private void BtnBlackSetDown_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.DecrementBlackSets();
        }

        private void OpenSavedPath_Click(object sender, EventArgs e)
        {
            Process.Start(_settings.DirectoryPath);
        }
    }
}