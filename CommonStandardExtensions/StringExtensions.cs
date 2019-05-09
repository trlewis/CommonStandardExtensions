namespace CommonStandardExtensions
{
    using System;

    public static class StringExtensions
    {
        /// <summary>
        /// Repeatedly replaces the old value in the line with the new value until no occurrences of the old value
        /// remain. 
        /// </summary>
        /// <exception cref="ArgumentException">If the newValue contains the oldValue</exception>
        public static string ReplaceRecursive(this string str, string oldValue, string newValue)
        {
            if (newValue.Contains(oldValue))
                throw new ArgumentException("newValue cannot contain oldValue", nameof(newValue));

            while (str.Contains(oldValue))
                str = str.Replace(oldValue, newValue);

            return str;
        }
    }
}