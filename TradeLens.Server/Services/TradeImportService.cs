using System.Globalization;
using AutoMapper;
using CsvHelper;
using CsvHelper.Configuration;
using TradeLens.Server.Models;

namespace TradeLens.Server.Services
{
    public class TradeImportService
    {
        private readonly TradeLensDbContext _context;
        private readonly IMapper _mapper;

        public TradeImportService(TradeLensDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ImportTradesFromCsv(string filepath)
        {
            var tradesToAdd = new List<Trade>();

            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            }))
            {
                var records = csv.GetRecords<TradeCsvRecord>();

                foreach (var record in records)
                {
                    var entryDate = ParseMonthToEntryDate(record.Month);

                    var trade = _mapper.Map<Trade>(record);
                    trade.EntryDate = entryDate;

                    tradesToAdd.Add(trade);
                }
            }
            // Save the trades to the database
            _context.Trades.AddRange(tradesToAdd);
            await _context.SaveChangesAsync();
        }

        private DateTime ParseMonthToEntryDate(string month)
        {
            // Convert "January", "February", etc., to the first day of that month in 2023
            var unspecifiedDate = DateTime.ParseExact($"01 {month} 2023", "dd MMMM yyyy", CultureInfo.InvariantCulture);

            // Convert to UTC
            return DateTime.SpecifyKind(unspecifiedDate, DateTimeKind.Utc);
        }
    }
}

public class TradeCsvRecord
{

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

    public String? Month { get; set; } // Entry date with time

    public string Pair { get; set; } // Enum as string (e.g., "EURUSD")
}