using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeywordExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp)
        {
            var result = (temp - 32) / 1.8;

            return result;
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            var result = (temp * 9) / 5 + 32;

            return result;
        }
    }
}
