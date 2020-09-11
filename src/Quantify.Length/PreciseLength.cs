using Quantify.Repository.Enum;

namespace Quantify.Length
{
    /// <summary>
    /// A quantity that represents a precise length with one of the units defined in <see cref="Unit"/>.
    /// </summary>
    /// <remarks>
    /// As the name implies, this length quantity is considered precise, since the value of the quantity is defined by a <see cref="decimal"/>.
    /// 
    /// The benefit of using <see cref="decimal"/> is that this type supports a large number of significant integral and fractional digits, while also avoiding round-off errors. The downside is the significant performance impact that comes from doing calculations with <see cref="decimal"/> as opposed to for example <see cref="double"/>.
    /// </remarks>
    public sealed class PreciseLength : Quantity<decimal, Unit, PreciseLength>
    {
        private PreciseLength(decimal value, Unit unit, UnitRepository<Unit> unitRepository) : base(value, unit, unitRepository)
        {
        }

        private PreciseLength(decimal value, Unit unit, UnitRepository<Unit> unitRepository, ValueCalculator<decimal> valueCalculator, ValueConverter<decimal, Unit> valueConverter) : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {
        }

        /// <summary>
        /// Created a new instance of <see cref="PreciseLength"/> with a value and a unit.
        /// </summary>
        /// <param name="value">The value of the quantity.</param>
        /// <param name="unit">The unit of the quantity.</param>
        /// <returns>A new quantity.</returns>
        public static PreciseLength Create(decimal value, Unit unit)
        {
            var unitRepository = new EnumUnitRepository<Unit>();
            return new PreciseLength(value, unit, unitRepository);
        }

        protected override PreciseLength CreateInstance(decimal value, Unit unit, UnitRepository<Unit> unitRepository, ValueCalculator<decimal> valueCalculator, ValueConverter<decimal, Unit> valueConverter)
        {
            return new PreciseLength(value, unit, unitRepository, valueCalculator, valueConverter);
        }
    }
}