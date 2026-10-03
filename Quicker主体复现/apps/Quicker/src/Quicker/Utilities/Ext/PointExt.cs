using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using Quicker.Public.Extensions;

namespace Quicker.Utilities.Ext;

public static class PointExt
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass2_0
	{
		public Rectangle FUR2NywRDqg;
	}

	private static object XiDavhFIPOoovRo03ZFr;

	public static string ToValue(this System.Drawing.Point point)
	{
		return $"{point.X},{point.Y}";
	}

	public static System.Drawing.Point FromValue(string ptStr)
	{
		if (string.IsNullOrEmpty(ptStr))
		{
			throw new InvalidDataException("坐标内容为空");
		}
		string[] array = ptStr.Split(',', '，');
		if (array.Length != 2)
		{
			throw new InvalidDataException("坐标格式不正确");
		}
		int x = seYLiK5Krdp(array[0].Trim());
		int y = YMaLix00VJC(array[1].Trim());
		return new System.Drawing.Point(x, y);
	}

	public static System.Drawing.Point FromValue(string ptStr, Rectangle rect)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_0_ = default(_003C_003Ec__DisplayClass2_0);
		_003C_003Ec__DisplayClass2_0_.FUR2NywRDqg = rect;
		if (string.IsNullOrEmpty(ptStr))
		{
			throw new InvalidDataException("坐标内容为空");
		}
		string[] array = ptStr.Split(',', '，');
		if (array.Length != 2)
		{
			throw new InvalidDataException("坐标格式不正确");
		}
		int x = PFyLiro4WSl(array[0].Trim(), ref _003C_003Ec__DisplayClass2_0_);
		int y = CaGLipqQ6Xk(array[1].Trim(), ref _003C_003Ec__DisplayClass2_0_);
		return new System.Drawing.Point(x, y);
	}

	public static System.Windows.Point ToWindowsPoint(this System.Drawing.Point pt)
	{
		return new System.Windows.Point(pt.X, pt.Y);
	}

	[CompilerGenerated]
	internal static int seYLiK5Krdp(string string_0)
	{
		if (string_0.EndsWith("%"))
		{
			return (int)((double)Screen.PrimaryScreen.Bounds.Left + string_0.PercentToDouble() * (double)Screen.PrimaryScreen.Bounds.Width);
		}
		return int.Parse(string_0);
	}

	[CompilerGenerated]
	internal static int YMaLix00VJC(string string_0)
	{
		if (string_0.EndsWith("%"))
		{
			return (int)((double)Screen.PrimaryScreen.Bounds.Top + string_0.PercentToDouble() * (double)Screen.PrimaryScreen.Bounds.Height);
		}
		return int.Parse(string_0);
	}

	[CompilerGenerated]
	internal static int PFyLiro4WSl(string string_0, ref _003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_0_0)
	{
		if (string_0.EndsWith("%"))
		{
			return (int)((double)_003C_003Ec__DisplayClass2_0_0.FUR2NywRDqg.Left + string_0.PercentToDouble() * (double)_003C_003Ec__DisplayClass2_0_0.FUR2NywRDqg.Width);
		}
		return int.Parse(string_0) + _003C_003Ec__DisplayClass2_0_0.FUR2NywRDqg.Left;
	}

	[CompilerGenerated]
	internal static int CaGLipqQ6Xk(string string_0, ref _003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_0_0)
	{
		if (string_0.EndsWith("%"))
		{
			return (int)((double)_003C_003Ec__DisplayClass2_0_0.FUR2NywRDqg.Top + string_0.PercentToDouble() * (double)_003C_003Ec__DisplayClass2_0_0.FUR2NywRDqg.Height);
		}
		return int.Parse(string_0) + _003C_003Ec__DisplayClass2_0_0.FUR2NywRDqg.Top;
	}

	internal static bool cloiQrFIMuKR7x7jO8ai()
	{
		return XiDavhFIPOoovRo03ZFr == null;
	}
}
