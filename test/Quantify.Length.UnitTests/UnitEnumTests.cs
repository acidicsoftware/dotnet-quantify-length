using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Repository.Enum.Report;

namespace Quantify.Length.UnitTests
{
    [TestClass]
    public class UnitEnumTests
    {
        [TestMethod]
        public void WHEN_ValidatingUnitEnum_THEN_UnitEnumIsValid()
        {
            // Arrange
            var reportGenerator = new UnitEnumReportGenerator();

            // Act
            var report = reportGenerator.CreateReport<Unit>();

            // Assert
            Assert.IsFalse(report.HasErrors, report.CreateSummary());
            Assert.IsFalse(report.HasWarnings, report.CreateSummary());
        }
    }
}