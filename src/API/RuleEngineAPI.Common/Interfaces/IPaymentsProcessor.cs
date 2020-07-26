using System.Threading.Tasks;

namespace RuleEngineAPI.Common.Interfaces
{
    public interface IPaymentsProcessor
    {
        Task<string> Process();
    }
}