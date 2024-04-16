using Spectre.Console.Cli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCostCli.Commands.CarbonByResource
{
    public class CarbonByResourceCommand : AsyncCommand<CarbonByResourceSettings>
    {
        public override Task<int> ExecuteAsync(CommandContext context, CarbonByResourceSettings settings)
        {
            throw new NotImplementedException();
        }
    }
}
