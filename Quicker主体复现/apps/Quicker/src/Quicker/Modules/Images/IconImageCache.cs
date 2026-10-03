using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Quicker.Modules.Images;

[Serializable]
public class IconImageCache
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec zb5v6XBvRvs;

		public static Func<KeyValuePair<string, WeakReference<ImageSource>>, bool> CI2v6mgJXQX;

		public static Func<KeyValuePair<string, WeakReference<ImageSource>>, string> KCYv6Khj19H;

		private static _003C_003Ec MZXgRBcIQ7yYTQHM7BhE;

		static _003C_003Ec()
		{
			zb5v6XBvRvs = new _003C_003Ec();
		}

		internal bool NTiv6bGPX6S(KeyValuePair<string, WeakReference<ImageSource>> o)
		{
			ImageSource target;
			return !o.Value.TryGetTarget(out target);
		}

		internal string cDiv66637ix(KeyValuePair<string, WeakReference<ImageSource>> o)
		{
			return o.Key;
		}

		internal static bool Yd9m4AcIFKa6vBUt6Owt()
		{
			return MZXgRBcIQ7yYTQHM7BhE == null;
		}
	}

	private readonly ConcurrentDictionary<string, WeakReference<ImageSource>> QDWtyCNpfFi = new ConcurrentDictionary<string, WeakReference<ImageSource>>();

	private static IconImageCache prDjulQ3FuGXtPF41YNd;

	public ImageSource this[string path]
	{
		get
		{
			if (QDWtyCNpfFi.TryGetValue(path, out var value) && value.TryGetTarget(out var target))
			{
				return target;
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				QDWtyCNpfFi[path] = new WeakReference<ImageSource>(value);
				if (QDWtyCNpfFi.Count > 100)
				{
					Cleanup();
				}
			}
		}
	}

	public void Cleanup()
	{
		foreach (string item in QDWtyCNpfFi.Where(_003C_003Ec.CI2v6mgJXQX ?? (_003C_003Ec.CI2v6mgJXQX = _003C_003Ec.zb5v6XBvRvs.NTiv6bGPX6S)).Select(_003C_003Ec.KCYv6Khj19H ?? (_003C_003Ec.KCYv6Khj19H = _003C_003Ec.zb5v6XBvRvs.cDiv66637ix)).ToList())
		{
			QDWtyCNpfFi.TryRemove(item, out var value);
		}
	}

	public bool TryGetImage(string path, out ImageSource image)
	{
		image = null;
		if (QDWtyCNpfFi.TryGetValue(path, out var value) && value.TryGetTarget(out image))
		{
			return true;
		}
		return false;
	}

	public int CacheSize()
	{
		return QDWtyCNpfFi.Count;
	}

	public int UniqueImagesInCache()
	{
		return QDWtyCNpfFi.Values.Distinct().Count();
	}

	internal static bool qQrk8qQ3cJYT61U4EgOP()
	{
		return prDjulQ3FuGXtPF41YNd == null;
	}

	internal static void CQkVCnQ3yHvDRUTW9YCZ()
	{
	}
}
