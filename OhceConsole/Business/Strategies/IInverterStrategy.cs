namespace OhceConsole
{
    public interface IInverterStrategy
    {
        string Apply(string input);
        bool CanApply(string input);
        int Order { get; }
    }
}
