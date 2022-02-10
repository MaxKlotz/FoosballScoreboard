﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoosballScoreboard.Interfaces;
public interface IMatchLoader
{
    Task<MatchData> LoadMatch();
    Task ApplyChanges(string fieldName);
    MatchData CurrentMatch { get; }
}
