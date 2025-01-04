using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TradesController : ControllerBase
{
    private readonly TradeLensDbContext _context;

    public TradesController(TradeLensDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetTrades()
    {
        var trades = await _context.Trades.ToListAsync();
        return Ok(trades);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTrade([FromBody] Trade trade)
    {
        _context.Trades.Add(trade);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTrades), new { id = trade.Id }, trade);
    }
}
