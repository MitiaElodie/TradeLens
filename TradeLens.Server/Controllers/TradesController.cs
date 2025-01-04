using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeLens.Server.Models;
using TradeLens.Server.Models.Dtos;

[Route("api/[controller]")]
[ApiController]
public class TradesController : ControllerBase
{
    private readonly TradeLensDbContext _context;
    private readonly IMapper _mapper;

    public TradesController(TradeLensDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetTrades()
    {
        var trades = await _context.Trades.ToListAsync();
        return Ok(trades);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTrade([FromBody] TradeDto tradeDto)
    {
        _context.Trades.Add(_mapper.Map<Trade>(tradeDto));
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTrades), new { id = tradeDto.Id }, tradeDto);
    }
}
