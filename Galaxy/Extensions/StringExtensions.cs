namespace Galaxy.Extensions
{
    public static class StringExtensions
    {
        public static string Format(this string str, params object[] parameters)
        {
            return !string.IsNullOrWhiteSpace(str) ? string.Format(str, parameters) : str;
        }
    }
}
