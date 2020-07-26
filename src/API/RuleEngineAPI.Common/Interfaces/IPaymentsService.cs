using System.Threading.Tasks;

namespace RuleEngineAPI.Common.Interfaces
{
    public interface IPaymentsService
    {
        Task<string> ProcessPayment(string selection);
    }
}