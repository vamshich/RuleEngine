namespace RuleEngineAPI.Common.Interfaces
{
    public interface IPaymentsFactory
    {
        IPaymentsProcessor GetProcessor(string selection);
    }
}