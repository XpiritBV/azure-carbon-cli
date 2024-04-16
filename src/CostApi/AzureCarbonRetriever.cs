using AzureCostCli.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCostCli.CostApi
{
    public class AzureCarbonRetriever : ICarbonRetriever
    {
        public string CostApiAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<IEnumerable<CarbonItem>> RetrieveCarbon(bool includeDebugOutput, Scope scope)
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> RetrieveSubscription(bool includeDebugOutput, Guid subscriptionId)
        {
            throw new NotImplementedException();
        }
    }
}
