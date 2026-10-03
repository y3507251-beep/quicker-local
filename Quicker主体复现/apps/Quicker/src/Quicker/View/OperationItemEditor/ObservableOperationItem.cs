using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd;

namespace Quicker.View.OperationItemEditor;

public class ObservableOperationItem : ObservableObject, IOperationItem
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec GXiSDxbRLUW;

		public static Func<CommonOperationItem, ObservableOperationItem> aPTSDrJkaSZ;

		public static Action<CommonOperationItem, string> MU9SDpsliIl;

		public static Action<CommonOperationItem, string> d4nSDBxUpsW;

		public static Action<CommonOperationItem, string> I7RSDQ4RVGL;

		public static Action<CommonOperationItem, string> mZLSDj4KI66;

		public static Action<CommonOperationItem, string> aAlSDnBPE7u;

		public static Action<CommonOperationItem, string> HKFSD4FkrQ2;

		public static Action<CommonOperationItem, string> LjsSD5mBTZj;

		public static Action<CommonOperationItem, bool> FjySDDJbvPI;

		public static Action<CommonOperationItem, string> djPSDdQyG8X;

		public static Action<CommonOperationItem, IList<CommonOperationItem>> vMHSDoHjchm;

		public static Action<CommonOperationItem, string> jQOSDTqiYWc;

		public static Action<CommonOperationItem, string> JiaSDMdIIMW;

		public static Action<CommonOperationItem, IDictionary<string, object>> hXfSDAF6kJD;

		public static Func<ObservableOperationItem, CommonOperationItem> peSSDOmMGtS;

		private static _003C_003Ec hX6EclWmLrrlwmFNhItO;

		static _003C_003Ec()
		{
			GXiSDxbRLUW = new _003C_003Ec();
		}

		internal ObservableOperationItem rXpSDhXij0m(CommonOperationItem x)
		{
			return new ObservableOperationItem(x);
		}

		internal void kwgSDemw6CX(CommonOperationItem o, string n)
		{
			o.Title = n;
		}

		internal void EspSDYaVFNl(CommonOperationItem o, string n)
		{
			o.Icon = n;
		}

		internal void JylSDIVfSwF(CommonOperationItem o, string n)
		{
			o.Description = n;
		}

		internal void ECoSDWrSwn3(CommonOperationItem o, string n)
		{
			o.Data = n;
		}

		internal void HyOSDkpYvpf(CommonOperationItem o, string n)
		{
			o.DataType = n;
		}

		internal void TJUSDG9qIsS(CommonOperationItem o, string n)
		{
			o.Operation = n;
		}

		internal void reCSDsSeNRA(CommonOperationItem o, string n)
		{
			o.Action = n;
		}

		internal void vrRSDHNT5LI(CommonOperationItem o, bool n)
		{
			o.IsSeparator = n;
		}

		internal void qUGSD1l59nK(CommonOperationItem o, string n)
		{
			o.OriginText = n;
		}

		internal void NSWSDbsBgqs(CommonOperationItem o, IList<CommonOperationItem> n)
		{
			o.Menu = n;
		}

		internal void uGsSD6tryNo(CommonOperationItem o, string n)
		{
			o.SecondaryIcon = n;
		}

		internal void bTtSDXT9TDY(CommonOperationItem o, string n)
		{
			o.SpName = n;
		}

		internal void NMISDm941Xo(CommonOperationItem o, IDictionary<string, object> n)
		{
			o.ExtraData = n;
		}

		internal CommonOperationItem jYxSDKJBNJW(ObservableOperationItem x)
		{
			return x.GetItem();
		}

		internal static bool XIElIfWmu0we2Mhsmq3q()
		{
			return hX6EclWmLrrlwmFNhItO == null;
		}
	}

	private readonly CommonOperationItem QI2L77kxMC3;

	[CompilerGenerated]
	private readonly SmartCollection<ObservableOperationItem> OVvL7Ryoo8A = new SmartCollection<ObservableOperationItem>();

	internal static ObservableOperationItem WArGN5F0iKxHAjKmlcnJ;

	public string Title
	{
		get
		{
			return QI2L77kxMC3.Title;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Title, value, QI2L77kxMC3, _003C_003Ec.MU9SDpsliIl ?? (_003C_003Ec.MU9SDpsliIl = _003C_003Ec.GXiSDxbRLUW.kwgSDemw6CX), "Title");
		}
	}

	public string Icon
	{
		get
		{
			return QI2L77kxMC3.Icon;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Icon, value, QI2L77kxMC3, _003C_003Ec.d4nSDBxUpsW ?? (_003C_003Ec.d4nSDBxUpsW = _003C_003Ec.GXiSDxbRLUW.EspSDYaVFNl), "Icon");
		}
	}

	public string Description
	{
		get
		{
			return QI2L77kxMC3.Description;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Description, value, QI2L77kxMC3, _003C_003Ec.I7RSDQ4RVGL ?? (_003C_003Ec.I7RSDQ4RVGL = _003C_003Ec.GXiSDxbRLUW.JylSDIVfSwF), "Description");
		}
	}

	public string Data
	{
		get
		{
			return QI2L77kxMC3.Data;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Data, value, QI2L77kxMC3, _003C_003Ec.mZLSDj4KI66 ?? (_003C_003Ec.mZLSDj4KI66 = _003C_003Ec.GXiSDxbRLUW.ECoSDWrSwn3), "Data");
		}
	}

	public string DataType
	{
		get
		{
			return QI2L77kxMC3.DataType;
		}
		set
		{
			SetProperty(QI2L77kxMC3.DataType, value, QI2L77kxMC3, _003C_003Ec.aAlSDnBPE7u ?? (_003C_003Ec.aAlSDnBPE7u = _003C_003Ec.GXiSDxbRLUW.HyOSDkpYvpf), "DataType");
		}
	}

	public string Operation
	{
		get
		{
			return QI2L77kxMC3.Operation;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Operation, value, QI2L77kxMC3, _003C_003Ec.HKFSD4FkrQ2 ?? (_003C_003Ec.HKFSD4FkrQ2 = _003C_003Ec.GXiSDxbRLUW.TJUSDG9qIsS), "Operation");
		}
	}

	public string Action
	{
		get
		{
			return QI2L77kxMC3.Action;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Action, value, QI2L77kxMC3, _003C_003Ec.LjsSD5mBTZj ?? (_003C_003Ec.LjsSD5mBTZj = _003C_003Ec.GXiSDxbRLUW.reCSDsSeNRA), "Action");
		}
	}

	public bool IsSeparator
	{
		get
		{
			return QI2L77kxMC3.IsSeparator;
		}
		set
		{
			SetProperty(QI2L77kxMC3.IsSeparator, value, QI2L77kxMC3, _003C_003Ec.FjySDDJbvPI ?? (_003C_003Ec.FjySDDJbvPI = _003C_003Ec.GXiSDxbRLUW.vrRSDHNT5LI), "IsSeparator");
		}
	}

	public string OriginText
	{
		get
		{
			return QI2L77kxMC3.OriginText;
		}
		set
		{
			SetProperty(QI2L77kxMC3.OriginText, value, QI2L77kxMC3, _003C_003Ec.djPSDdQyG8X ?? (_003C_003Ec.djPSDdQyG8X = _003C_003Ec.GXiSDxbRLUW.qUGSD1l59nK), "OriginText");
		}
	}

	public IList<CommonOperationItem> Menu
	{
		get
		{
			return QI2L77kxMC3.Menu;
		}
		set
		{
			SetProperty(QI2L77kxMC3.Menu, value, QI2L77kxMC3, _003C_003Ec.vMHSDoHjchm ?? (_003C_003Ec.vMHSDoHjchm = _003C_003Ec.GXiSDxbRLUW.NSWSDbsBgqs), "Menu");
		}
	}

	public string SecondaryIcon
	{
		get
		{
			return QI2L77kxMC3.SecondaryIcon;
		}
		set
		{
			SetProperty(QI2L77kxMC3.SecondaryIcon, value, QI2L77kxMC3, _003C_003Ec.jQOSDTqiYWc ?? (_003C_003Ec.jQOSDTqiYWc = _003C_003Ec.GXiSDxbRLUW.uGsSD6tryNo), "SecondaryIcon");
		}
	}

	public string SpName
	{
		get
		{
			return QI2L77kxMC3.SpName;
		}
		set
		{
			SetProperty(QI2L77kxMC3.SpName, value, QI2L77kxMC3, _003C_003Ec.JiaSDMdIIMW ?? (_003C_003Ec.JiaSDMdIIMW = _003C_003Ec.GXiSDxbRLUW.bTtSDXT9TDY), "SpName");
		}
	}

	public IDictionary<string, object> ExtraData
	{
		get
		{
			return QI2L77kxMC3.ExtraData;
		}
		set
		{
			SetProperty(QI2L77kxMC3.ExtraData, value, QI2L77kxMC3, _003C_003Ec.hXfSDAF6kJD ?? (_003C_003Ec.hXfSDAF6kJD = _003C_003Ec.GXiSDxbRLUW.NMISDm941Xo), "ExtraData");
		}
	}

	public SmartCollection<ObservableOperationItem> Children
	{
		[CompilerGenerated]
		get
		{
			return OVvL7Ryoo8A;
		}
	}

	public ObservableOperationItem(CommonOperationItem item)
	{
		QI2L77kxMC3 = item;
		if (item.Children.HasData())
		{
			Children.Reset(item.Children.Select(_003C_003Ec.aPTSDrJkaSZ ?? (_003C_003Ec.aPTSDrJkaSZ = _003C_003Ec.GXiSDxbRLUW.rXpSDhXij0m)));
		}
		if (item.IsSeparator)
		{
			QI2L77kxMC3.Title = "----";
		}
	}

	public CommonOperationItem GetItem()
	{
		QI2L77kxMC3.Children = Children.Select(_003C_003Ec.peSSDOmMGtS ?? (_003C_003Ec.peSSDOmMGtS = _003C_003Ec.GXiSDxbRLUW.jYxSDKJBNJW)).ToList();
		return QI2L77kxMC3;
	}

	internal static bool d2Ge5MF0l6RfW6fyVfN3()
	{
		return WArGN5F0iKxHAjKmlcnJ == null;
	}
}
