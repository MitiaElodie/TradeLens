using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TradeLens.Server.BusinessLogic;
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
    private readonly TradeBusinessLogic _businessLogic;

    public TradesController(TradeLensDbContext context, IMapper mapper, TradeImportService importService, TradeBusinessLogic tradeBusinessLogic)
    {
        _context = context;
        _importService = importService;
        _mapper = mapper;
        _businessLogic = tradeBusinessLogic;
    }

    [HttpGet]
    public async Task<List<TradeDto>> GetTrades()
    {
        return await _businessLogic.GetTrades();
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
