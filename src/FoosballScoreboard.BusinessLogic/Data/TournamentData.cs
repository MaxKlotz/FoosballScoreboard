using FoosballScoreboard.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoosballScoreboard.BusinessLogic.Data
{
    public class TournamentData: INotifyPropertyChangedWithChangeSet
    {
        private string _tournamentName = string.Empty;
        private string _competition = string.Empty;

        public event INotifyPropertyChangedWithChangeSet.PropertyChangedWithChangesetEventHandler? PropertyChangedWithChangeset;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
