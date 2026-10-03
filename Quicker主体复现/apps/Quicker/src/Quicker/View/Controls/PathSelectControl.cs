using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Win32;

namespace Quicker.View.Controls;

public class PathSelectControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string RtgLxGD8RuO;

	internal TextBox TxtPath;

	internal Button BtnSelect;

	private bool bahLxsaRjFA;

	private static PathSelectControl Uiq8LiFu7WG4XJNAQIe4;

	public string Path
	{
		get
		{
			return TxtPath.Text;
		}
		set
		{
			TxtPath.Text = value;
		}
	}

	public string Filter
	{
		[CompilerGenerated]
		get
		{
			return RtgLxGD8RuO;
		}
		[CompilerGenerated]
		set
		{
			RtgLxGD8RuO = value;
		}
	}

	public PathSelectControl()
	{
		InitializeComponent();
	}

	private void ChhLxkdPuXs(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.DereferenceLinks = false;
		openFileDialog.Filter = Filter;
		if (openFileDialog.ShowDialog() == true)
		{
			Path = openFileDialog.FileName;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bahLxsaRjFA)
		{
			bahLxsaRjFA = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/pathselectcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			bahLxsaRjFA = true;
			break;
		case 2:
			BtnSelect = (Button)target;
			BtnSelect.Click += ChhLxkdPuXs;
			break;
		case 1:
			TxtPath = (TextBox)target;
			break;
		}
	}

	internal static bool EnFc8TFu4KSjjY48qT4g()
	{
		return Uiq8LiFu7WG4XJNAQIe4 == null;
	}
}
