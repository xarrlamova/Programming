﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Validator
    {
        public static void AssertOnPositiveValue(int value, string name = "")
        {

            if (value <= 0)
                throw new ArgumentException($"Exception is thrown:{name} value is not supposed to be negative");
        }

        public static void AssertValueInRange(int value, int min, int max, string name = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Exception is thrown:{name} value " +
                    $"is supposed to be between {min} and {max}");
        }
    }

}
