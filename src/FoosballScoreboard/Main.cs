using FoosballScoreboard.Interfaces;
using System.ComponentModel;

namespace FoosballScoreboard.Forms
{
    public partial class Main : Form
    {
        private readonly IMatchLoader _matchLoader;

        private BackgroundWorker worker = new BackgroundWorker();

        public Main(IMatchLoader matchLoader)
        {
            _matchLoader = matchLoader;
            
            InitializeComponent();
        }

        private async Task InitDataBinding()
        {
            await _matchLoader.LoadMatch();

            TxtGreenTeamName.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenName),
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

            TxtBlackTeamName.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.BlackName),
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
    }
}