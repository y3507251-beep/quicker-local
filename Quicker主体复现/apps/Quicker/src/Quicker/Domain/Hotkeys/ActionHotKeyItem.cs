using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using Quicker.Annotations;
using Quicker.View.Hotkeys;

namespace Quicker.Domain.Hotkeys;

public class ActionHotKeyItem : INotifyPropertyChanged
{
	private bool nWptcT0FU67 = true;

	private string Wy1tcMm2vIv;

	[CompilerGenerated]
	private string kjltcA56NQo;

	[CompilerGenerated]
	private string PNGtcO6muZC;

	[CompilerGenerated]
	private string yURtcFtYMXG;

	[CompilerGenerated]
	private string wOAtcUQwpuo;

	[CompilerGenerated]
	private string g7Utcl8uX8y;

	[CompilerGenerated]
	private string ejAtcipQCJj;

	[CompilerGenerated]
	private bool oCMtc3ynLcC = true;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ActionHotKeyItem IF6tfrQ1X3eSyrxGDm7O;

	public bool IsEnabled
	{
		get
		{
			return nWptcT0FU67;
		}
		set
		{
			nWptcT0FU67 = value;
			OnPropertyChanged("IsEnabled");
		}
	}

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return kjltcA56NQo;
		}
		[CompilerGenerated]
		set
		{
			kjltcA56NQo = value;
		}
	}

	public string BindingProcessName
	{
		[CompilerGenerated]
		get
		{
			return PNGtcO6muZC;
		}
		[CompilerGenerated]
		set
		{
			PNGtcO6muZC = value;
		}
	}

	public string BlackList
	{
		[CompilerGenerated]
		get
		{
			return yURtcFtYMXG;
		}
		[CompilerGenerated]
		set
		{
			yURtcFtYMXG = value;
		}
	}

	public string Keys
	{
		[CompilerGenerated]
		get
		{
			return wOAtcUQwpuo;
		}
		[CompilerGenerated]
		set
		{
			wOAtcUQwpuo = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return g7Utcl8uX8y;
		}
		[CompilerGenerated]
		set
		{
			g7Utcl8uX8y = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ejAtcipQCJj;
		}
		[CompilerGenerated]
		set
		{
			ejAtcipQCJj = value;
		}
	}

	public bool WaitKeyUp
	{
		[CompilerGenerated]
		get
		{
			return oCMtc3ynLcC;
		}
		[CompilerGenerated]
		set
		{
			oCMtc3ynLcC = value;
		}
	}

	public string ActionParam
	{
		get
		{
			return Wy1tcMm2vIv;
		}
		set
		{
			Wy1tcMm2vIv = value;
			OnPropertyChanged("ActionParam");
		}
	}

	[JsonIgnore]
	public string KeyName => Hotkey.DataToString(Keys);

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

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool GYXyYZQ12GtiA5DBOgah()
	{
		return IF6tfrQ1X3eSyrxGDm7O == null;
	}
}
