using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;

namespace Quicker.View.Progress;

public class ProgressReportItem : INotifyPropertyChanged
{
	private string O7nL2Acopjo;

	private string C72L2OrOoUX;

	private double vR0L2FNutNY;

	private string KnvL2UVJZrL;

	private CancellationTokenSource LGpL2l2rBsi;

	[CompilerGenerated]
	private int DfUL2i3qGoj;

	[CompilerGenerated]
	private int MYEL23gfh6L;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ProgressReportItem WthbsSFjym0go9bLKanU;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return DfUL2i3qGoj;
		}
		[CompilerGenerated]
		set
		{
			DfUL2i3qGoj = value;
		}
	}

	public CancellationTokenSource Cts
	{
		get
		{
			return LGpL2l2rBsi;
		}
		set
		{
			LGpL2l2rBsi = value;
			OnPropertyChanged("Cts");
		}
	}

	public string Title
	{
		get
		{
			return O7nL2Acopjo;
		}
		set
		{
			O7nL2Acopjo = value;
			OnPropertyChanged("Title");
		}
	}

	public string Icon
	{
		get
		{
			return C72L2OrOoUX;
		}
		set
		{
			C72L2OrOoUX = value;
			OnPropertyChanged("Icon");
		}
	}

	public double Percent
	{
		get
		{
			return vR0L2FNutNY;
		}
		set
		{
			vR0L2FNutNY = value;
			OnPropertyChanged("Percent");
		}
	}

	public string Text
	{
		get
		{
			return KnvL2UVJZrL;
		}
		set
		{
			KnvL2UVJZrL = value;
			OnPropertyChanged("Text");
		}
	}

	public int ActionExecuteContextId
	{
		[CompilerGenerated]
		get
		{
			return MYEL23gfh6L;
		}
		[CompilerGenerated]
		set
		{
			MYEL23gfh6L = value;
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

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool UxZAGMFjpZGY2TDY3XHV()
	{
		return WthbsSFjym0go9bLKanU == null;
	}
}
