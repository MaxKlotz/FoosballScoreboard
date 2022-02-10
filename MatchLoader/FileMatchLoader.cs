using FoosballScoreboard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoosballScoreboard.MatchLoader
{
    internal class FileMatchLoader : IMatchLoader
    {
        public MatchData LoadMatchAsync()
        {
            return new MatchData();
        }
    }
}
