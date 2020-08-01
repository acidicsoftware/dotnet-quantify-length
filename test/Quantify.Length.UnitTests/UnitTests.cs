using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Repository.Enum.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantify.Length.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void WHEN_ValidatingUnitEnum_THEN_UnitEnumIsValid()
        {
            var unitsWithoutAttribute = new List<Unit>();
            var unitsWithBothUnitAndBaseUnitAttribute = new List<Unit>();
            var unitsWithBaseUnitAttribute = new List<Unit>();
            var unitsWithInvalidConversionValue = new List<Unit>();

            foreach (var unit in Enum.GetValues(typeof(Unit)).OfType<Unit>())
            {
                var unitAttributes = typeof(Unit).GetField(System.Enum.GetName(typeof(Unit), unit)).GetCustomAttributes(false);

                var unitAttribute = unitAttributes.FirstOrDefault(attribute => attribute is UnitAttribute) as UnitAttribute;
                var baseUnitAttribute = unitAttributes.FirstOrDefault(attribute => attribute is BaseUnitAttribute) as BaseUnitAttribute;

                if (unitAttribute != null && baseUnitAttribute != null)
                {
                    unitsWithBothUnitAndBaseUnitAttribute.Add(unit);
                }
                
                if (baseUnitAttribute != null)
                {
                    unitsWithBaseUnitAttribute.Add(unit);
                }

                if (unitAttribute == null && baseUnitAttribute == null)
                {
                    unitsWithoutAttribute.Add(unit);
                }

                if (unitAttribute != null && double.TryParse(unitAttribute.ConversionValue, out var conversionValue) == false)
                {
                    unitsWithInvalidConversionValue.Add(unit);
                }
            }

            if (unitsWithoutAttribute.Count == 0 && unitsWithBothUnitAndBaseUnitAttribute.Count == 0 && unitsWithBaseUnitAttribute.Count == 1 && unitsWithInvalidConversionValue.Count == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                var message = "The following issues were found, while analyzing the unit enum:";

                if (unitsWithoutAttribute.Count > 0)
                    message += $"\n\nThe following units doesn't have neither a unit nor a base unit attribute: { string.Join(", ", unitsWithoutAttribute) }.";

                if (unitsWithBothUnitAndBaseUnitAttribute.Count > 0)
                    message += $"\n\nThe following units have both a unit and a base unit attribute: { string.Join(", ", unitsWithBothUnitAndBaseUnitAttribute) }.";

                if (unitsWithBaseUnitAttribute.Count == 0)
                    message += $"\n\nThe unit enum doesn't have a value with a base unit attribute.";

                if (unitsWithBaseUnitAttribute.Count > 2)
                    message += $"\n\nThe unit enum has multiple values with a base unit attribute. The following base units were found: { string.Join(", ", unitsWithBaseUnitAttribute) }.";

                if (unitsWithInvalidConversionValue.Count > 0)
                    message += $"\n\nThe following units have invalid conversion rate value strings: { string.Join(", ", unitsWithInvalidConversionValue) }.";

                Assert.IsTrue(false, message);
            }
        }
    }
}
