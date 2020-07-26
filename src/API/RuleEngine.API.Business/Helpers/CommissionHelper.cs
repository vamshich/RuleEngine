using System.Threading.Tasks;

namespace RuleEngine.API.Business.Helpers
{
    public static class CommissionHelper
    {
        public static async Task<string> Process()
        {
            return "Commission payment to the agent is generated.";
        }
    }
}