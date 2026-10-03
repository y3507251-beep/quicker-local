using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Win32;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View.Settings;

namespace Quicker.Modules.Searching.Builtin;

public class QuickTextSearchPluginSettingsControl : UserControl, IComponentConnector, IStyleConnector, IPluginSettingsControl
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public string Uisvby4dVaM;

		internal static _003C_003Ec__DisplayClass7_0 zTKIi0cMTOenXZOhYfMX;

		internal bool oegvbEpOyAg(QuickTextEditorWindow x)
		{
			return string.Equals(x.FilePath, Uisvby4dVaM, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool hwSqjAcMmlnV1CpX4Usl()
		{
			return zTKIi0cMTOenXZOhYfMX == null;
		}
	}

	private SmartCollection<string> cUjtCkbJnUG = new SmartCollection<string>();

	internal ListBox LbFiles;

	internal Button BtnAddFile;

	internal Button BtnCreateFile;

	private bool BCatCGqkmOr;

	private static QuickTextSearchPluginSettingsControl PPY74QQeYYK3SNH15418;

	public QuickTextSearchPluginSettingsControl()
	{
		InitializeComponent();
		LbFiles.ItemsSource = cUjtCkbJnUG;
	}

	public void LoadData(IDictionary<string, string> settings)
	{
		if (settings != null && settings.ContainsKey("PATH_LIST"))
		{
			cUjtCkbJnUG.Reset(settings["PATH_LIST"].SplitToList());
		}
	}

	public void SaveData(IDictionary<string, string> settings)
	{
		settings["PATH_LIST"] = cUjtCkbJnUG.JoinToString();
	}

	public (bool isValid, string message) IsValid()
	{
		return (isValid: true, message: "");
	}

	private void FyPtChZ5Syd(object sender, RoutedEventArgs e)
	{
		if ((sender as Button)?.Tag is string item)
		{
			cUjtCkbJnUG.Remove(item);
		}
	}

	private void PiWtCeUlVvZ(object sender, RoutedEventArgs e)
	{
		if ((sender as Button)?.Tag is string pathOrUrl)
		{
			AppHelper.TryOpenUrlOrFile(pathOrUrl);
		}
	}

	private void TThtCYYcWTT(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.Uisvby4dVaM = (sender as Button)?.Tag as string;
		QuickTextEditorWindow quickTextEditorWindow = AppHelper.FindRootWindows<QuickTextEditorWindow>().FirstOrDefault(_003C_003Ec__DisplayClass7_.oegvbEpOyAg);
		if (quickTextEditorWindow != null)
		{
			quickTextEditorWindow.Show();
			quickTextEditorWindow.Activate();
			return;
		}
		quickTextEditorWindow = new QuickTextEditorWindow(_003C_003Ec__DisplayClass7_.Uisvby4dVaM);
		int num = 0;
		if (!etfkAuQe8p7ZEypLhILk())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		quickTextEditorWindow.Show();
		quickTextEditorWindow.Activate();
	}

	private void zkTtCIGwfDv(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "文本文件|*.txt|任意文件|*.*";
		if (openFileDialog.ShowDialog() == true)
		{
			string fileName = openFileDialog.FileName;
			try
			{
				File.ReadAllText(fileName);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("打开文件出错：" + ex.Message);
			}
			cUjtCkbJnUG.Add(fileName);
		}
	}

	private void MnltCWJFwt3(object sender, RoutedEventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "文本文件|*.txt|任意文件|*.*";
		if (saveFileDialog.ShowDialog() == true)
		{
			string fileName = saveFileDialog.FileName;
			try
			{
				File.WriteAllText(fileName, "");
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("打开文件出错：" + ex.Message);
			}
			cUjtCkbJnUG.Add(fileName);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!BCatCGqkmOr)
		{
			BCatCGqkmOr = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/plugins/builtin/quicktextsearchpluginsettingscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			LbFiles = (ListBox)target;
			break;
		default:
			BCatCGqkmOr = true;
			break;
		case 4:
			BtnAddFile = (Button)target;
			BtnAddFile.Click += zkTtCIGwfDv;
			break;
		case 5:
			BtnCreateFile = (Button)target;
			BtnCreateFile.Click += MnltCWJFwt3;
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 3:
			((Button)target).Click += FyPtChZ5Syd;
			break;
		case 2:
			((Button)target).Click += TThtCYYcWTT;
			break;
		}
	}

	internal static bool etfkAuQe8p7ZEypLhILk()
	{
		return PPY74QQeYYK3SNH15418 == null;
	}
}
