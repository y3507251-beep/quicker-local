using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Quicker.View.Controls;

public class WindowSelectedEventArgs : EventArgs
{
	[CompilerGenerated]
	private Point IiGLjrtQtGO;

	[CompilerGenerated]
	private IntPtr BQLLjpMxuFH;

	[CompilerGenerated]
	private string ub8LjBAm8Pm;

	[CompilerGenerated]
	private int aWpLjQcB2ej;

	[CompilerGenerated]
	private string OThLjjvNkP3;

	[CompilerGenerated]
	private Process kdVLjnyVxoa;

	internal static WindowSelectedEventArgs ilPWfnFquyalCkuZmsVk;

	public Point Point
	{
		[CompilerGenerated]
		get
		{
			return IiGLjrtQtGO;
		}
		[CompilerGenerated]
		set
		{
			IiGLjrtQtGO = value;
		}
	}

	public IntPtr HWnd
	{
		[CompilerGenerated]
		get
		{
			return BQLLjpMxuFH;
		}
		[CompilerGenerated]
		set
		{
			BQLLjpMxuFH = value;
		}
	}

	public string WindowTitle
	{
		[CompilerGenerated]
		get
		{
			return ub8LjBAm8Pm;
		}
		[CompilerGenerated]
		set
		{
			ub8LjBAm8Pm = value;
		}
	}

	public int Pid
	{
		[CompilerGenerated]
		get
		{
			return aWpLjQcB2ej;
		}
		[CompilerGenerated]
		set
		{
			aWpLjQcB2ej = value;
		}
	}

	public string ProcessName
	{
		[CompilerGenerated]
		get
		{
			return OThLjjvNkP3;
		}
		[CompilerGenerated]
		set
		{
			OThLjjvNkP3 = value;
		}
	}

	[JsonIgnore]
	public Process Process
	{
		[CompilerGenerated]
		get
		{
			return kdVLjnyVxoa;
		}
		[CompilerGenerated]
		set
		{
			kdVLjnyVxoa = value;
		}
	}

	internal static bool DIS38HFqoqrplTLl7fDv()
	{
		return ilPWfnFquyalCkuZmsVk == null;
	}

	internal static void hiZYh0FqbcXx2aNJs3WP()
	{
	}
}
