using FoosballScoreboard.Interfaces;
using System.ComponentModel;

namespace FoosballScoreboard
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

            txtGreenTeamName.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenName),
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            txtGreenGoals.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenGoals),
                                true);
        }

        private void BtnGreenUp_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.IncrementGreenGoals();
        }

        private void BtnGreenDown_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.DecrementGreenGoals();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await InitDataBinding();
        }
    }
}