/*! \file Converter.cs
	\brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X3DCad.Helpers
{
    public static class Converter
    {
        public static T FromStringToNonNullable<T>(string input) where T : struct
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    object? val = converter.ConvertFromString(input);
                    return val != null ? (T)val : default(T);
                }
                return default(T);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }

        /// <summary>
        /// Converts strings to bitwise enum
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static TEnum StringToFlagsEnum<TEnum>(string[]? items) where TEnum : struct
        {
            int result = 0;
            if (items != null)
            {
                foreach (var token in items)
                {
                    string strEnum = token.Trim('"');
                    TEnum enumVal;
                    if (Enum.TryParse<TEnum>(strEnum, out enumVal))
                    {
                        result |= (int)(object)enumVal;
                    }
                }
            }
            return (TEnum)(object)result;
        }

        /// <summary>
        /// Converts bitwise enum to strings
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<string> FlagsEnumToStringArray<TEnum>(TEnum enumValue, int maxBits = 32) where TEnum : struct
        {
            List<string> result = new List<string>();

            int value = (int)(object)enumValue;
            for (int bit = 0; bit < maxBits && value != 0; ++bit)
            {
                int mask = 1 << bit;
                if (0 != (value & mask))
                {
                    TEnum curValue = (TEnum)(object)mask;

                    string? strVal = curValue.ToString();
                    if (strVal != null)
                    {
                        result.Add(strVal);
                    }
                    value &= ~mask;
                }
            }
            return result;
        }
    }
}
