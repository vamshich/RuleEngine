using RuleEngine.API.Business.Helpers;
using RuleEngineAPI.Common.Interfaces;
using System.Threading.Tasks;

namespace OrderingApi.Business.Processors
{
    public class UpgradeMembershipProcessor : IPaymentsProcessor
    {
        public async Task<string> Process()
        {
            return $"{await UpgradeHelper.Process()} {await EmailHelper.Process()}";
        }
    }
}