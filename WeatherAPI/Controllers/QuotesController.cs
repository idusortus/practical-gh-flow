using Microsoft.AspNetCore.Mvc;

namespace WeatherApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuotesController : ControllerBase
{
    private static readonly string[] Quotes = new[]
    {
        "The best way to predict the future is to invent it.",
        "Life is 10% what happens to us and 90% how we react to it.",
        "The only way to do great work is to love what you do.",
        "Success is not final, failure is not fatal: It is the courage to continue that counts.",
        "Believe you can and you're halfway there."
    };

    [HttpGet]
    public IActionResult GetRandomQuote()
    {
        var random = new Random();
        var quote = Quotes[random.Next(Quotes.Length)];
        return Ok(new { Quote = quote });
    }
}