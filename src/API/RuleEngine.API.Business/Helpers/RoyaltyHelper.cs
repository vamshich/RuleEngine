using System.Threading.Tasks;

namespace RuleEngine.API.Business.Helpers
{
    public static class RoyaltyHelper
    {
        public static async Task<string> Process()
        {
            return "Duplicate packing slip for the royalty department is generated.";
        }
    }
}