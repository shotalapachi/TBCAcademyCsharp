using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Task_1;

var summary = BenchmarkRunner.Run<Benchmarks>();
