using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using Quicker.Annotations;
using Quicker.Domain.Entities;
using Quicker.Public.Extensions;

namespace Quicker.View;

public class ExeInfo : INotifyPropertyChanged
{
	private string AoVg4or3kDY;

	[CompilerGenerated]
	private string ycbg4T7E0HP;

	[CompilerGenerated]
	private string dKgg4M7MQgf;

	[CompilerGenerated]
	private string BoEg4ACDoRj;

	[CompilerGenerated]
	private string Hqyg4OQb9e0;

	private ImageSource Xwng4FCq3ih;

	private readonly ExeSettings vpQg4UQCyL1;

	private string vJ5g4lEoWD5;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static ExeInfo xdNaBMFQrd1RFhJIarJy;

	public string Name
	{
		get
		{
			return AoVg4or3kDY;
		}
		set
		{
			AoVg4or3kDY = value;
			OnPropertyChanged("Name");
		}
	}

	public string Exe
	{
		[CompilerGenerated]
		get
		{
			return ycbg4T7E0HP;
		}
		[CompilerGenerated]
		set
		{
			ycbg4T7E0HP = value;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return dKgg4M7MQgf;
		}
		[CompilerGenerated]
		set
		{
			dKgg4M7MQgf = value;
		}
	}

	public string AliasExeList
	{
		[CompilerGenerated]
		get
		{
			return BoEg4ACDoRj;
		}
		[CompilerGenerated]
		set
		{
			BoEg4ACDoRj = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return Hqyg4OQb9e0;
		}
		[CompilerGenerated]
		set
		{
			Hqyg4OQb9e0 = value;
		}
	}

	[Obsolete("Use IconStr instead")]
	public ImageSource Icon
	{
		get
		{
			return Xwng4FCq3ih;
		}
		set
		{
			Xwng4FCq3ih = value;
			OnPropertyChanged("Icon");
		}
	}

	public string IconStr
	{
		get
		{
			return vJ5g4lEoWD5;
		}
		set
		{
			if (!(value == vJ5g4lEoWD5))
			{
				vJ5g4lEoWD5 = value;
				OnPropertyChanged("IconStr");
			}
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

	public ExeInfo()
	{
	}

	public ExeInfo(ExeSettings exeSettings)
	{
		Name = exeSettings.Name;
		Exe = exeSettings.Exe;
		Description = exeSettings.Path;
		Path = exeSettings.Path;
		AliasExeList = exeSettings.AliasExeList.JoinToString(";");
		IconStr = exeSettings.GetIconStr();
		vpQg4UQCyL1 = exeSettings;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool w8JRbdFQN9QbcKL7KHM9()
	{
		return xdNaBMFQrd1RFhJIarJy == null;
	}

	internal static void kPQubrFQLM2oB86dW3OQ()
	{
	}
}
