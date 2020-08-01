using Quantify.Repository.Enum;

namespace Quantify.Length
{
    public sealed class PreciseLength : Quantity<decimal, Unit, PreciseLength>
    {
        private PreciseLength(decimal value, Unit unit, QuantityFactory<decimal, Unit, PreciseLength> quantityFactory, UnitRepository<decimal, Unit> unitRepository, ValueCalculator<decimal> valueCalculator, IValueConverter<decimal, Unit> valueConverter)
            : base(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter)
        {

        }

        public static PreciseLength Create(decimal value, Unit unit)
        {
            var quantityFactory = new PreciseLengthQuantityFactory();
            var unitRepository = EnumUnitRepository<decimal, Unit>.CreateInstance();
            var valueCalculator = ValueCalculatorFactory.Create<decimal>();
            var valueConverter = new ValueConverter<decimal, Unit>(unitRepository, valueCalculator);
            return new PreciseLength(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
        }

        private class PreciseLengthQuantityFactory : QuantityFactory<decimal, Unit, PreciseLength>
        {
            PreciseLength QuantityFactory<decimal, Unit, PreciseLength>.CreateInstance(decimal value, Unit unit, QuantityFactory<decimal, Unit, PreciseLength> quantityFactory, UnitRepository<decimal, Unit> unitRepository, ValueCalculator<decimal> valueCalculator, IValueConverter<decimal, Unit> valueConverter)
            {
                return new PreciseLength(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
            }
        }
    }
}