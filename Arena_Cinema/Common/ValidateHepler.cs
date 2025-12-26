using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Common
{
    public static class ValidateHepler
    {
        public static bool ValidateTextBox(Control txt, Label lblError, string fieldName,
        bool required, string pattern = null, string patternError = null, int? minLength = null)
        {
            string value = txt.Text.Trim();
            lblError.Text = "";
            txt.BackColor = Color.White;

            // Required
            if (required && string.IsNullOrEmpty(value))
            {
                lblError.Text = $"{fieldName} không được để trống";
                txt.BackColor = Color.LightPink;
                return false;
            }

            // MaxLength
            if (minLength.HasValue && value.Length < minLength.Value)
            {
                lblError.Text = $"{fieldName} phải hơn hoặc bằng {minLength} ký tự";
                txt.BackColor = Color.LightPink;
                return false;
            }

            // Pattern
            if (!string.IsNullOrEmpty(pattern) && !string.IsNullOrEmpty(value))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, pattern))
                {
                    lblError.Text = patternError ?? $"{fieldName} không đúng định dạng";
                    txt.BackColor = Color.LightPink;
                    return false;
                }
            }
            txt.BackColor = Color.LightGreen;
            return true;
        }

        public static string GenerateRandomNumber(int quanlity)
        {
            Random _rand = new Random();
            return _rand.Next(0, 1_000_000).ToString("D6");
        }
    }
}
