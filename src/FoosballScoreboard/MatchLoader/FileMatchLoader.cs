using FoosballScoreboard.Interfaces;
using FoosballScoreboard.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoosballScoreboard.MatchLoader;
internal class FileMatchLoader : IMatchLoader
{
    public MatchData CurrentMatch { get; private set; } = new MatchData();
    private readonly FoosScoreboardSettings _settings;

    public FileMatchLoader(FoosScoreboardSettings settings)
    {
        _settings = settings;
    }

    public async Task<MatchData> LoadMatch()
    {
        var greenName = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenName.txt"));
        var greenGoals = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenGoals.txt"));
        var greenSets = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenSets.txt"));
        var greenTimeout = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenTimeouts.txt"));
        var blackName = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackName.txt"));
        var blackGoals = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackGoals.txt"));
        var blackSets = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackSets.txt"));
        var blackTimeout = File.ReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackTimeouts.txt"));

        await Task.WhenAll(greenName,
            greenGoals,
            greenSets,
            greenTimeout,
            blackName,
            blackGoals,
            blackSets,
            blackTimeout);

        CurrentMatch = new MatchData
        {
            GreenName = greenName.Result,
            GreenGoals = greenGoals.Result,
            GreenSets = greenSets.Result,
            GreenTimeout = greenTimeout.Result,
            BlackName = blackName.Result,
            BlackGoals = blackGoals.Result,
            BlackSets = blackSets.Result,
            BlackTimeout = blackTimeout.Result,
        };
        CurrentMatch.PropertyChanged += CurrentMatch_PropertyChanged;

        return CurrentMatch;
    }

    private void CurrentMatch_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.PropertyName))
        {
            return;
        }
        ApplyChanges(e.PropertyName);
    }

    public void ApplyChanges(string changedField)
    {
    }
}
