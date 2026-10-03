using System.Collections;
using System.Collections.Generic;

namespace Quicker.Utilities.DataStructure;

public interface IObservableMap<K, V> : IEnumerable, IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>
{
	event MapChangedEventHandler<K, V> MapChanged;
}
