﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TradeLens.Server.Models.Dtos;

namespace TradeLens.Server.BusinessLogic
{
    public class TradeBusinessLogic
    {

        private readonly TradeLensDbContext _context;
        private readonly IMapper _mapper;

        public TradeBusinessLogic(TradeLensDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TradeDto>> GetTrades()
        {
            var trades = await _context.Trades.ToListAsync();
            return _mapper.Map<List<TradeDto>>(trades);
        }
    }
}
