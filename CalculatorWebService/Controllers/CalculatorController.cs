using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary.SimpleCalculator;

namespace CalculatorWebService.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ISimpleCalculator _calculator = new SimpleCalculator();

        [HttpGet]
        [Route("api/calculator/add")]
        public IActionResult Add(int start, int amount)
        {
            int result = _calculator.Add(start, amount);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/calculator/subtract")]
        public IActionResult Subtract(int start, int amount)
        {
            int result = _calculator.Subtract(start, amount);
            return Ok(result);
        }
    }
}

