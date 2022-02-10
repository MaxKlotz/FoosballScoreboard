using FoosballScoreboard.Interfaces;

namespace FoosballScoreboard
{
    public partial class Main : Form
    {
        private readonly IMatchLoader _matchLoader;

        public Main(IMatchLoader matchLoader)
        {
            _matchLoader = matchLoader;
            InitDataBinding();
            InitializeComponent();
        }

        private void InitDataBinding()
        {
            this.DataBindings.Add("Text",
                                this.Food,
                                "Name",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}