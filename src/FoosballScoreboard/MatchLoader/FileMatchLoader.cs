using FoosballScoreboard.BusinessLogic.Interfaces;
using FoosballScoreboard.Forms;
using FoosballScoreboard.Settings;
using Microsoft.Extensions.Options;

namespace FoosballScoreboard.BusinessLogic.MatchLoader;
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
        if (!Directory.Exists(_settings.DirectoryPath))
        {
            Directory.CreateDirectory(_settings.DirectoryPath);
        }
        var greenName = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenName.txt"));
        var greenGoals = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenGoals.txt"));
        var greenSets = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenSets.txt"));
        var greenTimeout = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "greenTimeouts.txt"));
        var blackName = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackName.txt"));
        var blackGoals = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackGoals.txt"));
        var blackSets = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackSets.txt"));
        var blackTimeout = await FileExtensions.TryReadAllTextAsync(Path.Combine(_settings.DirectoryPath, "blackTimeouts.txt"));

        CurrentMatch = new MatchData
        {
            GreenName1 = greenName,
            GreenGoals = greenGoals,
            GreenSets = greenSets,
            GreenTimeout = greenTimeout,
            BlackName1 = blackName,
            BlackGoals = blackGoals,
            BlackSets = blackSets,
            BlackTimeout = blackTimeout,
        };
        CurrentMatch.PropertyChangedWithChangeset += OnCurrentMatch_PropertyChangedWithChangeset;

        return CurrentMatch;
    }

    private void OnCurrentMatch_PropertyChangedWithChangeset(object? sender, PropertyChangedWithChangesetEventArgs e)
    {
        if (string.IsNullOrEmpty(e.PropertyName))
        {
            return;
        }
        ApplyChanges(e.PropertyName, e.ChangeSet.After);
    }

    public void ApplyChanges(string changedField, object value)
    {
        var filepath = Path.Combine(_settings.DirectoryPath, changedField);
        filepath = Path.ChangeExtension(filepath, "txt");
        File.WriteAllText(filepath, value.ToString());
    }
}
