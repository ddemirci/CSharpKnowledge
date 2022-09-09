using BenchmarkDotNet.Attributes;

namespace DotNetKnowledge.BoxingAndUnboxing;

[MemoryDiagnoser]
public class BenchmarkForBoxingAndUnboxing
{
    private static readonly BoxingAndUnboxingService service = new();
    private static readonly object value = 100;

    [Benchmark] public object? Box() => service.BoxValue(100);
    [Benchmark] public int UnBox() => service.UnboxValue<int>(value);
    [Benchmark(Description = "Return an integer")] public int ReturnAnInteger() => service.ReturnValue(100);
    [Benchmark(Description = "Return an object")] public object ReturnAnObject() => service.ReturnValue(value);
}

public class BoxingAndUnboxingService
{
    // Boxing is an expensive operation so avoid using it
    public object? BoxValue<T>(T? value) => value;
    public T UnboxValue<T>(object value) => (T)value;
    public T ReturnValue<T>(T value) => value;
}