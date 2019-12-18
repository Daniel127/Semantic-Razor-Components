using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;

namespace QD.Components.Semantic.Benchmarks
{
	internal class BenchmarkConfig : ManualConfig
	{
		public BenchmarkConfig()
		{
			Add(Job.Default
				.With(CoreRuntime.Core31)
				.With(Platform.X64)
				.With(Jit.RyuJit));
			Add(MemoryDiagnoser.Default);
			Add(CsvMeasurementsExporter.Default);
			Add(HtmlExporter.Default);
			Add(MarkdownExporter.GitHub);
			Add(ConsoleLogger.Default);
		}
	}
}
