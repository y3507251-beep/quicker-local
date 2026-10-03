using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Annotations;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.View.X.Controls;

public class VariableOrValueSelectItem : INotifyPropertyChanged
{
	private string r2YLXBNpKNh;

	private string MOOLXQtkkEq;

	private string woGLXjrXrsK;

	private string MucLXnMBi35;

	[CompilerGenerated]
	private bool laDLX4wU7sd = true;

	[CompilerGenerated]
	private string TQ2LX5oXKTM;

	[CompilerGenerated]
	private VarType LMTLXDF28Wt;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static VariableOrValueSelectItem e6sGBQF9lgqXKeGnMUsk;

	public bool IsVariable
	{
		[CompilerGenerated]
		get
		{
			return laDLX4wU7sd;
		}
		[CompilerGenerated]
		set
		{
			laDLX4wU7sd = value;
		}
	}

	public string Key
	{
		get
		{
			return MOOLXQtkkEq;
		}
		set
		{
			MOOLXQtkkEq = value;
			OnPropertyChanged("Key");
		}
	}

	public string DisplayValue
	{
		[CompilerGenerated]
		get
		{
			return TQ2LX5oXKTM;
		}
		[CompilerGenerated]
		set
		{
			TQ2LX5oXKTM = value;
		}
	}

	public VarType Type
	{
		[CompilerGenerated]
		get
		{
			return LMTLXDF28Wt;
		}
		[CompilerGenerated]
		set
		{
			LMTLXDF28Wt = value;
		}
	}

	public string Desc
	{
		get
		{
			return r2YLXBNpKNh;
		}
		set
		{
			r2YLXBNpKNh = value;
			OnPropertyChanged("Desc");
		}
	}

	public string Group
	{
		get
		{
			return MucLXnMBi35;
		}
		set
		{
			if (!(value == MucLXnMBi35))
			{
				MucLXnMBi35 = value;
				OnPropertyChanged("Group");
			}
		}
	}

	public string Icon
	{
		get
		{
			return woGLXjrXrsK;
		}
		set
		{
			woGLXjrXrsK = value;
			OnPropertyChanged("Icon");
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

	public VariableOrValueSelectItem()
	{
	}

	public VariableOrValueSelectItem(string value, string desc)
	{
		IsVariable = false;
		Key = value;
		DisplayValue = desc;
		Desc = (string.Equals(value, desc) ? "" : value);
		Type = VarType.NA;
	}

	public VariableOrValueSelectItem(ActionVariable variable)
	{
		Key = variable.Key;
		DisplayValue = variable.Key;
		Type = variable.Type;
		Desc = variable.Desc;
		IsVariable = true;
		Group = variable.Group;
		Icon = AppHelper.GetVarTypeIconStr(variable.Type);
	}

	public override string ToString()
	{
		return Key ?? "";
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static VariableOrValueSelectItem()
	{
	}

	internal static bool gdYx12F9ZVTmKhpWCGkD()
	{
		return e6sGBQF9lgqXKeGnMUsk == null;
	}

	internal static void iq4O8sF9YhycEdZu3l3q()
	{
	}
}
