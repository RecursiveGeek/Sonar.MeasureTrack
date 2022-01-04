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

            var setting = new Setting { SettingId = 1, CertificateVersion = "10/5/05" };
            context.Settings.Add(setting);
            context.SaveChanges();

            var sections = new Section[]
            {
                new Section { SectionId = 3, SectionNumber = 3, SectionName = "Rudder" },
                new Section { SectionId = 4, SectionNumber = 4, SectionName = "Keel" },
                new Section { SectionId = 5, SectionNumber = 5, SectionName = "Deck" },
                new Section { SectionId = 6, SectionNumber = 6, SectionName = "Spars" },
                new Section { SectionId = 7, SectionNumber = 7, SectionName = "Racing Weights" }
            };
            context.Sections.AddRange(sections);
            context.SaveChanges();

            var metrics = new Metric[]
            {
                new Metric { SectionId = 3, SectionName = "R3.1", SectionDescription = "HDP Rudder", MeasurementUnits = "mm", MeasurementMinimum = 76, MeasurementMaximum = 89 },
                new Metric { SectionId = 3, SectionName = "R3.2", SectionDescription = "Rudder Trailing Edge Length", MeasurementUnits = "mm", MeasurementMinimum = 1099, MeasurementMaximum = 1111 },
                new Metric { SectionId = 3, SectionName = "R3.3", SectionDescription = "Rudder Leading Edge Length", MeasurementUnits = "mm", MeasurementMinimum = 1092, MeasurementMaximum = 1105 },
                new Metric { SectionId = 3, SectionName = "R3.4", SectionDescription = "Rudder Top", MeasurementUnits = "mm", MeasurementMinimum = 431, MeasurementMaximum = 438 },
                new Metric { SectionId = 3, SectionName = "R3.5", SectionDescription = "Rudder Bottom", MeasurementUnits = "mm", MeasurementMinimum = 199, MeasurementMaximum = 206 },
                new Metric { SectionId = 3, SectionName = "R3.6", SectionDescription = "Rudder Top Thickness", MeasurementUnits = "mm", MeasurementMinimum = 63, MeasurementMaximum = 70 },
                new Metric { SectionId = 3, SectionName = "R3.7", SectionDescription = "Rudder Bottom Thickness", MeasurementUnits = "mm", MeasurementMinimum = 24, MeasurementMaximum = 28 },
                new Metric { SectionId = 3, SectionName = "R3.8", SectionDescription = "Rudder Trailing Edge Thickness", MeasurementUnits = "mm", MeasurementMinimum = 3, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 3, SectionName = "R3.9", SectionDescription = "Rudder Space", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 13, IsPassFail = true },

                new Metric { SectionId = 4, SectionName = "R4.1", SectionDescription = "HDP Keel Top", MeasurementUnits = "mm", MeasurementMinimum = 2925, MeasurementMaximum = 2950, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.2", SectionDescription = "HDP Keel Bottom", MeasurementUnits = "mm", MeasurementMinimum = 3040, MeasurementMaximum = 3064, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.3", SectionDescription = "Keel Depth", MeasurementUnits = "mm", MeasurementMinimum = 230, MeasurementMaximum = 245, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.4", SectionDescription = "Keel Top Chord", MeasurementUnits = "mm", MeasurementMinimum = 1025, MeasurementMaximum = 1042, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.5", SectionDescription = "Keel Top 10%", MeasurementUnits = "mm", MeasurementMinimum = 78, MeasurementMaximum = 84, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.6", SectionDescription = "Keel Top 20%", MeasurementUnits = "mm", MeasurementMinimum = 98, MeasurementMaximum = 103, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.7", SectionDescription = "Keel Top 40%", MeasurementUnits = "mm", MeasurementMinimum = 109, MeasurementMaximum = 114, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.8", SectionDescription = "Keel Top 70%", MeasurementUnits = "mm", MeasurementMinimum = 79, MeasurementMaximum = 84, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.9", SectionDescription = "Keel Bottom Chord", MeasurementUnits = "mm", MeasurementMinimum = 662, MeasurementMaximum = 678, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.10", SectionDescription = "Keel Bottom 10%", MeasurementUnits = "mm", MeasurementMinimum = 46, MeasurementMaximum = 53, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.11", SectionDescription = "Keel Bottom 20%", MeasurementUnits = "mm", MeasurementMinimum = 62, MeasurementMaximum = 67, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.12", SectionDescription = "Keel Bottomo 40%", MeasurementUnits = "mm", MeasurementMinimum = 70, MeasurementMaximum = 75, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.13", SectionDescription = "Keel Bottom 70%", MeasurementUnits = "mm", MeasurementMinimum = 51, MeasurementMaximum = 56, IsPassFail = false },
                new Metric { SectionId = 4, SectionName = "R4.14", SectionDescription = "Keel Trailing Edge Top Thick (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 6.5, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 4, SectionName = "R4.15", SectionDescription = "Keel Trailing Edge Bottom (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 3.0, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 4, SectionName = "R4.16", SectionDescription = "Keel Trailing Edge Straight (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 4, SectionName = "R4.17", SectionDescription = "Keel Leading Edge Straight (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 4, SectionName = "R4.18", SectionDescription = "Keel Bottom Straight (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 4, SectionName = "R4.19", SectionDescription = "Keel Section Maintained (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = true },

                new Metric { SectionId = 5, SectionName = "R5.1", SectionDescription = "Forestay Location (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 135, MeasurementMaximum = 155, IsPassFail = true },
                new Metric { SectionId = 5, SectionName = "R5.2", SectionDescription = "Forestay to Chainplate (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 2946, MeasurementMaximum = 2997, IsPassFail = true },
                new Metric { SectionId = 5, SectionName = "R5.3", SectionDescription = "Chainplate to Sheerline (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 152, MeasurementMaximum = 178, IsPassFail = true },
                new Metric { SectionId = 5, SectionName = "R5.4", SectionDescription = "Partners (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 206, MeasurementMaximum = 206, IsPassFail = true },
                new Metric { SectionId = 5, SectionName = "R5.5", SectionDescription = "Mast Step Thickness (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 17, IsPassFail = true },
                new Metric { SectionId = 5, SectionName = "R5.6", SectionDescription = "Mast Heel Point", MeasurementUnits = "mm", MeasurementMinimum = 717, MeasurementMaximum = 740, IsPassFail = false },

                new Metric { SectionId = 6, SectionName = "R6.1", SectionDescription = "Mast Length", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 10315, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.2", SectionDescription = "Upper Band Height (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 10110, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.3", SectionDescription = "Upper Band Width (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 25, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.4", SectionDescription = "Mast Fore and Aft (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 100, MeasurementMaximum = 103, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.5", SectionDescription = "Mast Transverse (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 66, MeasurementMaximum = 72, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.6", SectionDescription = "Spinnaker Hoist", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 8389, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.7", SectionDescription = "Forestay Height", MeasurementUnits = "mm", MeasurementMinimum = 8223, MeasurementMaximum = 8236, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.8", SectionDescription = "Upper Shroud Height", MeasurementUnits = "mm", MeasurementMinimum = 8223, MeasurementMaximum = 8236, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.9", SectionDescription = "Spar Curvature (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 50, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.10", SectionDescription = "Spreader Height", MeasurementUnits = "mm", MeasurementMinimum = 4555, MeasurementMaximum = 4570, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.11", SectionDescription = "Spreader Transverse Length", MeasurementUnits = "mm", MeasurementMinimum = 1426, MeasurementMaximum = 1486, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.12", SectionDescription = "Spreader Fore and Aft Length", MeasurementUnits = "mm", MeasurementMinimum = 71, MeasurementMaximum = 135, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.13", SectionDescription = "Lower Shroud Height", MeasurementUnits = "mm", MeasurementMinimum = 4438, MeasurementMaximum = 4451, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.14", SectionDescription = "Upper Spin Pole Height", MeasurementUnits = "mm", MeasurementMinimum = 2432, MeasurementMaximum = 2445, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.15", SectionDescription = "Lower Spin Pole Height", MeasurementUnits = "mm", MeasurementMinimum = 2042, MeasurementMaximum = 2064, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.16", SectionDescription = "Spin Pole Projection (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 60, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.17", SectionDescription = "Fore and Aft Spreader Section (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 45, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.18", SectionDescription = "Vertical Spreader Section (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 18, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.19", SectionDescription = "Lower Band Height (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 1727, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.20", SectionDescription = "Lower Band Width (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 25, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.21", SectionDescription = "Forestay Length (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 7848, MeasurementMaximum = 8001, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.22", SectionDescription = "Forestay Diameter (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 3.8, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.23", SectionDescription = "Shroud Diameter (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 3.8, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.24", SectionDescription = "Backstay Diameter (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 3.0, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.25", SectionDescription = "Mast Tip Weight", MeasurementUnits = "kg", MeasurementMinimum = 10, MeasurementMaximum = null, IsPassFail = false },
                new Metric { SectionId = 6, SectionName = "R6.26", SectionDescription = "Boom Curvature (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 25, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.27", SectionDescription = "Boom Vertical Section (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 88, MeasurementMaximum = 98, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.28", SectionDescription = "Boom Transverse Section (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 55, MeasurementMaximum = 65, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.29", SectionDescription = "Boom Band Width (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 25, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.30", SectionDescription = "Boom Band Distance (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 3404, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.31", SectionDescription = "Spin Pole Length (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 2597, MeasurementMaximum = 2610, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.32", SectionDescription = "Spin Pole Diameter (P/F)", MeasurementUnits = "mm", MeasurementMinimum = 50, MeasurementMaximum = null, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.33", SectionDescription = "Whisker Pole Length (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 3100, IsPassFail = true },
                new Metric { SectionId = 6, SectionName = "R6.34", SectionDescription = "Whisker Pole Diameter (P/F)", MeasurementUnits = "mm", MeasurementMinimum = null, MeasurementMaximum = 64, IsPassFail = true },

                new Metric { SectionId = 7, SectionName = "R7.1", SectionDescription = "Lifting Sling Weight (P/F)", MeasurementUnits = "kg", MeasurementMinimum = null, MeasurementMaximum = 3, IsPassFail = true },
                new Metric { SectionId = 7, SectionName = "R7.2", SectionDescription = "Racing Weight", MeasurementUnits = "kg", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = false },
                new Metric { SectionId = 7, SectionName = "R7.3", SectionDescription = "Corrector Forward", MeasurementUnits = "kg", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = false },
                new Metric { SectionId = 7, SectionName = "R7.4", SectionDescription = "Corrector Sump", MeasurementUnits = "kg", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = false },
                new Metric { SectionId = 7, SectionName = "R7.5", SectionDescription = "Corrector Aft", MeasurementUnits = "kg", MeasurementMinimum = null, MeasurementMaximum = null, IsPassFail = false }

                // new Metric { SectionId = 7, SectionName = "R7.", SectionDescription = "", MeasurementUnits = "mm", MeasurementMinimum = , MeasurementMaximum = , IsPassFail = false },
            };
            context.Metrics.AddRange(metrics);
            context.SaveChanges();
        }
    }
}
