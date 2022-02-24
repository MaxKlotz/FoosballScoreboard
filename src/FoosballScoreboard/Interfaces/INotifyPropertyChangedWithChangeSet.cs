using System.ComponentModel;

namespace FoosballScoreboard.Forms.Interfaces
{

    public interface INotifyPropertyChangedWithChangeSet : INotifyPropertyChanged
    {
        public event PropertyChangedWithChangesetEventHandler? PropertyChangedWithChangeset;

        public delegate void PropertyChangedWithChangesetEventHandler(object? sender, PropertyChangedWithChangesetEventArgs e);
    }
}
