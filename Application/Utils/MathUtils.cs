using System.Drawing;

namespace Valax321.DialogueEditor
{
    public static class MathUtils
    {
        public static bool IsNegative(this Point p)
        {
            return p.X < 0 && p.Y < 0;
        }
    }
}