using Quicker.Utilities;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common;
using Quicker.Public.Extensions;

namespace Quicker.Modules.BrowserControl.Message;

public class ActionItemToWeb
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec XdEv6Mid7Sy;

		public static Func<char, bool> Emrv6AlO1vD;

		internal static _003C_003Ec bBi1T0cIqlG6HnD5M3GP;

		static _003C_003Ec()
		{
			XdEv6Mid7Sy = new _003C_003Ec();
		}

		internal bool Mcnv6T3fuSH(char x)
		{
			return x == ':';
		}

		internal static bool m0lnUicIi4iGl3afWTdw()
		{
			return bBi1T0cIqlG6HnD5M3GP == null;
		}
	}

	[CompilerGenerated]
	private string n7tty18m6Nw;

	[CompilerGenerated]
	private string NpUtybyqy5q;

	[CompilerGenerated]
	private string eAMty6stPW1;

	[CompilerGenerated]
	private string WJUtyXvqUIL;

	[CompilerGenerated]
	private string IsQtymSFDcm;

	[CompilerGenerated]
	private string jsLtyKkcBjB;

	private static ActionItemToWeb wc7GeyQ3lRFrAFbDL90I;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return n7tty18m6Nw;
		}
		[CompilerGenerated]
		set
		{
			n7tty18m6Nw = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return NpUtybyqy5q;
		}
		[CompilerGenerated]
		set
		{
			NpUtybyqy5q = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return eAMty6stPW1;
		}
		[CompilerGenerated]
		set
		{
			eAMty6stPW1 = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return WJUtyXvqUIL;
		}
		[CompilerGenerated]
		set
		{
			WJUtyXvqUIL = value;
		}
	}

	public string IconColor
	{
		[CompilerGenerated]
		get
		{
			return IsQtymSFDcm;
		}
		[CompilerGenerated]
		set
		{
			IsQtymSFDcm = value;
		}
	}

	public string UrlPattern
	{
		[CompilerGenerated]
		get
		{
			return jsLtyKkcBjB;
		}
		[CompilerGenerated]
		set
		{
			jsLtyKkcBjB = value;
		}
	}

	public ActionItemToWeb()
	{
	}

	public ActionItemToWeb(ActionItem action)
	{
		Id = action.Id;
		Title = action.Title.Replace("\\n", " ");
		Icon = DcItyHwBNg7(action.Icon);
		Description = action.Description;
	}

	private string DcItyHwBNg7(string string_6)
	{
		if (string.IsNullOrWhiteSpace(string_6)) return "";
		if (string_6.StartsWith("data:", StringComparison.OrdinalIgnoreCase)) return string_6;
		string encoded = "";
		AppHelper.RunOnUiThread(true, () =>
		{
		    var source = AppHelper.GetImageSourceFromIconString(string_6);
		    if (source == null) return;
		    var visual = new System.Windows.Media.DrawingVisual();
		    using (var drawing = visual.RenderOpen()) drawing.DrawImage(source, new System.Windows.Rect(0, 0, 48, 48));
		    var bitmap = new System.Windows.Media.Imaging.RenderTargetBitmap(48, 48, 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
		    bitmap.Render(visual);
		    var png = new System.Windows.Media.Imaging.PngBitmapEncoder();
		    png.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(bitmap));
		    using var stream = new System.IO.MemoryStream();
		    png.Save(stream);
		    encoded = "data:image/png;base64," + Convert.ToBase64String(stream.ToArray());
		});
		return encoded;
	}

	internal static bool SL3swoQ3ZvppAWMXirlQ()
	{
		return wc7GeyQ3lRFrAFbDL90I == null;
	}
}
