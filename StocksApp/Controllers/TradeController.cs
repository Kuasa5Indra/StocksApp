using Microsoft.AspNetCore.Mvc;
using ExternalServices;
using ExternalServices.Interfaces;
using StocksApp.Options;
using Microsoft.Extensions.Options;

namespace StocksApp.Controllers
{
    [Route("{controller}/{action}")]
    public class TradeController : Controller
    {
        private readonly TradingOptions options;
        private readonly IFinnhubService _finnhubService;

        public TradeController(IOptions<TradingOptions> tradingOptions)
        {
            options = tradingOptions.Value;
            _finnhubService = new FinnhubService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
