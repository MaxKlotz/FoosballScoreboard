using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FoosballScoreboard.BusinessLogic.Interfaces;

public interface INotifyPropertyChangedWithChangeSet : INotifyPropertyChanged
{
    public event PropertyChangedWithChangesetEventHandler? PropertyChangedWithChangeset;

    public delegate void PropertyChangedWithChangesetEventHandler(object? sender, PropertyChangedWithChangesetEventArgs e);
}

