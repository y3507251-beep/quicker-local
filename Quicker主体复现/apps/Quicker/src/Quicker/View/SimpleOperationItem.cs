using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;

namespace Quicker.View;

public class SimpleOperationItem : INotifyPropertyChanged
{
	private IList<int> jOqgf9JfkGf;

	[CompilerGenerated]
	private int pa8gfhRe4nt;

	[CompilerGenerated]
	private int B0xgfe4MWvE;

	[CompilerGenerated]
	private string rZZgfYDBvyB;

	[CompilerGenerated]
	private string dWIgfIhfjNj;

	[CompilerGenerated]
	private bool p01gfWe5v8P;

	[CompilerGenerated]
	private string hjwgfkfw4TK;

	[CompilerGenerated]
	private string x7ygfGq58Qu;

	[CompilerGenerated]
	private object AV7gfsRv974;

	[CompilerGenerated]
	private string LExgfHTgxZE;

	[CompilerGenerated]
	private bool PgOgf1MYbhe;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static SimpleOperationItem f87k5NFpUEgO0yauRjU5;

	public int LineNumber
	{
		[CompilerGenerated]
		get
		{
			return pa8gfhRe4nt;
		}
		[CompilerGenerated]
		set
		{
			pa8gfhRe4nt = value;
		}
	}

	public int ItemIndex
	{
		[CompilerGenerated]
		get
		{
			return B0xgfe4MWvE;
		}
		[CompilerGenerated]
		set
		{
			B0xgfe4MWvE = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return rZZgfYDBvyB;
		}
		[CompilerGenerated]
		set
		{
			rZZgfYDBvyB = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return dWIgfIhfjNj;
		}
		[CompilerGenerated]
		set
		{
			dWIgfIhfjNj = value;
		}
	}

	public bool IsSeparator
	{
		[CompilerGenerated]
		get
		{
			return p01gfWe5v8P;
		}
		[CompilerGenerated]
		set
		{
			p01gfWe5v8P = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return hjwgfkfw4TK;
		}
		[CompilerGenerated]
		set
		{
			hjwgfkfw4TK = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return x7ygfGq58Qu;
		}
		[CompilerGenerated]
		set
		{
			x7ygfGq58Qu = value;
		}
	}

	public object Data
	{
		[CompilerGenerated]
		get
		{
			return AV7gfsRv974;
		}
		[CompilerGenerated]
		set
		{
			AV7gfsRv974 = value;
		}
	}

	public string OriginText
	{
		[CompilerGenerated]
		get
		{
			return LExgfHTgxZE;
		}
		[CompilerGenerated]
		set
		{
			LExgfHTgxZE = value;
		}
	}

	public bool ToStringFromKey
	{
		[CompilerGenerated]
		get
		{
			return PgOgf1MYbhe;
		}
		[CompilerGenerated]
		set
		{
			PgOgf1MYbhe = value;
		}
	}

	public IList<int> MatchPositions
	{
		get
		{
			return jOqgf9JfkGf;
		}
		set
		{
			if (jOqgf9JfkGf != value)
			{
				jOqgf9JfkGf = value;
				OnPropertyChanged("MatchPositions");
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

	public override string ToString()
	{
		if (ToStringFromKey)
		{
			return Key;
		}
		return Name;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static SimpleOperationItem()
	{
	}

	internal static bool c0vnENFpxlH9SPB3a5v4()
	{
		return f87k5NFpUEgO0yauRjU5 == null;
	}

	internal static void mMcOOIFptmQqDVpBfnMe()
	{
	}
}
