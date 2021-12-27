using System.Linq;
using Sonar.MeasureTrack.Models;

namespace Sonar.MeasureTrack.Web.Data
{
    // https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Metrics.Any())
            {
                return; // DB has been seeded
            }

            var metrics = new Metric[]
            {
                new Metric { SectionMaster = 3, SectionName = "R3.1", SectionDescription = "HDP Rudder", MeasurementUnits = "mm", MeasurementMinimum = 76, MeasurementMaximum = 89 },
                new Metric { SectionMaster = 3, SectionName = "R3.2", SectionDescription = "Rudder Trailing Edge Length", MeasurementUnits = "mm", MeasurementMinimum = 1099, MeasurementMaximum = 1111 },
                new Metric { SectionMaster = 3, SectionName = "R3.3", SectionDescription = "Rudder Leading Edge Length", MeasurementUnits = "mm", MeasurementMinimum = 1092, MeasurementMaximum = 1105 },
                new Metric { SectionMaster = 3, SectionName = "R3.4", SectionDescription = "Rudder Top", MeasurementUnits = "mm", MeasurementMinimum = 431, MeasurementMaximum = 438 },
                new Metric { SectionMaster = 3, SectionName = "R3.5", SectionDescription = "Rudder Bottom", MeasurementUnits = "mm", MeasurementMinimum = 199, MeasurementMaximum = 206 },
                new Metric { SectionMaster = 3, SectionName = "R3.6", SectionDescription = "Rudder Top Thickness", MeasurementUnits = "mm", MeasurementMinimum = 63, MeasurementMaximum = 70 },
                new Metric { SectionMaster = 3, SectionName = "R3.7", SectionDescription = "Rudder Bottom Thickness", MeasurementUnits = "mm", MeasurementMinimum = 24, MeasurementMaximum = 28 },
                new Metric { SectionMaster = 3, SectionName = "R3.8", SectionDescription = "Rudder Trailing Edge Thickness", MeasurementUnits = "mm", MeasurementMinimum = 3, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionMaster = 3, SectionName = "R3.9", SectionDescription = "Rudder Space", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 13, IsPassFail = true }

                // new Metric { SectionMaster = 3, SectionName = "R3.", SectionDescription = "", MeasurementUnits = "mm", MeasurementMinimum = , MeasurementMaximum = }
            };
        }
    }
}
