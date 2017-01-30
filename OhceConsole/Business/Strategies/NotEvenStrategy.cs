namespace OhceConsole
{
    public class NotEvenStrategy : InverterTemplate
    {
        private readonly string prefix = "IMPAR -";

        public override string Apply(string input)
        {
            return this.AddPrefix(this.prefix, input);
        }

        public override bool CanApply(string input)
        {
            if (this.Reverse(input) == input)
                return false;

            return input.Length%2 != 0;
        }

        public override int Order => 3;
    }
}
