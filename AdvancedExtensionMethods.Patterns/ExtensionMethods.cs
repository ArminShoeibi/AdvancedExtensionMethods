using System.Text;

namespace AdvancedExtensionMethods.Patterns
{
    public static class ExtensionMethods
    {
        public static StringBuilder AL(this StringBuilder stringBuilder, string value)
        {
            return stringBuilder.AppendLine(value);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            bool isNullOrEmpty = string.IsNullOrEmpty(str);
            return isNullOrEmpty;
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);
            return isNullOrWhiteSpace;
        }

        public static string Format(this string str, params object[] args)
        {
            string formattedString = string.Format(str, args);
            return formattedString;
        }

    }
}
