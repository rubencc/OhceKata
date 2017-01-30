using System;

namespace OhceConsole
{
    public class MinStrategy : InverterTemplate
    {
        public override string Apply(string input)
        {
            return this.AddSuffix(DateTime.Now.ToShortTimeString(), input);
        }

        public override bool CanApply(string input)
        {
            return DateTime.Now.Minute %2 == 0;
        }

        public override int Order => 4;
    }
}
