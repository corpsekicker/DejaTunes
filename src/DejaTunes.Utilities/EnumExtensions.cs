using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DejaTunes.Utilities
{
    public static class EnumExtensions
    {
        public static List<KeyValuePair<T, string>> GetEnumValueDescriptions<T>()
        {
            var enumType = typeof(T);
            var enumValues = Enum.GetValues(enumType);
            List<KeyValuePair<T, string>> result = new List<KeyValuePair<T, string>>();
            foreach (T enumValue in enumValues)
            {
                var memInfo = enumType.GetMember(enumValue.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                var description = ((DescriptionAttribute)attributes[0]).Description;
                result.Add(new KeyValuePair<T, string>(enumValue, description));
            }

            return result;
        }
    }
}