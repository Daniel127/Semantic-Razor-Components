using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;

namespace QD.Components.Semantic
{
	internal static class Extensions
	{
		private static readonly ConcurrentDictionary<Enum, string> s_descriptions = new ConcurrentDictionary<Enum, string>();

		internal static string GetDescription(this Enum @enum)
		{
			return s_descriptions.GetOrAdd(@enum, ReflectDescription);
		}

		private static string ReflectDescription(Enum @enum)
		{
			FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());
			return fieldInfo?.GetCustomAttribute<DescriptionAttribute>()?.Description;
		}
	}
}
