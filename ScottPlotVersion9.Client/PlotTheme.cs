using ScottPlot;

namespace ScottPlotVersion9.Client
{
    public static class PlotTheme
    {
        public static void ApplyDarkTheme(Plot plot)
        {
            // Fondo negro
            plot.FigureBackground.Color = Colors.Black;
            plot.DataBackground.Color = Colors.Black;

            // Ejes y etiquetas en color blanco
            foreach (var axis in plot.Axes.GetAxes())
            {
                axis.Label.ForeColor = Colors.White;
            }

            // Desactivar la cuadrícula predeterminada
            plot.Grid.Equals(false);

            // Añadir una cuadrícula personalizada
            var customGrid = plot.Grid;
            customGrid.MajorLineColor = Colors.White;
            customGrid.MinorLineColor = Colors.Transparent;
            customGrid.MajorLineWidth = 1;
            customGrid.MajorLinePattern = LinePattern.Solid;

            // Establecer el espaciado de la cuadrícula
        }
    }
}
