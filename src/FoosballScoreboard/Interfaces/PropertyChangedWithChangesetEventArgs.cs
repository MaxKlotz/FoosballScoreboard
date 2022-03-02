namespace FoosballScoreboard.Forms.Interfaces
{
    public class PropertyChangedWithChangesetEventArgs
    {
        public string PropertyName { get; init; }
        public PropertyChangedChangeset ChangeSet { get; init; }

        public PropertyChangedWithChangesetEventArgs(string propertyName, PropertyChangedChangeset changeSet)
        {
            PropertyName = propertyName;
            ChangeSet = changeSet;
        }
    }
}
