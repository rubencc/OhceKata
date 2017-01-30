namespace OhceConsole
{
    public class PalindromeStrategy : InverterTemplate
    {
        private readonly string prefix = "Wow!";

        public override string Apply(string input)
        {
            return this.AddPrefix(this.prefix, input);
        }

        public override bool CanApply(string input)
        {
            return this.Reverse(input) == input;
        }

        public override int Order => 2;
    }
}
