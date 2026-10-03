namespace Quicker.Utilities.DataStructure;

public interface IMapChangedEventArgs<K>
{
	CollectionChange CollectionChange { get; }

	K Key { get; }
}
