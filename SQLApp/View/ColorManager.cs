using System.Drawing;

namespace SQLApp.View
{
    public static class ColorManager
    {
        public static Color UpdateColor { get; } = Color.LightBlue;

        public static Color CurrentUpdateColor { get; } = Color.LightCyan;

        public static Color AddColor { get; } = Color.LightGreen;

        public static Color ActualColor { get; } = Color.LightGray;

        public static Color IncorrectColor { get; } = Color.Yellow;
    }
}
