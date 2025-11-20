using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ColorHelper
    {
        /// <summary>
        /// Convert Color → "A,R,G,B"
        /// </summary>
        public static string ToString(Color color)
        {
            // Always save 4 values for consistency
            return $"{color.A},{color.R},{color.G},{color.B}";
        }

        /// <summary>
        /// Convert "A,R,G,B" or "R,G,B" → Color
        /// </summary>
        public static Color Parse(string value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                    return Color.White;

                string[] p = value.Split(',');

                // ARGB (4 values)
                if (p.Length == 4)
                {
                    return Color.FromArgb(
                        int.Parse(p[0]),
                        int.Parse(p[1]),
                        int.Parse(p[2]),
                        int.Parse(p[3])
                    );
                }
                // RGB (3 values)
                else if (p.Length == 3)
                {
                    return Color.FromArgb(
                        255, // default Alpha
                        int.Parse(p[0]),
                        int.Parse(p[1]),
                        int.Parse(p[2])
                    );
                }

                // Invalid format
                return Color.White;
            }
            catch
            {
                // Safe fallback
                return Color.White;
            }
        }

        /// <summary>
        /// TryParse version (không throw exception)
        /// </summary>
        public static bool TryParse(string value, out Color color)
        {
            try
            {
                color = Parse(value);
                return true;
            }
            catch
            {
                color = Color.White;
                return false;
            }
        }
    }
}
