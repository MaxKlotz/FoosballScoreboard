using System.ComponentModel;
using System.Runtime.CompilerServices;
using static FoosballScoreboard.BusinessLogic.Interfaces.INotifyPropertyChangedWithChangeSet;

namespace FoosballScoreboard.BusinessLogic.Interfaces;
public class MatchData : INotifyPropertyChangedWithChangeSet
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event PropertyChangedWithChangesetEventHandler? PropertyChangedWithChangeset;

    private static readonly Func<int, int> increment = (x) => x += 1;
    private static readonly Func<int, int> decrement = (x) => x -= 1;

    private string _greenTimeout = string.Empty;
    private string _greenGoals = string.Empty;
    private string _greenSets = string.Empty;
    private string _greenName1 = string.Empty;
    private string _greenName2 = string.Empty;
    private string _blackGoals = string.Empty;
    private string _blackSets = string.Empty;
    private string _blackTimeout = string.Empty;
    private string _blackName1 = string.Empty;
    private string _blackName2 = string.Empty;

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
                var changeset = new PropertyChangedChangeset(_greenGoals, value);
                _greenGoals = value;
                NotifyPropertyChanged(changeset);
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
                var changeset = new PropertyChangedChangeset(_greenSets, value);
                _greenSets = value;
                NotifyPropertyChanged(changeset);
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
                var changeset = new PropertyChangedChangeset(_greenTimeout, value);
                _greenTimeout = value;
                NotifyPropertyChanged(changeset);
            }
        }
    }

    public string GreenName1
    {
        get
        {
            return _greenName1;
        }
        set
        {
            if (value != _greenName1)
            {
                var changeset = new PropertyChangedChangeset(_greenName1, value);
                _greenName1 = value;
                NotifyPropertyChanged(changeset);
            }
        }
    }

    public string GreenName2
    {
        get
        {
            return _greenName2;
        }
        set
        {
            if (value != _greenName2)
            {
                var changeset = new PropertyChangedChangeset(_greenName2, value);
                _greenName2 = value;
                NotifyPropertyChanged(changeset);
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
                var changeset = new PropertyChangedChangeset(_blackGoals, value);
                _blackGoals = value;
                NotifyPropertyChanged(changeset);
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
                var changeset = new PropertyChangedChangeset(_blackSets, value);
                _blackSets = value;
                NotifyPropertyChanged(changeset);
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
                var changeset = new PropertyChangedChangeset(_blackTimeout, value);
                _blackTimeout = value;
                NotifyPropertyChanged(changeset);
            }
        }
    }

    public string BlackName1
    {
        get
        {
            return _blackName1;
        }
        set
        {
            if (value != _blackName1)
            {
                var changeset = new PropertyChangedChangeset(_blackName1, value);
                _blackName1 = value;
                NotifyPropertyChanged(changeset);
            }
        }
    }

    public string BlackName2
    {
        get
        {
            return _blackName2;
        }
        set
        {
            if (value != _blackName2)
            {
                var changeset = new PropertyChangedChangeset(_blackName2, value);
                _blackName2 = value;
                NotifyPropertyChanged(changeset);
            }
        }
    }

    public async Task ResetScore()
    {
        GreenGoals = "0";
        BlackGoals = "0";
        GreenSets = "0";
        BlackSets = "0";
        await Task.FromResult(0);
    }

    private void NotifyPropertyChanged(PropertyChangedChangeset changeset, [CallerMemberName] string propertyName = "")
    {
        PropertyChangedWithChangeset?.Invoke(this, new PropertyChangedWithChangesetEventArgs(propertyName, changeset));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void IncrementGreenGoals()
    {
        GreenGoals = IncrementString(GreenGoals, increment);
    }

    public void DecrementGreenGoals()
    {
        GreenGoals = IncrementString(GreenGoals, decrement);
    }

    public void IncrementBlackGoals()
    {
        BlackGoals = IncrementString(BlackGoals, increment);
    }

    public void DecrementBlackGoals()
    {
        BlackGoals = IncrementString(BlackGoals, decrement);
    }

    public void IncrementGreenSets()
    {
        GreenSets = IncrementString(GreenSets, increment);
    }

    public void DecrementGreenSets()
    {
        GreenSets = IncrementString(GreenSets, decrement);
    
    }
    public void IncrementBlackSets()
    {
        BlackSets = IncrementString(BlackSets, increment);
    }

    public void DecrementBlackSets()
    {
        BlackSets = IncrementString(BlackSets, decrement);
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