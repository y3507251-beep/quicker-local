using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Linearstar.Windows.RawInput;

public class RawInputDigitizerContact
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec kjov7dl2iLe;

		public static Func<HidButtonState, HidUsageAndPage> gMkv7ouLTxn;

		public static Func<HidButtonState, bool> Vbnv7TZD6yX;

		public static Func<HidValueState, HidUsageAndPage> pnov7MociFO;

		public static Func<string, bool> QW4v7A65G1G;

		internal static _003C_003Ec AcKBjOcOyPMvqB1I3uf4;

		static _003C_003Ec()
		{
			kjov7dl2iLe = new _003C_003Ec();
		}

		internal HidUsageAndPage UdWv7n7C14B(HidButtonState x)
		{
			return x.Button.UsageAndPage;
		}

		internal bool vrjv74GO251(HidButtonState x)
		{
			return x.IsActive;
		}

		internal HidUsageAndPage Seav756QOmY(HidValueState x)
		{
			return x.Value.UsageAndPage;
		}

		internal bool LgTv7D9lyUf(string i)
		{
			return i != null;
		}

		internal static bool JdAfjvcOpQbwKSditnbs()
		{
			return AcKBjOcOyPMvqB1I3uf4 == null;
		}

		internal static void yZckeocO213oRaT7qDYC()
		{
		}
	}

	public static readonly HidUsageAndPage UsageX;

	public static readonly HidUsageAndPage UsageY;

	public static readonly HidUsageAndPage UsagePressure;

	public static readonly HidUsageAndPage UsageInRange;

	public static readonly HidUsageAndPage UsageInvert;

	public static readonly HidUsageAndPage UsageTipSwitch;

	public static readonly HidUsageAndPage UsageBarrel;

	public static readonly HidUsageAndPage UsageEraser;

	public static readonly HidUsageAndPage UsageConfidence;

	public static readonly HidUsageAndPage UsageWidth;

	public static readonly HidUsageAndPage UsageHeight;

	public static readonly HidUsageAndPage UsageIdentifier;

	[CompilerGenerated]
	private readonly RawInputDigitizerContactKind lFUGq4k8Hs;

	[CompilerGenerated]
	private readonly int GZSGcBbmkv;

	[CompilerGenerated]
	private readonly int QL4GV84051;

	[CompilerGenerated]
	private readonly int z5yGZfwIJt;

	[CompilerGenerated]
	private readonly int WynG9T7c7n;

	[CompilerGenerated]
	private readonly int avJGhX5fkT;

	[CompilerGenerated]
	private readonly int oKiGeYOR9O;

	[CompilerGenerated]
	private readonly int? zJ6GYCAdLw;

	[CompilerGenerated]
	private readonly int? sw8GIbqXBp;

	[CompilerGenerated]
	private readonly bool? R44GWSSBsV;

	[CompilerGenerated]
	private readonly bool? dDnGkwHQGl;

	[CompilerGenerated]
	private readonly int? q0dGG6hnUD;

	[CompilerGenerated]
	private readonly int? DCPGsNP6Sm;

	[CompilerGenerated]
	private readonly int? XO4GHlUrrf;

	[CompilerGenerated]
	private bool MdWG1CmLWT;

	[CompilerGenerated]
	private bool QxEGbngljR;

	private static RawInputDigitizerContact wBx7e9iWJ5kxu67Ic4E;

	public RawInputDigitizerContactKind Kind
	{
		[CompilerGenerated]
		get
		{
			return lFUGq4k8Hs;
		}
	}

	public int X
	{
		[CompilerGenerated]
		get
		{
			return GZSGcBbmkv;
		}
	}

	public int Y
	{
		[CompilerGenerated]
		get
		{
			return QL4GV84051;
		}
	}

	public int MinX
	{
		[CompilerGenerated]
		get
		{
			return z5yGZfwIJt;
		}
	}

	public int MinY
	{
		[CompilerGenerated]
		get
		{
			return WynG9T7c7n;
		}
	}

	public int MaxX
	{
		[CompilerGenerated]
		get
		{
			return avJGhX5fkT;
		}
	}

	public int MaxY
	{
		[CompilerGenerated]
		get
		{
			return oKiGeYOR9O;
		}
	}

	public int? Pressure
	{
		[CompilerGenerated]
		get
		{
			return zJ6GYCAdLw;
		}
	}

	public int? MaxPressure
	{
		[CompilerGenerated]
		get
		{
			return sw8GIbqXBp;
		}
	}

	public bool? IsInverted
	{
		[CompilerGenerated]
		get
		{
			return R44GWSSBsV;
		}
	}

	public bool? IsButtonDown
	{
		[CompilerGenerated]
		get
		{
			return dDnGkwHQGl;
		}
	}

	public int? Width
	{
		[CompilerGenerated]
		get
		{
			return q0dGG6hnUD;
		}
	}

	public int? Height
	{
		[CompilerGenerated]
		get
		{
			return DCPGsNP6Sm;
		}
	}

	public int? Identifier
	{
		[CompilerGenerated]
		get
		{
			return XO4GHlUrrf;
		}
	}

	public bool IsTipDown
	{
		[CompilerGenerated]
		get
		{
			return MdWG1CmLWT;
		}
		[CompilerGenerated]
		set
		{
			MdWG1CmLWT = value;
		}
	}

	public bool IsEraser
	{
		[CompilerGenerated]
		get
		{
			return QxEGbngljR;
		}
		[CompilerGenerated]
		set
		{
			QxEGbngljR = value;
		}
	}

	public RawInputDigitizerContact(IEnumerable<HidButtonState> buttonStates, IEnumerable<HidValueState> valueStates)
	{
		Dictionary<HidUsageAndPage, bool> dictionary = buttonStates.ToDictionary(_003C_003Ec.gMkv7ouLTxn ?? (_003C_003Ec.gMkv7ouLTxn = _003C_003Ec.kjov7dl2iLe.UdWv7n7C14B), _003C_003Ec.Vbnv7TZD6yX ?? (_003C_003Ec.Vbnv7TZD6yX = _003C_003Ec.kjov7dl2iLe.vrjv74GO251));
		Dictionary<HidUsageAndPage, HidValueState> dictionary2 = valueStates.ToDictionary(_003C_003Ec.pnov7MociFO ?? (_003C_003Ec.pnov7MociFO = _003C_003Ec.kjov7dl2iLe.Seav756QOmY));
		GZSGcBbmkv = dictionary2[UsageX].CurrentValue;
		QL4GV84051 = dictionary2[UsageY].CurrentValue;
		z5yGZfwIJt = dictionary2[UsageX].Value.MinValue;
		WynG9T7c7n = dictionary2[UsageY].Value.MinValue;
		avJGhX5fkT = dictionary2[UsageX].Value.MaxValue;
		oKiGeYOR9O = dictionary2[UsageY].Value.MaxValue;
		if (dictionary2.TryGetValue(UsagePressure, out var value))
		{
			zJ6GYCAdLw = value.CurrentValue;
			sw8GIbqXBp = value.Value.MaxValue;
		}
		R44GWSSBsV = (dictionary.TryGetValue(UsageInvert, out var value2) ? new bool?(value2) : ((bool?)null));
		dDnGkwHQGl = (dictionary.TryGetValue(UsageBarrel, out var value3) ? new bool?(value3) : ((bool?)null));
		IsEraser = dictionary.TryGetValue(UsageEraser, out var value4) && value4;
		bool flag = (IsTipDown = dictionary[UsageTipSwitch]);
		if (IsEraser)
		{
			lFUGq4k8Hs = RawInputDigitizerContactKind.Eraser;
		}
		else
		{
			lFUGq4k8Hs = ((!flag) ? ((dictionary.TryGetValue(UsageInRange, out var value5) && value5) ? RawInputDigitizerContactKind.Hover : RawInputDigitizerContactKind.None) : ((dictionary.TryGetValue(UsageConfidence, out var value6) && value6) ? RawInputDigitizerContactKind.Finger : RawInputDigitizerContactKind.Pen));
		}
		q0dGG6hnUD = (dictionary2.TryGetValue(UsageWidth, out var value7) ? new int?(value7.CurrentValue) : ((int?)null));
		DCPGsNP6Sm = (dictionary2.TryGetValue(UsageHeight, out var value8) ? new int?(value8.CurrentValue) : ((int?)null));
		XO4GHlUrrf = (dictionary2.TryGetValue(UsageIdentifier, out var value9) ? new int?(value9.CurrentValue) : ((int?)null));
	}

	public override string ToString()
	{
		return "{" + string.Join(", ", new string[9]
		{
			$"X: {X}/{MaxX}",
			$"Y: {Y}/{MaxY}",
			$"Kind: {Kind}",
			Pressure.HasValue ? $"Pressure: {Pressure}/{MaxPressure}" : null,
			IsInverted.HasValue ? $"Inverted: {IsInverted}" : null,
			IsButtonDown.HasValue ? $"Button: {IsButtonDown}" : null,
			Width.HasValue ? $"Width: {Width}" : null,
			Height.HasValue ? $"Height: {Height}" : null,
			Identifier.HasValue ? $"Identifier: {Identifier}" : null
		}.Where(_003C_003Ec.QW4v7A65G1G ?? (_003C_003Ec.QW4v7A65G1G = _003C_003Ec.kjov7dl2iLe.LgTv7D9lyUf))) + "}";
	}

	static RawInputDigitizerContact()
	{
		UsageX = new HidUsageAndPage(1, 48);
		UsageY = new HidUsageAndPage(1, 49);
		UsagePressure = new HidUsageAndPage(13, 48);
		UsageInRange = new HidUsageAndPage(13, 50);
		UsageInvert = new HidUsageAndPage(13, 60);
		UsageTipSwitch = new HidUsageAndPage(13, 66);
		UsageBarrel = new HidUsageAndPage(13, 68);
		UsageEraser = new HidUsageAndPage(13, 69);
		UsageConfidence = new HidUsageAndPage(13, 71);
		UsageWidth = new HidUsageAndPage(13, 72);
		UsageHeight = new HidUsageAndPage(13, 73);
		UsageIdentifier = new HidUsageAndPage(13, 81);
	}

	internal static bool Wt3V0qiyyv1MYVpYuG0()
	{
		return wBx7e9iWJ5kxu67Ic4E == null;
	}
}
