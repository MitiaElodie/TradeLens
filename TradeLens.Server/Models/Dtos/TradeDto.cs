namespace TradeLens.Server.Models.Dtos
{
    public class TradeDto
    {
        public int? Id { get; set; } // Nullable for creation, populated for updates

        public string Type { get; set; } // Enum as string (e.g., "Trade", "Backtest")

        public string H4Pattern { get; set; } // Enum as string (e.g., "Deceleration")

        public string H4Image { get; set; } // Link to the H4 image

        public string DailyPattern { get; set; } // Enum as string (e.g., "BullishM")

        public string DailyImage { get; set; } // Link to the daily image

        public string WeeklyImage { get; set; } // Link to the weekly image

        public bool? WeeklyCandleClose { get; set; } // Nullable boolean

        public bool? WeeklySupplyAndDemand { get; set; } // Nullable boolean

        public bool? WeeklyMarketStructure { get; set; } // Nullable boolean

        public bool? WeeklyFibonacci { get; set; } // Nullable boolean

        public string Result { get; set; } // Enum as string (e.g., "Win", "Loss", "BE")

        public bool? Missed { get; set; } // Nullable boolean

        public string Note { get; set; } // Notes about the trade

        public decimal? RiskReward { get; set; } // Nullable number for risk/reward ratio

        public DateTime? EntryDate { get; set; } // Entry date with time

        public DateTime? CloseDate { get; set; } // Close date with time

        public string Currency { get; set; } // Enum as string (e.g., "EURUSD")
    }
}
