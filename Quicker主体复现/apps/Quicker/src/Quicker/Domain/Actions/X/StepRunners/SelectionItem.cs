using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;

namespace Quicker.Domain.Actions.X.StepRunners;

public class SelectionItem : INotifyPropertyChanged
{
	[CompilerGenerated]
	private string tlbtDoleLVn;

	[CompilerGenerated]
	private string WKotDTwtcny;

	[CompilerGenerated]
	private string fI3tDM2bMC9;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static SelectionItem jTaeEpQqFpYEmafiGrtr;

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return tlbtDoleLVn;
		}
		[CompilerGenerated]
		set
		{
			tlbtDoleLVn = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return WKotDTwtcny;
		}
		[CompilerGenerated]
		set
		{
			WKotDTwtcny = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return fI3tDM2bMC9;
		}
		[CompilerGenerated]
		set
		{
			fI3tDM2bMC9 = value;
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

	public SelectionItem()
	{
	}

	public SelectionItem(string value)
	{
		Name = value;
		Value = value;
	}

	public SelectionItem(string value, string name)
	{
		Value = value;
		Name = name;
	}

	public SelectionItem(string value, string name, string description)
	{
		Value = value;
		Name = name;
		Description = description;
	}

	public override string ToString()
	{
		return Value;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool MgjhrGQqc2MIOQrBWZLQ()
	{
		return jTaeEpQqFpYEmafiGrtr == null;
	}
}
