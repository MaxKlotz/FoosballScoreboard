using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoosballScoreboard.Interfaces;
public interface IMatchLoader
{
    Task<MatchData> LoadMatch();
    void ApplyChanges(string fieldName, object value);
    MatchData CurrentMatch { get; }
}
