namespace FoosballScoreboard.BusinessLogic.Interfaces;
public class PropertyChangedChangeset
{
    public object Before { get; }
    public object After { get; }

    public PropertyChangedChangeset(object before, object after)
    {
        Before = before;
        After = after;
    }
}

