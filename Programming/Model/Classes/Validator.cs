using System;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string property, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"The value of the {property} field must be positive");
            }
        }

        public static void AssertOnPositiveValue(string property, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"The value of the {property} field must be positive");
            }
        }

        public static void AssertStringNumberIsCorrect(string property, string value)
        {
            if (!long.TryParse(value, out long num))
            {
                throw new ArgumentException(
                    "The value of the Number field must consist of digits only");
            }

            if (value.Length != 11)
            {
                throw new ArgumentException(
                    "The value of the Number field must consist of 11 digits");
            }
        }

        public static void AssertValueInRange(string property, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                        $"The value of the {property} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertValueInRange(string property, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                        $"The value of the {property} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertStringContainsOnlyLetters(string property, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException(
                    $"The value of the {property} field should consist only of English letters.");
            }
        }

        public static void AssertValueContainsOnlyDigits(string property, string value)
        {
            if (!long.TryParse(value, out long number))
            {
                throw new ArgumentException(
                    $"The value of the {property} field must consist of digits only");
            }
        }

        public static void AssertNumberContainsOnlyElevenDigits(string property, string value)
        {
            if (value.Length != 11)
            {
                throw new ArgumentException(
                    $"he value of the {property} field must consist of 11 digits");
            }
        }
    }
}
