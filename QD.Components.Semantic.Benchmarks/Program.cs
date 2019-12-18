using BenchmarkDotNet.Running;

namespace QD.Components.Semantic.Benchmarks
{
    public class Program
    {
		public static void Main(string[] args) =>
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
	}
}
