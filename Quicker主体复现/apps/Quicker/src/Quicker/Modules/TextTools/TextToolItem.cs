using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quicker.Modules.TextTools;

public class TextToolItem : INotifyPropertyChanged
{
	[CompilerGenerated]
	private string GtRtvHFYT7v;

	[CompilerGenerated]
	private string fcFtv1Pd54n;

	[CompilerGenerated]
	private string NYCtvbuFnUc = string.Empty;

	[CompilerGenerated]
	private TextToolType XAhtv6n1Sqa;

	[CompilerGenerated]
	private Func<TextToolContext, BaseTextTool> amLtvXEPN46;

	[CompilerGenerated]
	private bool kZctvmqUKUt = true;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static TextToolItem DMnNOjQyTWvNYsNXdijV;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return GtRtvHFYT7v;
		}
		[CompilerGenerated]
		set
		{
			GtRtvHFYT7v = value;
		}
	}

	public string Tooltip
	{
		[CompilerGenerated]
		get
		{
			return fcFtv1Pd54n;
		}
		[CompilerGenerated]
		set
		{
			fcFtv1Pd54n = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return NYCtvbuFnUc;
		}
		[CompilerGenerated]
		set
		{
			NYCtvbuFnUc = value;
		}
	}

	public TextToolType ToolType
	{
		[CompilerGenerated]
		get
		{
			return XAhtv6n1Sqa;
		}
		[CompilerGenerated]
		set
		{
			XAhtv6n1Sqa = value;
		}
	}

	public Func<TextToolContext, BaseTextTool> CreateToolFunc
	{
		[CompilerGenerated]
		get
		{
			return amLtvXEPN46;
		}
		[CompilerGenerated]
		set
		{
			amLtvXEPN46 = value;
		}
	}

	public bool CanBeUsedInAction
	{
		[CompilerGenerated]
		get
		{
			return kZctvmqUKUt;
		}
		[CompilerGenerated]
		set
		{
			kZctvmqUKUt = value;
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

	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		OnPropertyChanged(propertyName);
		return true;
	}

	internal static bool nxTn2gQym4CWy7c8w5Dj()
	{
		return DMnNOjQyTWvNYsNXdijV == null;
	}
}
