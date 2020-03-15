
namespace System.Text.RegularExpressions
{
    /// <summary>
    /// Regex extensions.
    /// </summary>
    public static class RegexExtensions
    {
        /// <summary>
        /// Replace the string according to a regex by groupName with a replacement value.
        /// </summary>
        /// <param name="input">The string</param>
        /// <param name="regex">Regeular Expression with a group name.</param>
        /// <param name="groupName">The group name to replace.</param>
        /// <param name="replacement">Replacement value.</param>
        public static string Replace(this string input, Regex regex, string groupName, string replacement)
        {
            return regex.Replace(input, m =>
            {
                return ReplaceNamedGroup(input, groupName, replacement, m);
            });
        }

        /// <summary>
        /// Replaces the named group.
        /// </summary>
        /// <returns>The named group.</returns>
        /// <param name="input">The string to be searched.</param>
        /// <param name="groupName">The group name from the regular expressions to replace.</param>
        /// <param name="replacement">Replacement value.</param>
        /// <param name="m">Regular Expression Match.</param>
        private static string ReplaceNamedGroup(string input, string groupName, string replacement, Match m)
        {
            string capture = m.Value;
            capture = capture.Remove(m.Groups[groupName].Index - m.Index, m.Groups[groupName].Length);
            capture = capture.Insert(m.Groups[groupName].Index - m.Index, replacement);
            return capture;
        }
    }
}
