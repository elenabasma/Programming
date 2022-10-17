using System;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"the value of the {nameProperty} field must be positive");
            }
        }

        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }

        public static void AssertStringNumberIsCorrect(string nameProperty, string value)
        {
            if (!long.TryParse(value, out long num))
            {
                throw new ArgumentException(
                    "the value of the Number field must consist of digits only");
            }

            if (value.Length != 11)
            {
                throw new ArgumentException(
                    "the value of the Number field must consist of 11 digits");
            }
        }

        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                        $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                        $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should consist only of English letters.");
            }
        }

        public static void AssertValueContainsOnlyDigits(string nameProperty, string value)
        {
            if (!long.TryParse(value, out long number))
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must consist of digits only");
            }
        }

        public static void AssertNumberContainsOnlyElevenDigits(string nameProperty, string value)
        {
            if (value.Length != 11)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must consist of 11 digits");
            }
        }
    }
}
