using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Apps72.Dev.Tools.System
{
    /// <summary />
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the <see cref="DescriptionAttribute"/> attribute value of the referenced <paramref name="value"/>
        /// or null if no description attribute found.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            Type genericEnumType = value.GetType();
            string name = Enum.GetName(value.GetType(), value);
            MemberInfo[] memberInfo = genericEnumType.GetMember(name);

            return memberInfo?.FirstOrDefault()
                             ?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                             ?.Cast<DescriptionAttribute>()
                             ?.FirstOrDefault()
                             ?.Description;
        }
    }
}
