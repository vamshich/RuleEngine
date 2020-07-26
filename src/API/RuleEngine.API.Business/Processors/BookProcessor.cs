using RuleEngine.API.Business.Helpers;
using RuleEngineAPI.Common.Interfaces;
using System.Threading.Tasks;

namespace OrderingApi.Business.Processors
{
    public class BookProcessor : IPaymentsProcessor
    {
        public async Task<string> Process()
        {
            return $"{await RoyaltyHelper.Process()} {await CommissionHelper.Process()}";
        }
    }
}