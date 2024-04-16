using AzureCostCli.Commands;

namespace AzureCostCli.CostApi;

public interface ICarbonRetriever
{
    public string CostApiAddress { get; set; }
    
    Task<Subscription> RetrieveSubscription(bool includeDebugOutput, Guid subscriptionId);
    
    Task<IEnumerable<CarbonItem>> RetrieveCarbon(bool includeDebugOutput, Scope scope);
}



