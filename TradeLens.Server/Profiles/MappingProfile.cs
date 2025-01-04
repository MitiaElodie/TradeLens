namespace TradeLens.Server.Profiles
{
    using AutoMapper;
    using TradeLens.Server.Models.Dtos;
    using TradeLens.Server.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Trade, TradeDto>()
                .ForMember(dest => dest.H4Pattern, opt => opt.MapFrom(src => src.H4Pattern.ToString()))
                .ForMember(dest => dest.DailyPattern, opt => opt.MapFrom(src => src.DailyPattern.ToString()))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result.ToString()))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Currency.ToString()));

            CreateMap<TradeDto, Trade>()
                .ForMember(dest => dest.H4Pattern, opt => opt.MapFrom(src => Enum.Parse<H4Pattern>(src.H4Pattern)))
                .ForMember(dest => dest.DailyPattern, opt => opt.MapFrom(src => Enum.Parse<DailyPattern>(src.DailyPattern)))
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => Enum.Parse<ResultType>(src.Result)))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => Enum.Parse<TradeType>(src.Type)))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => Enum.Parse<CurrencyType>(src.Currency)));
        }
    }

}
