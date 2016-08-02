using System.Linq;

namespace Galaxy.Extensions
{
    /// <summary>
    /// Extensions for string 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Will remove specified character from the string (replaced with Unicode null character)
        /// </summary>
        /// <param name="str">string to remove characters from</param>
        /// <param name="character">character to remove </param>
        /// <returns></returns>
        public static string RemoveChar(this string str, char character)
        {
            return str.Replace(character, '\0');
        }

        /// <summary>
        /// Will remove  all specified characters from the string (replaced with Unicode null character)
        /// </summary>
        /// <param name="str">string to remove characters from</param>
        /// <param name="characters">characters to remove </param>
        /// <returns></returns>
        public static string RemoveChar(this string str, params char[] characters)
        {
            characters = characters.Distinct().ToArray();
            return characters.Length <= 0
                ? str
                : characters.Aggregate(str, (current, cha) => current.Replace(cha, '\0'));
        }

        /// <summary>
        /// format the string using string.Format
        /// </summary>
        /// <param name="str">string to format</param>
        /// <param name="parameters">format parameters</param>
        /// <returns></returns>
        public static string Format(this string str, params object[] parameters)
        {
            return string.Format(str, parameters);
        }

        /// <summary>
        /// surround the string with another string 
        /// </summary>
        /// <param name="str">string to use </param>
        /// <param name="text">string to add to start and end</param>
        /// <returns>result text</returns>
        public static string SurroundWith(this string str, string text)
        {
            return text + str + text;
        }
    }
}
