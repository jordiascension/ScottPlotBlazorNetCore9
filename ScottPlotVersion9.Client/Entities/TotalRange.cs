using System.ComponentModel;

namespace ScottPlotVersion9.Client.Entities
{
    public enum TotalRange
    {
        [Description("MIN_1")]
        Minute1,

        [Description("MIN_5")]
        Minute5,

        [Description("MIN_30")]
        Minute30,

        [Description("HOUR_1")]
        Hour1,

        [Description("HOUR_4")]
        Hour4,

        [Description("HOUR_8")]
        Hour8,

        [Description("DAY_1")]
        Day1,

        [Description("DAY_7")]
        Day7,

        [Description("MONTH_1")]
        Month1,
    }
}
