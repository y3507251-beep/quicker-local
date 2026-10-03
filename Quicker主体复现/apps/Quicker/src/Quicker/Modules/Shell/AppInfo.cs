using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using Newtonsoft.Json;

namespace Quicker.Modules.Shell;

public class AppInfo
{
	private string i8diV2P2mX;

	[CompilerGenerated]
	private string NuviZGSc0G;

	[CompilerGenerated]
	private string unSi9cDsHC;

	[CompilerGenerated]
	private string y0TihZsQ93;

	[CompilerGenerated]
	private WindowsAppType Jbjie5o8Mw;

	[CompilerGenerated]
	private ImageSource jdniYoe17T;

	[CompilerGenerated]
	private string lWDiIH8iUo;

	[CompilerGenerated]
	private string uipiW8xlgP;

	[CompilerGenerated]
	private string neGikmgBH2;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	[CompilerGenerated]
	private int w7miGtIElx;

	[CompilerGenerated]
	private string T7jisiQN8E;

	internal static AppInfo hBoadVQQWoIRavp2G3Do;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return NuviZGSc0G;
		}
		[CompilerGenerated]
		set
		{
			NuviZGSc0G = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return unSi9cDsHC;
		}
		[CompilerGenerated]
		set
		{
			unSi9cDsHC = value;
		}
	}

	public string AppUserModelID
	{
		[CompilerGenerated]
		get
		{
			return y0TihZsQ93;
		}
		[CompilerGenerated]
		set
		{
			y0TihZsQ93 = value;
		}
	}

	public WindowsAppType AppType
	{
		[CompilerGenerated]
		get
		{
			return Jbjie5o8Mw;
		}
		[CompilerGenerated]
		set
		{
			Jbjie5o8Mw = value;
		}
	}

	[JsonIgnore]
	public ImageSource Icon
	{
		[CompilerGenerated]
		get
		{
			return jdniYoe17T;
		}
		[CompilerGenerated]
		set
		{
			jdniYoe17T = value;
		}
	}

	public string TargetParsingPath
	{
		get
		{
			return i8diV2P2mX;
		}
		set
		{
			i8diV2P2mX = value;
			if (value != null && value.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				ExeName = Path.GetFileName(i8diV2P2mX);
			}
		}
	}

	public string TargetArguments
	{
		[CompilerGenerated]
		get
		{
			return lWDiIH8iUo;
		}
		[CompilerGenerated]
		set
		{
			lWDiIH8iUo = value;
		}
	}

	public string PackageInstallPath
	{
		[CompilerGenerated]
		get
		{
			return uipiW8xlgP;
		}
		[CompilerGenerated]
		set
		{
			uipiW8xlgP = value;
		}
	}

	public string ExeName
	{
		[CompilerGenerated]
		get
		{
			return neGikmgBH2;
		}
		[CompilerGenerated]
		set
		{
			neGikmgBH2 = value;
		}
	}

	public int ScoreDelta
	{
		[CompilerGenerated]
		get
		{
			return w7miGtIElx;
		}
		[CompilerGenerated]
		set
		{
			w7miGtIElx = value;
		}
	}

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return T7jisiQN8E;
		}
		[CompilerGenerated]
		set
		{
			T7jisiQN8E = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool fInu5AQQy604qDEttDcF()
	{
		return hBoadVQQWoIRavp2G3Do == null;
	}
}
