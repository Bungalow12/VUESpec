using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace System
{
    /// <summary>
    /// String extensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces one or more format items in the string with the string representation 
        /// of a corresponding object in a specified array.
        /// </summary>
        /// <param name="str">A composite format string.</param>
        /// <param name="args">An args array that contains zero or more objects to format.</param>
        public static string Format(this String str, params Object[] args)
        {
            return string.Format(str, args);
        }

        /// <summary>
        /// Replaces one or more format items in the string with the string representation 
        /// of a corresponding named object in a specified dictionary.
        /// </summary>
        /// <param name="str">A composite format string.</param>
        /// <param name="args">An args dictionary that contains zero or more named objects to format.</param>
        /// <example>
        /// "http://${{host}}:${{port}}".Format(new Dictionary<string, object>() 
        ///                        {
        ///                            {"host", "127.0.0.1"}, 
        ///                            {"port", 80}
        ///                        });
        /// 
        /// Returns: "http://127.0.0.1:80"
        /// 
        /// "[0x${{location:X8}}] ${{function}}(${{type}} bar)".Format(new Dictionary<string, object>()
        ///                                            {
        ///                                               {"function", "Foo"},
        ///                                               {"type", "int"},
        ///                                               {"location", 110}
        ///                                            });
        /// 
        /// Returns: "[0x0000006E] Foo(int bar)"
        /// </example>
        public static string Format(this String str, Dictionary<string, object> args)
        {
            List<object> values = new List<object>();
            string updated = str;
            int i = 0;

            //Foreach key create a regex and replace them in order of index with their indexed value.
            //This maintains the format operations.
            foreach (string name in args.Keys)
            {
                Regex regex = new Regex(@"\s*{(?<name>" + name + @")\S*}");
                values.Add(args[name]);
                updated = updated.Replace(regex, "name", i.ToString());
                ++i;
            }

            //Perform the System string.Format on a standardized composite format string.
            string final = string.Format(updated, values.ToArray());

            return final;
        }
    }
}
