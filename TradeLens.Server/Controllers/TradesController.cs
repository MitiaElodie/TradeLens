using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeLens.Server.Models;
using TradeLens.Server.Models.Dtos;
using TradeLens.Server.Services;

[Route("api/v1/[controller]")]
[ApiController]
public class TradesController : ControllerBase
{
    private readonly TradeLensDbContext _context;
    private readonly IMapper _mapper;
    private readonly TradeImportService _importService;

    public TradesController(TradeLensDbContext context, IMapper mapper, TradeImportService importService)
    {
        _context = context;
        _importService = importService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetTrades()
    {
        var trades = await _context.Trades.ToListAsync();
        var tradeDtos = _mapper.Map<List<TradeDto>>(trades);
        return Ok(tradeDtos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTrade([FromBody] TradeDto tradeDto)
    {
        _context.Trades.Add(_mapper.Map<Trade>(tradeDto));
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTrades), new { id = tradeDto.Id }, tradeDto);
    }

    [HttpPost("import")]
    public async Task<IActionResult> ImportTrades(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("File is missing or empty.");

        var tempPath = Path.GetTempFileName();
        using (var stream = System.IO.File.Create(tempPath))
        {
            await file.CopyToAsync(stream);
        }

        await _importService.ImportTradesFromCsv(tempPath);

        System.IO.File.Delete(tempPath);

        return Ok("Trades imported successfully.");
    }

}
