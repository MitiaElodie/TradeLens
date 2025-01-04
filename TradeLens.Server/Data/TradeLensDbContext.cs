using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class TradeLensDbContext : DbContext
{
    public DbSet<Trade> Trades { get; set; }

    public TradeLensDbContext(DbContextOptions<TradeLensDbContext> options)
        : base(options) { }
}

public enum TradeType { Trade, Backtest }
public enum H4Pattern {
    Deceleration,
    ThreeLegFibCompletion,
    FiveLegFibCompletion,
    BMWithBOS,
    BMWithoutBOS,
    BWWithBOS,
    BWWithoutBOS,
    HSWithBOS,
    HSWithoutBOS,
    InverseHSWithBOS,
    InverseHSWithoutBOS
}
public enum DailyPattern {
    BM1,
    BM2,
    BM3,
    BM4,
    BW1,
    BW2,
    BW3,
    BW4,
    HS,
    InverseHS,
    SmallPatternWithinPattern,
    BigPatternWithinPattern,
    Fakeout,
    HedgePosition,
}
public enum ResultType { Win, Loss, BE }
public enum CurrencyType {
    AUDCAD,
    AUDCHF,
    AUDJPY,
    AUDNZD,
    AUDUSD,
    CADCHF,
    CADJPY,
    CHFJPY,
    EURAUD,
    EURCAD,
    EURCHF,
    EURGBP,
    EURJPY,
    EURNZD,
    EURUSD,
    GBPAUD,
    GBPCAD,
    GBPCHF,
    GBPJPY,
    GBPNZD,
    GBPUSD,
    NZDCAD,
    NZDCHF,
    NZDJPY,
    NZDUSD,
    USDCAD,
    USDCHF,
    USDJPY,
    USDZAR,
    USOIL,
    XAGUSD,
    XAUUSD,
}

public class Trade
{
    public int Id { get; set; }
    public TradeType Type { get; set; } = TradeType.Trade;

    [Required]
    public H4Pattern H4Pattern { get; set; }

    [Required]
    required public string H4Screenshot { get; set; }

    [Required]
    public DailyPattern DailyPattern { get; set; }

    [Required]
    required public string DailyScreenshot { get; set; }

    [Required]
    required public string WeeklyScreenshot { get; set; }

    [Required]
    public bool WeeklyLastCandleClose { get; set; }

    [Required]
    public bool WeeklySupplyAndDemand { get; set; }

    [Required]
    public bool WeeklyMarketStructure { get; set; }

    [Required]
    public bool WeeklyFibonacci { get; set; }

    public double? Profit { get; set; }

    [Required]
    public DateTime EntryDate { get; set; }

    public DateTime? CloseDate { get; set; }

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
