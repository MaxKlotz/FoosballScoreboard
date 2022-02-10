using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoosballScoreboard.Interfaces;
public class MatchData : INotifyPropertyChanged
{
    private string _greenTimeout = String.Empty;

    public string GreenGoals { get; set; } = String.Empty;
    public string GreenSets { get; set; } = String.Empty;
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

    public string GreenName { get; set; } = String.Empty;
    public string BlackGoals { get; set; } = String.Empty;
    public string BlackSets { get; set; } = String.Empty;
    public string BlackTimeout { get; set; } = String.Empty;
    public string BlackName { get; set; } = String.Empty;

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
        GreenGoals = greenGoals++.ToString();
    }

    public void DecrementGreenGoals()
    {
        if (!int.TryParse(GreenGoals, out int greenGoals))
        {
            return;
        }
        GreenGoals = greenGoals--.ToString();
    }
}