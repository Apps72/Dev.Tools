using System;
using System.Collections.Generic;

namespace Apps72.Dev.Tools.Linq
{
    // Inspiration from https://github.com/morelinq

    /// <summary />
    public static partial class LinqExtensions
    {
        /// <summary>
        /// Concatenates the members of a collection, using the specified separator between
        /// each member.
        /// </summary>
        /// <typeparam name="T">Type of the elements in the sequence</typeparam>
        /// <param name="source">sequence of elements</param>
        /// <param name="separator">The string to use as a separator.separator is included in the returned string
        /// only if values has more than one element.</param>

        public static string StringJoin<T>(this IEnumerable<T> source, string separator)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (separator == null) throw new ArgumentNullException(nameof(separator));

            return String.Join(separator, source);
        }
    }
}
