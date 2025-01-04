using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class TradeLensDbContext : DbContext
{
    public DbSet<Trade> Trades { get; set; }

    public TradeLensDbContext(DbContextOptions<TradeLensDbContext> options)
        : base(options) { }
}

public enum TradeType { Trade, Backtest }
public enum H4Confirmation { Deceleration, ThreeLegCompletion, FiveLegCompletion }
public enum DailyConfirmation { BullishM, BearishW, HeadAndShoulder }
public enum ResultType { Win, Loss, BE }
public enum CurrencyType { EURUSD, USDCAD, EURGBP }

public class Trade
{
    public int Id { get; set; }
    public TradeType Type { get; set; } = TradeType.Trade;

    [Required]
    public H4Confirmation H4Confirmation { get; set; }

    [Required]
    required public string H4Image { get; set; }

    [Required]
    public DailyConfirmation DailyConfirmation { get; set; }

    [Required]
    required public string DailyImage { get; set; }

    [Required]
    required public string WeeklyImage { get; set; }

    [Required]
    public bool WeeklyCandleClose { get; set; }

    [Required]
    public bool WeeklySupplyAndDemand { get; set; }

    [Required]
    public bool WeeklyMarketStructure { get; set; }

    [Required]
    public bool WeeklyFibonacci { get; set; }

    [Required]
    public double RiskReward { get; set; }

    [Required]
    public DateTime EntryDate { get; set; }

    [Required]
    public DateTime CloseDate { get; set; }

    [Required]
    public CurrencyType Currency { get; set; }

    public bool? WeeklyHighLow { get; set; }
    public bool? WeeklyPattern { get; set; }
    public bool? WeeklyIC { get; set; }
    public bool? WeeklyFibCompletion { get; set; }
    public bool? DailyBreakAndRetest { get; set; }
    public bool? DailySupplyAndDemand { get; set; }
    public bool? DailyNewActionFakeout { get; set; }
    public ResultType? Result { get; set; }
    public bool Missed { get; set; } = false;
    public string? Note { get; set; }
}
