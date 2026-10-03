using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using Newtonsoft.Json;
using Quicker.Actions.XActions.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.Storage;

public class ActionVariable : INotifyPropertyChanged
{
	private bool erMtd6WgEy7;

	private bool gZUtdXA8iwH;

	private bool NYEtdmCvsI1;

	private string olVtdKjlIAO;

	private string XMitdxaUiQM;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	[CompilerGenerated]
	private VarType duMtdrUoOss;

	[CompilerGenerated]
	private string Y2ftdpaydWW;

	[CompilerGenerated]
	private string HTEtdBrUxYA;

	[CompilerGenerated]
	private InputParamInfo OVetdQkFTnq;

	[CompilerGenerated]
	private OutputParamInfo MqUtdjruu9S;

	[CompilerGenerated]
	private TableDef p33tdnkZeFj;

	[CompilerGenerated]
	private string Vdltd4D8HaE;

	private string i0Xtd5P0Sxc;

	internal static ActionVariable BdK7omQqfvEM3DUtBPwU;

	public string Key
	{
		get
		{
			return XMitdxaUiQM;
		}
		set
		{
			XMitdxaUiQM = value;
			OnPropertyChanged("Key");
		}
	}

	public VarType Type
	{
		[CompilerGenerated]
		get
		{
			return duMtdrUoOss;
		}
		[CompilerGenerated]
		set
		{
			duMtdrUoOss = value;
		}
	}

	public string Desc
	{
		get
		{
			return olVtdKjlIAO;
		}
		set
		{
			olVtdKjlIAO = value;
			OnPropertyChanged("Desc");
		}
	}

	public string DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return Y2ftdpaydWW;
		}
		[CompilerGenerated]
		set
		{
			Y2ftdpaydWW = value;
		}
	}

	public bool SaveState
	{
		get
		{
			return NYEtdmCvsI1;
		}
		set
		{
			NYEtdmCvsI1 = value;
			OnPropertyChanged("SaveState");
		}
	}

	public bool IsInput
	{
		get
		{
			return erMtd6WgEy7;
		}
		set
		{
			erMtd6WgEy7 = value;
			OnPropertyChanged("IsInput");
		}
	}

	public bool IsOutput
	{
		get
		{
			return gZUtdXA8iwH;
		}
		set
		{
			gZUtdXA8iwH = value;
			OnPropertyChanged("IsOutput");
		}
	}

	public string ParamName
	{
		[CompilerGenerated]
		get
		{
			return HTEtdBrUxYA;
		}
		[CompilerGenerated]
		set
		{
			HTEtdBrUxYA = value;
		}
	}

	[JsonIgnore]
	public ImageSource Icon => AppHelper.GetVarTypeIcon(Type);

	[JsonIgnore]
	public string IconStr => AppHelper.GetVarTypeIconStr(Type);

	public InputParamInfo InputParamInfo
	{
		[CompilerGenerated]
		get
		{
			return OVetdQkFTnq;
		}
		[CompilerGenerated]
		set
		{
			OVetdQkFTnq = value;
		}
	}

	public OutputParamInfo OutputParamInfo
	{
		[CompilerGenerated]
		get
		{
			return MqUtdjruu9S;
		}
		[CompilerGenerated]
		set
		{
			MqUtdjruu9S = value;
		}
	}

	public TableDef TableDef
	{
		[CompilerGenerated]
		get
		{
			return p33tdnkZeFj;
		}
		[CompilerGenerated]
		set
		{
			p33tdnkZeFj = value;
		}
	}

	public string CustomType
	{
		[CompilerGenerated]
		get
		{
			return Vdltd4D8HaE;
		}
		[CompilerGenerated]
		set
		{
			Vdltd4D8HaE = value;
		}
	}

	public string Group
	{
		get
		{
			return i0Xtd5P0Sxc;
		}
		set
		{
			if (!(value == i0Xtd5P0Sxc))
			{
				i0Xtd5P0Sxc = value;
				OnPropertyChanged("Group");
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

	public string GetParamName()
	{
		if (!string.IsNullOrEmpty(ParamName))
		{
			return ParamName;
		}
		return Key;
	}

	protected void OnPropertyChanged([CallerMemberName] string name = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	public override string ToString()
	{
		return Key ?? "";
	}

	internal static bool UXvNQuQqbNnHBTXFqUNx()
	{
		return BdK7omQqfvEM3DUtBPwU == null;
	}
}
