using RuleEngine.API.Business.Helpers;
using RuleEngineAPI.Common.Interfaces;
using System.Threading.Tasks;

namespace OrderingApi.Business.Processors
{
    public class MemebershipProcessor : IPaymentsProcessor
    {
        public async Task<string> Process()
        {
             return  $"{await MembershipHelper.Process()} {await EmailHelper.Process()}";
        }
    }
}