using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoosballScoreboard.Settings;
public class FoosScoreboardSettings
{
    public const string SectionName = nameof(FoosScoreboardSettings);
    public string DirectoryPath { get; set; } = @"C:\FoosScoreboard\data\Scoreboard\table_1";
    public WatchedField[] WatchedFields { get; } = Array.Empty<WatchedField>();
}
