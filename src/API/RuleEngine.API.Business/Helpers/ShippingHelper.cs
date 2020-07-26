using System.Threading.Tasks;

namespace RuleEngine.API.Business.Helpers
{
    public static class ShippingHelper
    {
        public static async Task<string> Process()
        {
            return "Packing slip for shipping is generated.";
        }
    }
}