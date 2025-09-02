using ScottPlotVersion9.Client.Entities;
using System.ComponentModel;
using System.Reflection;

namespace ScottPlotVersion9.Client.Utils
{
    public static class PlotEnumHelper
    {
        /// <summary>
        /// Gets descriptions from any enum type.
        /// </summary>
        public static IEnumerable<string> GetEnumDescriptions<TEnum>() where TEnum : Enum
        {
            foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                yield return GetEnumDescription(value as Enum);
            }
        }

        private static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        /// <summary>
        /// Gets the Total Ranges list: "MIN_1", "MIN_5", "MIN_30", "HOUR_1", "HOUR_4", "HOUR_8", "DAY_1", "DAY_7", "MONTH_1".
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetTotalRanges() => GetEnumDescriptions<TotalRange>();
    }
}
