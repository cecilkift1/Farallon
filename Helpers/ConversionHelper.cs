namespace Farallon.Helpers
{
    public static class ConversionHelper
    {
        public static decimal ConvertToDecimal(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }

            return decimal.TryParse(value, out var outVal) ? outVal : 0;
        }
    }
}
