﻿using OrderingApi.Business.Processors;
using RuleEngineAPI.Common.Interfaces;

namespace RuleEngine.API.Business
{
    public class PaymentsFactory : IPaymentsFactory
    {
        public IPaymentsProcessor GetProcessor(string selection)
        {
            switch (selection?.ToLower())
            {
                case "physical product":
                    return new ProductProcessor();

                case "book":
                    return new BookProcessor();

                case "membership":
                    return new MemebershipProcessor();

                case "upgrade":
                    return new UpgradeMembershipProcessor();

                case "learning to ski video":
                    return new VideoProcessor();

                default:
                    return null;
            }
        }
    }
}