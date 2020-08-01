using Quantify.Repository.Enum;

namespace Quantify.Length
{
    public sealed class Length : Quantity<double, Unit, Length>
    {
        private Length(double value, Unit unit, QuantityFactory<double, Unit, Length> quantityFactory, UnitRepository<double, Unit> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, Unit> valueConverter)
            : base(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter)
        {

        }

        public static Length Create(double value, Unit unit)
        {
            var quantityFactory = new LengthQuantityFactory();
            var unitRepository = EnumUnitRepository<double, Unit>.CreateInstance();
            var valueCalculator = ValueCalculatorFactory.Create<double>();
            var valueConverter = new ValueConverter<double, Unit>(unitRepository, valueCalculator);
            return new Length(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
        }

        private class LengthQuantityFactory : QuantityFactory<double, Unit, Length>
        {
            Length QuantityFactory<double, Unit, Length>.CreateInstance(double value, Unit unit, QuantityFactory<double, Unit, Length> quantityFactory, UnitRepository<double, Unit> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, Unit> valueConverter)
            {
                return new Length(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
            }
        }
    }
}