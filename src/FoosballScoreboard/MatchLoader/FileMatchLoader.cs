using FoosballScoreboard.Interfaces;
using FoosballScoreboard.Settings;
using Microsoft.Extensions.Options;

namespace FoosballScoreboard.MatchLoader;
internal class FileMatchLoader : IMatchLoader
{
    public MatchData CurrentMatch { get; private set; } = new MatchData();
    private readonly FoosScoreboardSettings _settings;

    public FileMatchLoader(IOptions<FoosScoreboardSettings> settings)
    {
        _settings = settings.Value;
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
            GreenName1 = greenName.Result,
            GreenGoals = greenGoals.Result,
            GreenSets = greenSets.Result,
            GreenTimeout = greenTimeout.Result,
            BlackName1 = blackName.Result,
            BlackGoals = blackGoals.Result,
            BlackSets = blackSets.Result,
            BlackTimeout = blackTimeout.Result,
        };
        CurrentMatch.PropertyChangedWithChangeset += OnCurrentMatch_PropertyChangedWithChangeset;

        return CurrentMatch;
    }

    private void OnCurrentMatch_PropertyChangedWithChangeset(object? sender, Forms.Interfaces.PropertyChangedWithChangesetEventArgs e)
    {
        if (string.IsNullOrEmpty(e.PropertyName))
        {
            return;
        }
        ApplyChanges(e.PropertyName, e.ChangeSet.After);
    }

    public void ApplyChanges(string changedField, object value)
    {

    }
}
