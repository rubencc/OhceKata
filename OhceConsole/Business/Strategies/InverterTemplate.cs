using System;
using System.Text;
using System.Text.RegularExpressions;

namespace OhceConsole
{
    public abstract class InverterTemplate : IInverterStrategy
    {
        private readonly Regex fortmat = new Regex(@"^[a-zA-Z]+$");

        public abstract string Apply(string input);

        public abstract bool CanApply(string input);
        public abstract int Order { get; }

        protected bool IsValid(string input)
        {
            return this.fortmat.IsMatch(input);
        }

        protected string Reverse(string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            StringBuilder sb = new StringBuilder();

            foreach (var c in chars)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }

        protected string AddPrefix(string prefix, string input)
        {
            return $"{prefix} {input}";
        }

        protected string AddSuffix(string suffix, string input)
        {
            return $"{input} {suffix}";
        }
    }
}
