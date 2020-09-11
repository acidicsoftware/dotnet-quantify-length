using Quantify.Repository.Enum;

namespace Quantify.Length
{
    /// <summary>
    /// A quantity that represents a length with one of the units defined in <see cref="Unit"/>.
    /// </summary>
    /// <remarks>
    /// This quantity represents a length where the value is defined by a <see cref="double"/>.
    /// 
    /// As opposed to <see cref="PreciseLength"/>, this length quantity is optimized for performance and not precision. Round-off errors might occure.
    /// </remarks>
    public sealed class Length : Quantity<double, Unit, Length>
    {
        private Length(double value, Unit unit, UnitRepository<Unit> unitRepository) : base(value, unit, unitRepository)
        {
        }

        private Length(double value, Unit unit, UnitRepository<Unit> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, Unit> valueConverter) : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {
        }

        /// <summary>
        /// Created a new instance of <see cref="Length"/> with a value and a unit.
        /// </summary>
        /// <param name="value">The value of the quantity.</param>
        /// <param name="unit">The unit of the quantity.</param>
        /// <returns>A new quantity.</returns>
        public static Length Create(double value, Unit unit)
        {
            var unitRepository = new EnumUnitRepository<Unit>();
            return new Length(value, unit, unitRepository);
        }

        protected override Length CreateInstance(double value, Unit unit, UnitRepository<Unit> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, Unit> valueConverter)
        {
            return new Length(value, unit, unitRepository, valueCalculator, valueConverter);
        }
    }
}