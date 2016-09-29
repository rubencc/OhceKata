namespace OhceConsole.Business.Strategies
{
    public interface IOhceStrategy
    {
        string GetOhceResponse(string input);
        bool CanApply(string input);
    }
}
