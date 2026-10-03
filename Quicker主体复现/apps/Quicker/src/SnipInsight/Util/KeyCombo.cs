using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace SnipInsight.Util;

public class KeyCombo : IEquatable<KeyCombo>
{
	[CompilerGenerated]
	private bool cJ4t2cwHDK;

	[CompilerGenerated]
	private bool dYZtuqjdBB;

	[CompilerGenerated]
	private bool k5ktNKPK8L;

	private Key oxZtJoGAmB;

	internal static KeyCombo UqysSuWMQdgk5vfrXqR;

	public bool Alt
	{
		[CompilerGenerated]
		get
		{
			return cJ4t2cwHDK;
		}
		[CompilerGenerated]
		set
		{
			cJ4t2cwHDK = value;
		}
	}

	public bool Shift
	{
		[CompilerGenerated]
		get
		{
			return dYZtuqjdBB;
		}
		[CompilerGenerated]
		set
		{
			dYZtuqjdBB = value;
		}
	}

	public bool Ctrl
	{
		[CompilerGenerated]
		get
		{
			return k5ktNKPK8L;
		}
		[CompilerGenerated]
		set
		{
			k5ktNKPK8L = value;
		}
	}

	public Key Key
	{
		get
		{
			return oxZtJoGAmB;
		}
		set
		{
			if (IsValidPrimaryKey(value))
			{
				oxZtJoGAmB = value;
			}
			else
			{
				oxZtJoGAmB = Key.None;
			}
		}
	}

	public bool HasKey => Key != Key.None;

	public bool IsValid
	{
		get
		{
			if (HasKey)
			{
				if (IsSimpleKey(Key))
				{
					if (!Alt || !Ctrl)
					{
						goto IL_0067;
					}
					if (UqysSuWMQdgk5vfrXqR == null)
					{
						switch (0)
						{
						}
					}
				}
				if (IsDependentKey(Key))
				{
					if (!Alt && !Ctrl)
					{
						return Shift;
					}
					return true;
				}
				return true;
			}
			goto IL_0067;
			IL_0067:
			return false;
		}
	}

	public bool IsEmpty
	{
		get
		{
			if (!HasKey && !Alt && !Ctrl)
			{
				return !Shift;
			}
			return false;
		}
	}

	public int VirtualKeyCode => KeyInterop.VirtualKeyFromKey(Key);

	public int KeyModifier
	{
		get
		{
			int num = 0;
			if (Alt)
			{
				num |= 1;
			}
			if (Ctrl)
			{
				num |= 2;
			}
			if (Shift)
			{
				num |= 4;
			}
			return num | 0x4000;
		}
	}

	public void Reset()
	{
		Key = Key.None;
		Ctrl = false;
		Alt = false;
		Shift = false;
	}

	public string ToDescriptiveString()
	{
		StringBuilder stringBuilder = new StringBuilder(32);
		if (Ctrl)
		{
			stringBuilder.Append("Ctrl");
		}
		if (Alt)
		{
			CMitgvyXl1(stringBuilder, " + ");
			stringBuilder.Append("Alt");
		}
		if (Shift)
		{
			CMitgvyXl1(stringBuilder, " + ");
			stringBuilder.Append("Shift");
		}
		if (HasKey)
		{
			CMitgvyXl1(stringBuilder, " + ");
			if (Key == Key.Snapshot)
			{
				stringBuilder.Append("PrintScreen");
			}
			else
			{
				stringBuilder.Append(Key.ToString());
				if (otlK1vWUZOjV1BMjtR3())
				{
					switch (0)
					{
					}
				}
			}
		}
		return stringBuilder.ToString();
	}

	private static void CMitgvyXl1(StringBuilder stringBuilder_0, string string_0)
	{
		if (stringBuilder_0.Length > 0)
		{
			stringBuilder_0.Append(string_0);
		}
	}

