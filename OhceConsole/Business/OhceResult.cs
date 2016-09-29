using System;
using System.Collections.Generic;
using OhceConsole.Business.Strategies;

namespace OhceConsole.Business
{
    public class OhceResult : IOhceResult
    {
        private readonly List<IOhceStrategy> strategies;

        public OhceResult(List<IOhceStrategy> strategies)
        {
            if (strategies == null) throw new ArgumentNullException(nameof(strategies));
            this.strategies = new List<IOhceStrategy>();
            this.strategies.AddRange(strategies);
        }

        public OhceResult()
        {
            this.strategies = new List<IOhceStrategy>();
        }

        public string GetOhceResponse(string input)
        {
            throw new NotImplementedException();
        }
    }
}
