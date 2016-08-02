using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Galaxy.Extensions
{
    /// <summary>
    /// this class contains some extension methods for all objects
    /// </summary>
    public static class ObjectExtension
    {
        /// <summary>
        /// Check the object is numeric type (if it is a string it will be formatted)
        /// </summary>
        /// <param name="obj">object to check if it is a numeric type</param>
        /// <returns>true or false</returns>
        public static bool IsNumeric(this object obj)
        {
            if (obj == null)
                return false;
            double number;
            return double.TryParse(Convert.ToString(obj, CultureInfo.InvariantCulture), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out number);
        }
    }
}