	public override string ToString()
	{
		if (!IsValid)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder(32);
		if (Ctrl)
		{
			stringBuilder.Append("Ctrl");
		}
		if (Alt)
		{
			CMitgvyXl1(stringBuilder, "+");
			stringBuilder.Append("Alt");
		}
		if (Shift)
		{
			CMitgvyXl1(stringBuilder, "+");
			stringBuilder.Append("Shift");
		}
		if (HasKey)
		{
			int num = 0;
			if (UqysSuWMQdgk5vfrXqR != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			CMitgvyXl1(stringBuilder, "+");
			stringBuilder.Append(Key.ToString());
		}
		return stringBuilder.ToString();
	}

	public static KeyCombo ParseOrDefault(string s)
	{
		KeyCombo keyCombo = new KeyCombo();
		if (!string.IsNullOrEmpty(s))
		{
			string[] array = s.ToLowerInvariant().Split('+');
			if (Enum.TryParse<Key>(array[array.Length - (1)].Trim(), true, out var result))
			{
				keyCombo.Key = result;
				keyCombo.Ctrl = array.Contains("ctrl");
				keyCombo.Alt = array.Contains("alt");
				keyCombo.Shift = array.Contains("shift");
				if (!keyCombo.IsValid)
				{
					keyCombo.Reset();
					int num = 0;
					if (UqysSuWMQdgk5vfrXqR != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
		}
		return keyCombo;
	}

	public static bool IsValidPrimaryKey(Key key)
	{
		switch (key)
		{
		case Key.Scroll:
		case Key.LeftShift:
		case Key.RightShift:
		case Key.LeftCtrl:
		case Key.RightCtrl:
		case Key.LeftAlt:
		case Key.RightAlt:
		case Key.BrowserBack:
		case Key.BrowserForward:
		case Key.BrowserRefresh:
		case Key.BrowserStop:
		case Key.BrowserSearch:
		case Key.BrowserFavorites:
		case Key.BrowserHome:
		case Key.VolumeMute:
		case Key.VolumeDown:
		case Key.VolumeUp:
		case Key.MediaNextTrack:
		case Key.MediaPreviousTrack:
		case Key.MediaStop:
		case Key.MediaPlayPause:
		case Key.LaunchMail:
		case Key.SelectMedia:
		case Key.LaunchApplication1:
		case Key.LaunchApplication2:
		case Key.OemPlus:
		case Key.OemComma:
		case Key.OemMinus:
		case Key.OemPeriod:
		case Key.Oem2:
		case Key.Oem3:
		case Key.AbntC1:
		case Key.AbntC2:
			if (UqysSuWMQdgk5vfrXqR == null)
			{
				switch (0)
				{
				}
			}
			goto default;
		default:
			if (V4ftvkZESn(key))
			{
				return false;
			}
			return true;
		case Key.None:
		case Key.Capital:
		case Key.KanaMode:
		case Key.JunjaMode:
		case Key.HanjaMode:
		case Key.ImeConvert:
		case Key.ImeNonConvert:
		case Key.ImeAccept:
		case Key.ImeModeChange:
		case Key.Apps:
		case Key.Sleep:
		case Key.NumLock:
		case Key.Oem1:
		case Key.Oem4:
		case Key.ImeProcessed:
		case Key.System:
		case Key.NoName:
		case Key.DeadCharProcessed:
			return false;
		}
	}

	public bool IsSimpleKey(Key key)
	{
		if ((key >= Key.A && key <= Key.Z) || (key >= Key.D0 && key <= Key.D9))
		{
			return true;
		}
		return XFqtLU3N7a(key);
	}

	public bool IsDependentKey(Key key)
	{
		if ((uint)(key - 19) > 1u && (uint)(key - 23) > 3u)
		{
			return false;
		}
		return true;
	}

	private bool XFqtLU3N7a(Key key_1)
	{
		if (key_1 != Key.Return && key_1 != Key.Space)
		{
			if (DMItSFP05Y(key_1))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public static bool IsShiftKey(Key key)
	{
		if (key != Key.LeftShift)
		{
			return key == Key.RightShift;
		}
		return true;
	}

	public static bool IsCtrlKey(Key key)
	{
		if (key != Key.LeftCtrl)
		{
			return key == Key.RightCtrl;
		}
		return true;
	}

	public static bool IsAltKey(Key key)
	{
		if (key != Key.LeftAlt)
		{
			return key == Key.RightAlt;
		}
		return true;
	}

	public static bool IsWindowsKey(Key key)
	{
		if (key != Key.LWin)
		{
			return key == Key.RWin;
		}
		return true;
	}

	private static bool V4ftvkZESn(Key key_1)
	{
		if ((uint)(key_1 - 157) > 11u && key_1 != Key.Pa1)
		{
			return false;
		}
		return true;
	}

	private static bool DMItSFP05Y(Key key_1)
	{
		switch (key_1)
		{
		default:
			return false;
		case Key.Oem1:
		case Key.OemPlus:
		case Key.OemComma:
		case Key.OemMinus:
		case Key.OemPeriod:
		case Key.Oem2:
		case Key.Oem3:
		case Key.Oem4:
		case Key.Oem5:
		case Key.Oem6:
		case Key.Oem7:
		case Key.Oem102:
		case Key.OemAttn:
		case Key.OemFinish:
		case Key.OemCopy:
		case Key.OemAuto:
		case Key.OemEnlw:
		case Key.OemBackTab:
		case Key.OemClear:
			return true;
		}
	}

	public override bool Equals(object obj)
	{
		if (obj is KeyCombo)
		{
			return Equals((KeyCombo)obj);
		}
		return false;
	}

	public bool Equals(KeyCombo other)
	{
		if (Key == other.Key && Alt == other.Alt && Ctrl == other.Ctrl)
		{
			return Shift == other.Shift;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)Key;
	}

	public KeyCombo Clone()
	{
		return new KeyCombo
		{
			Key = Key,
			Ctrl = Ctrl,
			Alt = Alt,
			Shift = Shift
		};
	}

	internal static bool otlK1vWUZOjV1BMjtR3()
	{
		return UqysSuWMQdgk5vfrXqR == null;
	}
}
