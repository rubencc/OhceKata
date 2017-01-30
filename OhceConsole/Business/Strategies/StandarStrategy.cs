namespace OhceConsole
{
    public class StandarStrategy : InverterTemplate
    {
        public override string Apply(string input)
        {
            return this.Reverse(input);
        }

        public override bool CanApply(string input)
        {
            return true;
        }

        public override int Order => 1;
    }
}
