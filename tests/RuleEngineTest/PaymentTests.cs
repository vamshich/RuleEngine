using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using OrderingApi.Controllers;
using RuleEngine.API.Business;
using RuleEngine.API.Services;
using RuleEngineAPI.Common.Interfaces;
using RuleEngineAPI.Common.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RuleEngineTest
{
    [TestFixture]
    public class PaymentTests
    {
        PaymentsController controller;
        Mock<IPaymentsService> mockPaymentsService;

        public PaymentTests()
        {
            controller = new PaymentsController(new PaymentsService(new PaymentsFactory()));
            mockPaymentsService = new Mock<IPaymentsService>();
        }

        [Test]
        public async Task Payment__For_Book_OK()
        {
            var expectedResult = "Duplicate packing slip for the royalty department is generated. Commission payment to the agent is generated.";
            var response = await controller.ProcessPayment(new Payment { Selection = "book" });

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public async Task Payment_For_Membership_OK()
        {
            var expectedResult = "Membership is activated. Email has been sent to owner about activation/upgrade.";
            var response = await controller.ProcessPayment(new Payment { Selection = "membership" });

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public async Task Payment_For_PhysicalProduct_OK()
        { 
           var expectedResult = "Packing slip for shipping is generated. Commission payment to the agent is generated.";
           var response = await controller.ProcessPayment(new Payment { Selection = "physical product" });

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public async Task Payment_For_Upgrade_OK()
        {
            var expectedResult = "Upgrade is applied. Email has been sent to owner about activation/upgrade.";

            var response = await controller.ProcessPayment(new Payment { Selection = "upgrade" });

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public async Task Payment_For_Video_OK()
        {
            var expectedResult = "Added a free “First Aid” video to the packing slip.";
            var response = await controller.ProcessPayment(new Payment { Selection = "learning to ski video" });

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public async Task Payment_InternalServerError()
        {
            mockPaymentsService.Setup(x => x.ProcessPayment(It.IsAny<string>()))
                .ThrowsAsync(new Exception());

            controller = new PaymentsController(mockPaymentsService.Object);
            var response = await controller.ProcessPayment(new Payment { Selection = "book" });

            var result = response as ObjectResult;

            Assert.AreEqual((int)HttpStatusCode.InternalServerError, result.StatusCode);
        }
    }
}