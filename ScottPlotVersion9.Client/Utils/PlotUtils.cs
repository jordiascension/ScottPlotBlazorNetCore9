using ScottPlot;

namespace ScottPlotVersion9.Client.Utils
{
    public static class PlotUtils
    {
        public static void ApplyDarkTheme(Plot plot)
        {
            // Set black background for the figure and data area
            plot.FigureBackground.Color = Colors.Black;
            plot.DataBackground.Color = Colors.Black;

            // Set axes and labels to white
            foreach (var axis in plot.Axes.GetAxes())
            {
                axis.Label.ForeColor = Colors.White;
            }

            // Disable the default grid
            plot.Grid.XAxisStyle.IsVisible = true;
            plot.Grid.YAxisStyle.IsVisible = true;

            // Add a custom grid (major lines white, minor lines transparent)
            var customGrid = plot.Grid;
            customGrid.MajorLineColor = Colors.White;
            customGrid.MinorLineColor = Colors.Transparent;
            customGrid.MajorLineWidth = 1;
            customGrid.MajorLinePattern = LinePattern.Solid;

            // Optional: Set custom grid spacing if needed
            // customGrid.MajorSpacing = someValue;
        }
    }
}
