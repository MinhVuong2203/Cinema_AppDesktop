using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Common
{
    public class LanguageHelper
    {
        public static void ChangeLanguage(Form form, string cultureCode)
        {
            // Đặt ngôn ngữ nè
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            // Áp dụng cho tất cả control trong form
            var resources = new ComponentResourceManager(form.GetType());
            foreach (Control control in form.Controls)
            {
                resources.ApplyResources(control, control.Name);
            }
            // Áp dụng cho chính form
            resources.ApplyResources(form, "$this");
        }
    }
}
