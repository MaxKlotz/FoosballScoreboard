using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoosballScoreboard.Interfaces;
public class MatchData : INotifyPropertyChanged
{
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