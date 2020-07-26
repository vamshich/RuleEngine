using System.Threading.Tasks;

namespace RuleEngine.API.Business.Helpers
{
    public static class EmailHelper
    {
        public static async Task<string> Process()
        {
            return "Email has been sent to owner about activation/upgrade.";
        }
    }
}