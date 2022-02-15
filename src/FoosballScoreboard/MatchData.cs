using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoosballScoreboard.Interfaces;
public class MatchData : INotifyPropertyChanged
{
    private static readonly Func<int, int> increment = (x) => x += 1;
    private static readonly Func<int, int> decrement = (x) => x -= 1;

    private string _greenTimeout = string.Empty;
    private string _greenGoals = string.Empty;
    private string _greenSets = string.Empty;
    private string _greenName = string.Empty;
    private string _blackGoals = string.Empty;
    private string _blackSets = string.Empty;
    private string _blackTimeout = string.Empty;
    private string _blackName = string.Empty;

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
                _greenGoals = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string GreenSets
    {
        get
        {
            return _greenSets;
        }
        set
        {
            if (value != _greenSets)
            {
                _greenSets = value;
                NotifyPropertyChanged();
            }
        }
    }
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
                _greenTimeout = value;
                NotifyPropertyChanged();
            }
        }
    }

    public string GreenName
    {
        get
        {
            return _greenName;
        }
        set
        {
            if (value != _greenName)
            {
                _greenName = value;
                NotifyPropertyChanged();
            }
        }
    }

    public string BlackGoals
    {
        get
        {
            return _blackGoals;
        }
        set
        {
            if (value != _blackGoals)
            {
                _blackGoals = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string BlackSets
    {
        get
        {
            return _blackSets;
        }
        set
        {
            if (value != _blackSets)
            {
                _blackSets = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string BlackTimeout
    {
        get
        {
            return _blackTimeout;
        }
        set
        {
            if (value != _blackTimeout)
            {
                _blackTimeout = value;
                NotifyPropertyChanged();
            }
        }
    }

    internal async Task ResetScore()
    {
        GreenGoals = "0";
        BlackGoals = "0";
        GreenSets = "0";
        BlackSets = "0";
        await Task.FromResult(0);
    }

    public string BlackName
    {
        get
        {
            return _blackName;
        }
        set
        {
            if (value != _blackName)
            {
                _blackName = value;
                NotifyPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    internal void IncrementGreenGoals()
    {
        GreenGoals = IncrementString(GreenGoals, increment);
    }

    internal void DecrementGreenGoals()
    {
        GreenGoals = IncrementString(GreenGoals, decrement);
    }

    internal void IncrementBlackGoals()
    {
        BlackGoals = IncrementString(BlackGoals, increment);
    }

    internal void DecrementBlackGoals()
    {
        BlackGoals = IncrementString(BlackGoals, decrement);
    }

    private static string IncrementString(string value, Func<int, int> operation)
    {
        if (!int.TryParse(value, out int parsedValue))
        {
            return value;
        }
        return operation(parsedValue).ToString();
    }
}