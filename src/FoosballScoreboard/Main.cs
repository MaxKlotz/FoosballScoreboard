using FoosballScoreboard.Interfaces;

namespace FoosballScoreboard
{
    public partial class Main : Form
    {
        private readonly IMatchLoader _matchLoader;

        public Main(IMatchLoader matchLoader)
        {
            _matchLoader = matchLoader;
            InitializeComponent();
            InitDataBinding();
        }

        private void InitDataBinding()
        {
            _matchLoader.LoadMatch();
            this.txtGreenTeamName.DataBindings.Add("Text",
                                _matchLoader.CurrentMatch,
                                nameof(_matchLoader.CurrentMatch.GreenName),
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BtnGreenUp_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.IncrementGreenGoals();
        }

        private void BtnGreenDown_Click(object sender, EventArgs e)
        {
            _matchLoader.CurrentMatch.DecrementGreenGoals();
        }
    }
}