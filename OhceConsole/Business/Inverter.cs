using System;
using System.Collections.Generic;
using System.Linq;

namespace OhceConsole
{
    public class Inverter : IInverter
    {
        private readonly List<IInverterStrategy> strategies;

        public Inverter(IEnumerable<IInverterStrategy> strategies)
        {
            if (strategies == null) throw new ArgumentNullException(nameof(strategies));
            this.strategies = strategies.OrderBy(item => item.Order).ToList();
        }

        public string Transform(string input)
        {
            string temp = input;

            foreach (var strategy in this.strategies.Where(item => item.CanApply(input)))
            {
                temp = strategy.Apply(temp);
            }


            return temp;
        }
    }
}
