using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;

namespace RuleEngine.UI.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;
        private readonly HttpClient _httpClient;
        public PaymentController(ILogger<PaymentController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient();
        }

        public IActionResult Index(IFormCollection form)
        {
            var selection = form["PaymentType"].FirstOrDefault();

            HttpRequestMessage httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44318/payments"),
                Content = new StringContent(JsonConvert.SerializeObject(new { Selection = selection }), System.Text.Encoding.UTF8, "application/json")
            };

            var response = _httpClient.SendAsync(httpRequest).Result;

            if (response.IsSuccessStatusCode)
                ViewBag.Result = response.Content.ReadAsStringAsync().Result;

            return View();
        }

    }
}
