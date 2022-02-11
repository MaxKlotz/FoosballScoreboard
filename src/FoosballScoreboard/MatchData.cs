using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoosballScoreboard.Interfaces;
public class MatchData : INotifyPropertyChanged
{
    private string _greenTimeout = string.Empty;
    private string _greenGoals = string.Empty;

    public string GreenGoals
    {
        get
        {
            return _greenGoals;
        }
        set
        {
            if (value != _greenGoals)
            {
                _greenGoals = value; NotifyPropertyChanged();
            }
        }
    }
    public string GreenSets { get; set; } = string.Empty;
    public string GreenTimeout
    {
        get
        {
            return _greenTimeout;
        }
        set
        {
            if (value != _greenTimeout)
            {
                _greenTimeout = value; NotifyPropertyChanged();
            }
        }
    }

    public string GreenName { get; set; } = string.Empty;
    public string BlackGoals { get; set; } = string.Empty;
    public string BlackSets { get; set; } = string.Empty;
    public string BlackTimeout { get; set; } = string.Empty;
    public string BlackName { get; set; } = string.Empty;

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void IncrementGreenGoals()
    {
        if (!int.TryParse(GreenGoals, out int greenGoals))
        {
            return;
        }
        greenGoals++;
        GreenGoals = greenGoals.ToString();
    }

    public void DecrementGreenGoals()
    {
        if (!int.TryParse(GreenGoals, out int greenGoals))
        {
            return;
        }
        greenGoals--;
        GreenGoals = greenGoals.ToString();
    }
}