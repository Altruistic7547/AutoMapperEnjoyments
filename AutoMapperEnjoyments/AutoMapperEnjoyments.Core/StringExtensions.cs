using System.Text.RegularExpressions;

namespace AutoMapperEnjoyments.Core
{
    public static class StringExtensions
    {
        private static readonly Regex consecutiveSpaces = new Regex("\\s{2,}", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public static string Concatenate(this ICollection<string> collection)
        {
            if (!collection.Any())
            {
                return null;
            }

            string input = string.Join(" ", collection.Select((string a) => a?.Trim() ?? ""));
            return consecutiveSpaces.Replace(input, " ").Trim();
        }

        public static string RemoveDuplicateSpaces(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return consecutiveSpaces.Replace(input, " ");
        }

    }
}
