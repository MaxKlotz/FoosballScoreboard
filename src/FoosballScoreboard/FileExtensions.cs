namespace FoosballScoreboard.Forms;
public static class FileExtensions
{
    public static string TryReadAllText(string filepath, string defaultResult = "")
    {
        try
        {
            return File.ReadAllText(filepath);
        }
        catch (FileNotFoundException)
        {
            return defaultResult;
        }
    }

    public static async Task<string> TryReadAllTextAsync(string path, string defaultResult = "",
        CancellationToken cancellationToken = default)
    {
        try
        {
            return await File.ReadAllTextAsync(path, cancellationToken);
        }
        catch (Exception)
        {
            return await Task.FromResult(defaultResult);
        }
    }
}
