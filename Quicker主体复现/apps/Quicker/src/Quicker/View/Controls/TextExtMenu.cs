using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using c4LBdq5YohQFUgxFYw4;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.X.Nodes;

namespace Quicker.View.Controls;

public class TextExtMenu : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass22_0
	{
		public qsQtMm5MtHtoYi1dcdV ClWS37jchsH;

		private static _003C_003Ec__DisplayClass22_0 ry20boypUeMbeQeqoxfv;

		internal void NgAS3ap0jDO()
		{
			ClWS37jchsH = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Color);
		}

		internal static bool BgCntWypxIoM8IM84Bx5()
		{
			return ry20boypUeMbeQeqoxfv == null;
		}
	}

	[CompilerGenerated]
	private EventHandler<TextSelectedEventArgs> m_ValueSelected;

	[CompilerGenerated]
	private string xG2LjWtdl4w;

	[CompilerGenerated]
	private Quicker.View.X.Nodes.CaptureMode X7YLjk8RsqY;

	private System.Windows.Point LpYLjGATDkb;

	internal DropDownButton BtnMenuForFileName;

	internal ContextMenu MainContextMenu0;

	internal MenuItem MenuSelectStartMenuApps;

	internal MenuItem MenuSelectFile;

	internal MenuItem MenuSelectFolder;

	internal MenuItem MenuSelectSaveFile;

	internal MenuItem MenuSelectWindowInfo;

	internal MenuItem MenuSelectColor;

	internal MenuItem MenuSelectXY;

	internal MenuItem MenuSelectAction;

	internal MenuItem MenuSelectIcon;

	private bool py7Ljs9umsd;

	internal static TextExtMenu fyG0q2FqGXvD6o0VSkAt;

	public string CurrentValue
	{
		[CompilerGenerated]
		get
		{
			return xG2LjWtdl4w;
		}
		[CompilerGenerated]
		set
		{
			xG2LjWtdl4w = value;
		}
	}

	public ContextMenu Menu => MainContextMenu0;

	public event EventHandler<TextSelectedEventArgs> ValueSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TextSelectedEventArgs> eventHandler = this.m_ValueSelected;
			EventHandler<TextSelectedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TextSelectedEventArgs> value2 = (EventHandler<TextSelectedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TextSelectedEventArgs> eventHandler = this.m_ValueSelected;
			EventHandler<TextSelectedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TextSelectedEventArgs> value2 = (EventHandler<TextSelectedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public TextExtMenu()
	{
		InitializeComponent();
	}

	private void lrZLj0pO7pF(object sender, RoutedEventArgs e)
	{
		AppSelectorWindow appSelectorWindow = new AppSelectorWindow(true)
		{
			Owner = Window.GetWindow(this)
		};
		if (appSelectorWindow.ShowDialog() == true)
		{
			WinAppItem selectedFile = appSelectorWindow.SelectedFile;
			w2LLjC1H6Fl(selectedFile.FullPath);
		}
	}

	private void w2LLjC1H6Fl(string string_1)
	{
		this.m_ValueSelected?.Invoke(this, new TextSelectedEventArgs(string_1));
	}

	private void k71LjPec0VN(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			DereferenceLinks = false,
			Filter = "可执行程序|*.exe|任意文件|*.*",
			FilterIndex = 2
		};
		if (!string.IsNullOrEmpty(CurrentValue))
		{
			try
			{
				if (File.Exists(CurrentValue.Trim()) && Directory.Exists(Path.GetDirectoryName(CurrentValue.Trim())))
				{
					openFileDialog.InitialDirectory = Path.GetDirectoryName(CurrentValue.Trim());
				}
			}
			catch
			{
			}
		}
		bool? flag = openFileDialog.ShowDialog();
		int num = 0;
		if (!D7d4i3Fq0jlPiL1rlA6k())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag == true)
		{
			string text = openFileDialog.FileName;
			if (!File.Exists(text))
			{
				text = Path.GetDirectoryName(text);
			}
			w2LLjC1H6Fl(text);
		}
	}

	private void QgCLjEXLYcs(object sender, RoutedEventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
		{
			IsFolderPicker = true
		};
		try
		{
			if (!string.IsNullOrEmpty(CurrentValue) && Directory.Exists(CurrentValue))
			{
				commonOpenFileDialog.InitialDirectory = CurrentValue;
			}
			if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				string fileName = commonOpenFileDialog.FileName;
				w2LLjC1H6Fl(fileName);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("选择文件夹出错：" + ex.Message);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private Quicker.View.X.Nodes.CaptureMode XoULjeGXkbu()
	{
		return X7YLjk8RsqY;
	}

	[SpecialName]
	[CompilerGenerated]
	private void xPTLjYEoDm6(Quicker.View.X.Nodes.CaptureMode value)
	{
		X7YLjk8RsqY = value;
	}

	private void rRVLjyDOJBx(object sender, MouseButtonEventArgs e)
	{
		SJhLjRSeXdv();
		xPTLjYEoDm6(Quicker.View.X.Nodes.CaptureMode.ProcessName);
		MenuSelectWindowInfo.CaptureMouse();
	}

	private void eGsLj8a5Rcd(object sender, MouseButtonEventArgs e)
	{
		KtbLjqomWvx();
		MenuSelectWindowInfo.ReleaseMouseCapture();
		xPTLjYEoDm6(Quicker.View.X.Nodes.CaptureMode.None);
		try
		{
			string text = AppHelper.SelectWindowInfo(NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition()), Window.GetWindow(this));
			if (!string.IsNullOrEmpty(text))
			{
				w2LLjC1H6Fl(text);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("获取窗口信息失败。" + ex.Message);
		}
		BtnMenuForFileName.Menu.IsOpen = false;
	}

	private void O64LjaOrSE4(object sender, MouseButtonEventArgs e)
	{
		SJhLjRSeXdv();
		MenuSelectColor.CaptureMouse();
		LpYLjGATDkb = e.GetPosition(this);
	}

	private void HsdLj7IT9a2(object sender, MouseButtonEventArgs e)
	{
		KtbLjqomWvx();
		MenuSelectColor.ReleaseMouseCapture();
		if (e.GetPosition(this) == LpYLjGATDkb)
		{
			_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
			_003C_003Ec__DisplayClass22_.ClWS37jchsH = null;
			int num = 0;
			if (fyG0q2FqGXvD6o0VSkAt != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass22_.NgAS3ap0jDO);
			if (_003C_003Ec__DisplayClass22_.ClWS37jchsH.IsSuccess)
			{
				w2LLjC1H6Fl(_003C_003Ec__DisplayClass22_.ClWS37jchsH.wZFmIfirit().ToRgbHexString());
			}
		}
		else
		{
			Color colorAt = ColorHelper.GetColorAt(NativeMethods.GetMousePosition());
			w2LLjC1H6Fl(colorAt.ToRgbHexString());
		}
		BtnMenuForFileName.Menu.IsOpen = false;
	}

	private void SJhLjRSeXdv()
	{
		System.Windows.Input.Mouse.OverrideCursor = Cursors.Cross;
	}

	private void KtbLjqomWvx()
	{
		System.Windows.Input.Mouse.OverrideCursor = null;
	}

	private void ffyLjcXrE1f(object sender, MouseButtonEventArgs e)
	{
		SJhLjRSeXdv();
		MenuSelectXY.CaptureMouse();
	}

	private void fcyLjVxvLvN(object sender, MouseButtonEventArgs e)
	{
		KtbLjqomWvx();
		MenuSelectXY.ReleaseMouseCapture();
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		w2LLjC1H6Fl($"{mousePosition.X},{mousePosition.Y}");
		BtnMenuForFileName.Menu.IsOpen = false;
	}

	private void mWoLjZujOXe(object sender, RoutedEventArgs e)
	{
		SearchActionWindow searchActionWindow = new SearchActionWindow(AppState.DataService)
		{
			Owner = Window.GetWindow(this)
		};
		if (searchActionWindow.ShowDialog() != true)
		{
			return;
		}
		ActionItem result = searchActionWindow.Result;
		object obj;
		if (result == null)
		{
			obj = null;
		}
		else
		{
			obj = result.Id;
			if (obj != null)
			{
				goto IL_004b;
			}
		}
		obj = "";
		goto IL_004b;
		IL_004b:
		w2LLjC1H6Fl((string)obj);
	}

	private void P7KLj9Eggar(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSaveFileDialog("任意文件类型|*.*", "", "", "", "选择文件保存路径");
		if (tuple.Item1)
		{
			w2LLjC1H6Fl(tuple.Item2);
		}
	}

	private void SvdLjhwEwGg(object sender, RoutedEventArgs e)
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow
		{
			Owner = Window.GetWindow(this)
		};
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			w2LLjC1H6Fl(faIconSelectorWindow.SelectedIcon.ToString());
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!py7Ljs9umsd)
		{
			py7Ljs9umsd = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/textextmenu.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			py7Ljs9umsd = true;
			break;
		case 1:
			BtnMenuForFileName = (DropDownButton)target;
			break;
		case 2:
			MainContextMenu0 = (ContextMenu)target;
			break;
		case 3:
			MenuSelectStartMenuApps = (MenuItem)target;
			MenuSelectStartMenuApps.Click += lrZLj0pO7pF;
			break;
		case 4:
			MenuSelectFile = (MenuItem)target;
			MenuSelectFile.Click += k71LjPec0VN;
			break;
		case 5:
			MenuSelectFolder = (MenuItem)target;
			MenuSelectFolder.Click += QgCLjEXLYcs;
			break;
		case 6:
			MenuSelectSaveFile = (MenuItem)target;
			MenuSelectSaveFile.Click += P7KLj9Eggar;
			break;
		case 7:
			MenuSelectWindowInfo = (MenuItem)target;
			MenuSelectWindowInfo.PreviewMouseDown += rRVLjyDOJBx;
			MenuSelectWindowInfo.PreviewMouseUp += eGsLj8a5Rcd;
			break;
		case 8:
			MenuSelectColor = (MenuItem)target;
			num = 1;
			if (!D7d4i3Fq0jlPiL1rlA6k())
			{
				goto IL_016c;
			}
			goto IL_0170;
		case 9:
			MenuSelectXY = (MenuItem)target;
			MenuSelectXY.PreviewMouseDown += ffyLjcXrE1f;
			num = 0;
			if (fyG0q2FqGXvD6o0VSkAt != null)
			{
				goto IL_016c;
			}
			goto IL_0170;
		case 10:
			MenuSelectAction = (MenuItem)target;
			MenuSelectAction.Click += mWoLjZujOXe;
			break;
		case 11:
			{
				MenuSelectIcon = (MenuItem)target;
				MenuSelectIcon.Click += SvdLjhwEwGg;
				break;
			}
			IL_016c:
			num = num2;
			goto IL_0170;
			IL_0170:
			switch (num)
			{
			default:
				MenuSelectXY.PreviewMouseUp += fcyLjVxvLvN;
				break;
			case 1:
				MenuSelectColor.PreviewMouseDown += O64LjaOrSE4;
				MenuSelectColor.PreviewMouseUp += HsdLj7IT9a2;
				break;
			}
			break;
		}
	}

	internal static bool D7d4i3Fq0jlPiL1rlA6k()
	{
		return fyG0q2FqGXvD6o0VSkAt == null;
	}
}
