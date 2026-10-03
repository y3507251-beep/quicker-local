namespace CW;

public interface ILazy
{
	object Value { get; }

	bool IsValueCreated { get; }
}
public interface ILazy<T> : ILazy
{
	new T Value { get; }
}
