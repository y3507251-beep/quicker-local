using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using pqbejBAeefDNBsawE5C;
using Quicker.Annotations;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Modules.ExpressionTester;

internal class OperationParamItem : INotifyPropertyChanged
{
	[CompilerGenerated]
	private z1Zs1sAbPOMnx22hak7 GjuF9ocFlO;

	[CompilerGenerated]
	private ActionVariable IlYFhPbLUV;

	[CompilerGenerated]
	private string v2eFe4WAgp;

	[CompilerGenerated]
	private IList<ActionVariable> uDsFYgmObf;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static OperationParamItem wV5KHazb1RImaILQ3xS;

	public z1Zs1sAbPOMnx22hak7 Param
	{
		[CompilerGenerated]
		get
		{
			return GjuF9ocFlO;
		}
		[CompilerGenerated]
		set
		{
			GjuF9ocFlO = value;
		}
	}

	public ActionVariable SelectedVariable
	{
		[CompilerGenerated]
		get
		{
			return IlYFhPbLUV;
		}
		[CompilerGenerated]
		set
		{
			IlYFhPbLUV = value;
		}
	}

	public string StringValue
	{
		[CompilerGenerated]
		get
		{
			return v2eFe4WAgp;
		}
		[CompilerGenerated]
		set
		{
			v2eFe4WAgp = value;
		}
	}

	public IList<ActionVariable> AvailableVariables
	{
		[CompilerGenerated]
		get
		{
			return uDsFYgmObf;
		}
		[CompilerGenerated]
		set
		{
			uDsFYgmObf = value;
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

	internal static bool Xyyt8TzqEj46N00DSk7()
	{
		return wV5KHazb1RImaILQ3xS == null;
	}

	internal static void Tsvr8nzlXIgGwYxJkb4()
	{
	}
}
