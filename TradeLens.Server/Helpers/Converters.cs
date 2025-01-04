using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TradeLens.Server.Helpers
{
    public class EnumToStringConverter<TEnum> : ValueConverter<TEnum, string>
    where TEnum : struct, Enum
    {
        public EnumToStringConverter()
            : base(
                enumValue => enumValue.ToString(),
                stringValue => (TEnum)Enum.Parse(typeof(TEnum), stringValue))
        {
        }
    }
}
