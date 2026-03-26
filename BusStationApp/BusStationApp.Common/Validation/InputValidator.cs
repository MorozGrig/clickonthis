using System.Text.RegularExpressions;

namespace BusStationApp.Common.Validation
{
    public static class InputValidator
    {
        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && EmailRegex.IsMatch(email.Trim());
        }

        public static bool IsPositiveInteger(string value)
        {
            return int.TryParse(value, out var number) && number > 0;
        }
    }
}
