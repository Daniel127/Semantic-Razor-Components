using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using BenchmarkDotNet.Attributes;

namespace QD.Components.Semantic.Benchmarks
{
	[Config(typeof(BenchmarkConfig))]
	public class GetDescriptionTests
	{
		private static readonly ConcurrentDictionary<Enum, string> s_descriptions = new ConcurrentDictionary<Enum, string>();

		private static string GetDescriptionCached(Enum @enum)
		{
			return s_descriptions.GetOrAdd(@enum, GetDescription);
		}

		private static string GetDescription(Enum @object)
		{
			FieldInfo fieldInfo = @object.GetType().GetField(@object.ToString());
			if (fieldInfo == null) return null;
			DescriptionAttribute description = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
			return description?.Description;
		}

		private Enum[] _values = Array.Empty<Enum>();

		[Benchmark(Baseline = true)]
		public void Original()
		{
			for (int i = 0; i < _values.Length; i++)
			{
				_ = GetDescription(_values[i]);
			}
		}

		[Benchmark]
		public void Cached()
		{
			for (int i = 0; i < _values.Length; i++)
			{
				_ = GetDescriptionCached(_values[i]);
			}
		}


		[GlobalSetup]
		public void Setup()
		{
			var values = new List<Enum>();
			GetValues<Enums.Color>(values);
			GetValues<Enums.HorizontalPosition>(values);
			GetValues<Enums.Position>(values);
			GetValues<Enums.Size>(values);
			GetValues<Enums.VerticalPosition>(values);
			GetValues<Enums.Width>(values);
			GetValues<Enums.Button.Color>(values);
			GetValues<Enums.Button.Animation>(values);
			GetValues<Enums.Container.TextAlign>(values);
			GetValues<Enums.Elements.Flag>(values);
			GetValues<Enums.Elements.Icon>(values);
			GetValues<Enums.Icon.Corner>(values);
			GetValues<Enums.Icon.FlipDirection>(values);
			GetValues<Enums.Icon.Rotation>(values);
			GetValues<Enums.Label.Corner>(values);
			GetValues<Enums.Label.Direction>(values);
			GetValues<Enums.Label.Ribbon>(values);
			GetValues<Enums.Label.Side>(values);

			_values = values.ToArray();
		}

		private static void GetValues<T>(IList<Enum> values) where T : Enum
		{
			foreach (Enum value in Enum.GetValues(typeof(T)))
			{
				values.Add(value);
			}
		}
	}
}
