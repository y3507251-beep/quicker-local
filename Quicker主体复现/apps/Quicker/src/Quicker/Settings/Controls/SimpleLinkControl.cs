using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Utilities;

namespace Quicker.Settings.Controls;

public class SimpleLinkControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string Skej1roiys;

	internal TextBlock LblAppDatFolder;

	private bool jMPjbhKlYL;

	private static SimpleLinkControl A7qXqoSxQAbNWQRtLrn;

	public string Url
	{
		get
		{
			if (LblAppDatFolder.Tag != null)
			{
				return (string)LblAppDatFolder.Tag;
			}
			return "";
		}
		set
		{
			LblAppDatFolder.Tag = value;
			if (string.IsNullOrEmpty(Text))
			{
				Text = value;
			}
		}
	}

	public string Text
	{
		get
		{
			return LblAppDatFolder.Text;
		}
		set
		{
			LblAppDatFolder.Text = value;
		}
	}

	public string Browser
	{
		[CompilerGenerated]
		get
		{
			return Skej1roiys;
		}
		[CompilerGenerated]
		set
		{
			Skej1roiys = value;
		}
	}

	public SimpleLinkControl()
	{
		InitializeComponent();
	}

	private void xA6jH51P0v(object sender, MouseButtonEventArgs e)
	{
		if (string.IsNullOrEmpty(LblAppDatFolder.Tag as string))
		{
			return;
		}
		if (!string.IsNullOrEmpty(Browser))
		{
			try
			{
				Process.Start(Browser, LblAppDatFolder.Tag as string);
				return;
			}
			catch (Exception)
			{
				AppHelper.TryOpenUrlOrFile(LblAppDatFolder.Tag as string);
				return;
			}
		}
		AppHelper.TryOpenUrlOrFile(LblAppDatFolder.Tag as string);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!jMPjbhKlYL)
		{
			jMPjbhKlYL = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/controls/simplelinkcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			LblAppDatFolder = (TextBlock)target;
			LblAppDatFolder.MouseDown += xA6jH51P0v;
		}
		else
		{
			jMPjbhKlYL = true;
		}
	}

	static SimpleLinkControl()
	{
	}

	internal static bool aDjGl7SIwukWTFEJ3ht()
	{
		return A7qXqoSxQAbNWQRtLrn == null;
	}

	internal static void zxF6kxStBUtCyeuCt9o()
	{
	}
}
