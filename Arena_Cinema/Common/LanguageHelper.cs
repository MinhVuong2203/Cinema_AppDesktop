using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Common
{
    public static class LanguageHelper
    {
        public static void ChangeLanguage(string langCode)
        {
            if (string.IsNullOrEmpty(langCode))
                langCode = "vi-VN"; // mặc định tiếng Việt

            var culture = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }

        public static void ApplyLanguage(Control control)
        {
            if (control == null) return;

            var resources = new ComponentResourceManager(control.GetType());
            ApplyResourceRecursive(control, resources);

            if (control is Form form)
            {
                resources.ApplyResources(form, "$this");
            }
        }

        private static void ApplyResourceRecursive(Control control, ComponentResourceManager resources)
        {
            resources.ApplyResources(control, control.Name);

            foreach (Control child in control.Controls)
                ApplyResourceRecursive(child, resources);
        }
    }
}
