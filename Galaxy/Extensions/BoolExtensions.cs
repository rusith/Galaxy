using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Galaxy.Extensions
{
    /// <summary>
    /// extensions for bool
    /// </summary>
    public static class BoolExtensions
    {
        /// <summary>
        /// returns 0 if false otherwise 1
        /// </summary>
        /// <returns>1 or 0</returns>
        public static int ToOneZero(this bool value)
        {
            return value ? 1 : 0;
        }

        /// <summary>
        /// returns 0 if false otherwise 1 as a string
        /// </summary>
        /// <returns>"1" or "0"</returns>
        public static string ToOneZeroStr(this bool value)
        {
            return value ? "1" : "0";
        }
    }
}
