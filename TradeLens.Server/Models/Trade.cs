using System.ComponentModel.DataAnnotations;

namespace TradeLens.Server.Models
{
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
        public CurrencyPair Pair { get; set; }

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
}
