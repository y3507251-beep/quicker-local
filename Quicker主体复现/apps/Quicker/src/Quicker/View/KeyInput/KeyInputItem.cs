using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.View.KeyInput;

public class KeyInputItem
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Func<string, KeyInputItem> EyeSpIK0gi7;

		public static Func<VirtualKeyCode, string> tFOSpWvjmxK;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public IList<VirtualKeyCode> WIWSpsRGeFs;

		public IList<VirtualKeyCode> uCaSpH49Vh3;

		internal static _003C_003Ec__DisplayClass29_0 JJPfnAWUrYoBS0NEqQZV;

		internal void QXaSpkXZ2ym(string keyName)
		{
			if (!string.IsNullOrEmpty(keyName))
			{
				WIWSpsRGeFs.Add(KeyboardHelper.TranslateToKeyCode(keyName));
			}
		}

		internal void MTNSpGaOMAA(string keyName)
		{
			if (!string.IsNullOrEmpty(keyName))
			{
				uCaSpH49Vh3.Add(KeyboardHelper.TranslateToKeyCode(keyName));
			}
		}

		internal static bool TVfEMfWUN9TDVVujbHag()
		{
			return JJPfnAWUrYoBS0NEqQZV == null;
		}
	}

	[CompilerGenerated]
	private KeyInputItemType p3RLgKiG2MN;

	[CompilerGenerated]
	private string C3HLgxgYRcM;

	[CompilerGenerated]
	private int? zVHLgrPjg9l;

	[CompilerGenerated]
	private IList<VirtualKeyCode> SjOLgp4TOiA = new List<VirtualKeyCode>();

	[CompilerGenerated]
	private IList<VirtualKeyCode> TMZLgBS6Jis = new List<VirtualKeyCode>();

	[CompilerGenerated]
	private VirtualKeyCode? J2ELgQvpWQF;

	internal static KeyInputItem iyZ7tYF2IZQkM9JdtORr;

	public KeyInputItemType ItemType
	{
		[CompilerGenerated]
		get
		{
			return p3RLgKiG2MN;
		}
		[CompilerGenerated]
		set
		{
			p3RLgKiG2MN = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return C3HLgxgYRcM;
		}
		[CompilerGenerated]
		set
		{
			C3HLgxgYRcM = value;
		}
	}

	public int? SleepMs
	{
		[CompilerGenerated]
		get
		{
			return zVHLgrPjg9l;
		}
		[CompilerGenerated]
		set
		{
			zVHLgrPjg9l = value;
		}
	}

	public IList<VirtualKeyCode> CtrlKeys
	{
		[CompilerGenerated]
		get
		{
			return SjOLgp4TOiA;
		}
		[CompilerGenerated]
		set
		{
			SjOLgp4TOiA = value;
		}
	}

	public IList<VirtualKeyCode> NormalKeys
	{
		[CompilerGenerated]
		get
		{
			return TMZLgBS6Jis;
		}
		[CompilerGenerated]
		set
		{
			TMZLgBS6Jis = value;
		}
	}

	public VirtualKeyCode? SingleKey
	{
		[CompilerGenerated]
		get
		{
			return J2ELgQvpWQF;
		}
		[CompilerGenerated]
		set
		{
			J2ELgQvpWQF = value;
		}
	}

	public string Icon
	{
		get
		{
			switch (ItemType)
			{
			default:
				return null;
			case KeyInputItemType.MultiKey:
			case KeyInputItemType.SingleKey:
				return AppHelper.GetSystemIconUrl("sendkeys.png");
			case KeyInputItemType.Text:
				return AppHelper.GetSystemIconUrl("send_text.png");
			case KeyInputItemType.Sleep:
				return AppHelper.GetSystemIconUrl("wait_time.png");
			}
		}
	}

	public string Description
	{
		get
		{
			if (ItemType == KeyInputItemType.MultiKey)
			{
				if (CtrlKeys.HasData())
				{
					return string.Join("+", CtrlKeys.Select(_003C_003EO.tFOSpWvjmxK ?? (_003C_003EO.tFOSpWvjmxK = KeyboardHelper.GetKeyName))) + "+ [ " + string.Join(",", NormalKeys.Select(_003C_003EO.tFOSpWvjmxK ?? (_003C_003EO.tFOSpWvjmxK = KeyboardHelper.GetKeyName))) + " ]";
				}
				return string.Join(",", NormalKeys.Select(_003C_003EO.tFOSpWvjmxK ?? (_003C_003EO.tFOSpWvjmxK = KeyboardHelper.GetKeyName)));
			}
			if (ItemType == KeyInputItemType.SingleKey)
			{
				return KeyboardHelper.GetKeyName(SingleKey.Value) ?? "";
			}
			if (ItemType == KeyInputItemType.Sleep)
			{
				return "等待 " + SleepMs + " ms";
			}
			if (ItemType == KeyInputItemType.Text)
			{
				return "文本：" + Text;
			}
			return "INVALID";
		}
	}

	public static IList<KeyInputItem> ParseLines(string data)
	{
		if (string.IsNullOrEmpty(data))
		{
			return new List<KeyInputItem>();
		}
		return data.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003EO.EyeSpIK0gi7 ?? (_003C_003EO.EyeSpIK0gi7 = ParseText)).ToList();
	}

	public static KeyInputItem ParseText(string line)
	{
		KeyInputItem keyInputItem = new KeyInputItem();
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
		string[] array = default(string[]);
		int num;
		if (line.StartsWith("@", StringComparison.Ordinal))
		{
			_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
			array = line.Substring(1).Split('|', '+');
			if (array.Length != 2)
			{
				num = 0;
				if (jWeWVJF26T3LUxJ0p6qT())
				{
					goto IL_0123;
				}
				goto IL_0134;
			}
			_003C_003Ec__DisplayClass29_.WIWSpsRGeFs = new List<VirtualKeyCode>();
			array[0].Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(_003C_003Ec__DisplayClass29_.QXaSpkXZ2ym);
			_003C_003Ec__DisplayClass29_.uCaSpH49Vh3 = new List<VirtualKeyCode>();
			goto IL_013f;
		}
		if (line.StartsWith("!", StringComparison.Ordinal) && line.Length > 1)
		{
			VirtualKeyCode value = KeyboardHelper.TranslateToKeyCode(line.Substring(1));
			keyInputItem.ItemType = KeyInputItemType.SingleKey;
			keyInputItem.SingleKey = value;
		}
		else if (line.StartsWith(";", StringComparison.OrdinalIgnoreCase))
		{
			int value2 = Convert.ToInt32(line.Substring(1), CultureInfo.InvariantCulture);
			keyInputItem.ItemType = KeyInputItemType.Sleep;
			keyInputItem.SleepMs = value2;
			num = 1;
			if (jWeWVJF26T3LUxJ0p6qT())
			{
				goto IL_0123;
			}
		}
		else if (line.StartsWith("%", StringComparison.OrdinalIgnoreCase))
		{
			string text = line.Substring(1);
			keyInputItem.ItemType = KeyInputItemType.Text;
			keyInputItem.Text = text;
		}
		else
		{
			keyInputItem.ItemType = KeyInputItemType.Text;
			keyInputItem.Text = line;
		}
		goto IL_01bf;
		IL_01bf:
		return keyInputItem;
		IL_0123:
		switch (num)
		{
		case 2:
			goto IL_013f;
		case 1:
			goto IL_01bf;
		}
		goto IL_0134;
		IL_0134:
		throw new InvalidOperationException("格式不正确。示例：win,alt,ctrl,shift|k,j,esc");
		IL_013f:
		array[1].Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(_003C_003Ec__DisplayClass29_.MTNSpGaOMAA);
		keyInputItem.ItemType = KeyInputItemType.MultiKey;
		keyInputItem.CtrlKeys = _003C_003Ec__DisplayClass29_.WIWSpsRGeFs;
		keyInputItem.NormalKeys = _003C_003Ec__DisplayClass29_.uCaSpH49Vh3;
		goto IL_01bf;
	}

	public string ToText()
	{
		if (ItemType == KeyInputItemType.MultiKey)
		{
			return "@" + string.Join(",", CtrlKeys) + "+" + string.Join(",", NormalKeys);
		}
		if (ItemType == KeyInputItemType.SingleKey)
		{
			return "!" + SingleKey.ToString();
		}
		if (ItemType == KeyInputItemType.Sleep)
		{
			return ";" + SleepMs;
		}
		if (ItemType == KeyInputItemType.Text)
		{
			return "%" + Text;
		}
		return "";
	}

	public void Execute(InputSimulator simulator)
	{
		if (ItemType == KeyInputItemType.MultiKey)
		{
			simulator.Keyboard.ModifiedKeyStroke(CtrlKeys, NormalKeys, AppHelper.kPoLTdWFLA7());
		}
		else if (ItemType == KeyInputItemType.SingleKey)
		{
			if (SingleKey.HasValue)
			{
				simulator.Keyboard.KeyPress(SingleKey.Value);
			}
		}
		else if (ItemType == KeyInputItemType.Sleep)
		{
			if (iyZ7tYF2IZQkM9JdtORr == null)
			{
				switch (0)
				{
				}
			}
			if (SleepMs > 0)
			{
				Thread.Sleep(SleepMs.Value);
			}
		}
		else if (ItemType == KeyInputItemType.Text)
		{
			simulator.Keyboard.TextEntry(Text);
		}
	}

	internal static bool jWeWVJF26T3LUxJ0p6qT()
	{
		return iyZ7tYF2IZQkM9JdtORr == null;
	}
}
