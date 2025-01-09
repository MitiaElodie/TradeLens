namespace TradeLens.Server.Models.Dtos
{
    public class TradeDto
    {
        public int? Id { get; set; } // Nullable for creation, populated for updates

        public string Type { get; set; } = TradeType.Trade.ToString();

        public string H4Pattern { get; set; } // Enum as string (e.g., "Deceleration")

        public string H4Screenshot { get; set; } // Link to the H4 Screenshot

        public string DailyPattern { get; set; } // Enum as string (e.g., "BullishM")

        public string DailyScreenshot { get; set; } // Link to the daily Screenshot

        public string WeeklyScreenshot { get; set; } // Link to the weekly Screenshot

        public bool? WeeklyLastCandleClose { get; set; } // Nullable boolean

        public bool? WeeklySupplyAndDemand { get; set; } // Nullable boolean

        public bool? WeeklyMarketStructure { get; set; } // Nullable boolean

        public bool? WeeklyFibonacci { get; set; } // Nullable boolean

        public string Result { get; set; } // Enum as string (e.g., "Win", "Loss", "BE")

        public bool? Missed { get; set; } // Nullable boolean

        public string Note { get; set; } // Notes about the trade

        public decimal? Profit { get; set; } // Nullable number for risk/reward ratio

        public DateTime? EntryDate { get; set; } // Entry date with time

        public DateTime? CloseDate { get; set; } // Close date with time

        public string Pair { get; set; } // Enum as string (e.g., "EURUSD")
        public bool? WeeklyHighLow { get; set; }
        public bool? WeeklyPattern { get; set; }
        public bool? WeeklyIC { get; set; }
        public bool? WeeklyFibCompletion { get; set; }
        public bool? DailyBreakAndRetest { get; set; }
        public bool? DailySupplyAndDemand { get; set; }
        public bool? DailyNewActionFakeout { get; set; }
    }
}
