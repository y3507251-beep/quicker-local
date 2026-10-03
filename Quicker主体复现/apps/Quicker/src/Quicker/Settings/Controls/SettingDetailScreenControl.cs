using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Settings.Pages;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.Settings.Controls;

public class SettingDetailScreenControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public SettingPageId? oEsvVZGWhpg;

		private static _003C_003Ec__DisplayClass10_0 J0chfjcNxHAvPLUJjR8j;

		internal bool wL5vVVnTwRL(SettingPageInfo x)
		{
			return x.Id == oEsvVZGWhpg;
		}

		internal static bool kSO44xcNIlWMJO7rmCgJ()
		{
			return J0chfjcNxHAvPLUJjR8j == null;
		}
	}

	[CompilerGenerated]
	private readonly SmartCollection<SettingPageInfo> B3dj4NaYRm = new SmartCollection<SettingPageInfo>();

	private DispatcherTimer XErj5KMypk;

	private bool EL7jDpA2Pe;

	internal Grid GridContent;

	internal ListBox LbMenu;

	internal Button BtnHelp;

	internal ContentControl EditorHolder;

	internal Button BtnRevertSettings;

	internal Button BtnApplySettings;

	private bool VMQjdH5P4f;

	private static SettingDetailScreenControl Pbn2RcSSV8g7jyRJFRP;

	public SmartCollection<SettingPageInfo> Pages
	{
		[CompilerGenerated]
		get
		{
			return B3dj4NaYRm;
		}
	}

	public SettingPageInfo CurrentPage => LbMenu.SelectedItem as SettingPageInfo;

	public SettingDetailScreenControl()
	{
		InitializeComponent();
		LbMenu.ItemsSource = Pages;
		XErj5KMypk = new DispatcherTimer(new TimeSpan(0, 0, 2), DispatcherPriority.ApplicationIdle, vPvjmMtuwn, Dispatcher.CurrentDispatcher);
		base.Loaded += d9hjXL5iTs;
		base.Unloaded += ziIj6awLBq;
	}

	private void ziIj6awLBq(object sender, RoutedEventArgs e)
	{
		XErj5KMypk.Stop();
	}

	private void d9hjXL5iTs(object sender, RoutedEventArgs e)
	{
		XErj5KMypk.Start();
	}

	private void vPvjmMtuwn(object sender, EventArgs e)
	{
	}

	public bool Load(SettingMenuItem settingMenuItem, SettingPageId? selectedPageId)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.oEsvVZGWhpg = selectedPageId;
		if (settingMenuItem == null || !settingMenuItem.Pages.HasData())
		{
			AppHelper.ShowWarning("没有页面！");
			return false;
		}
		Pages.Reset(settingMenuItem.Pages);
		SettingPageInfo settingPageInfo = settingMenuItem.Pages.FirstOrDefault(_003C_003Ec__DisplayClass10_.wL5vVVnTwRL);
		if (settingPageInfo != null)
		{
			LbMenu.SelectedItem = settingPageInfo;
		}
		else
		{
			LbMenu.SelectedItem = settingMenuItem.Pages[0];
		}
		return true;
	}

	private void tlUjKJTp9v(object sender, SelectionChangedEventArgs e)
	{
		if (EL7jDpA2Pe)
		{
			return;
		}
		BtnRevertSettings.Visibility = Visibility.Collapsed;
		if (!(LbMenu.SelectedItem is SettingPageInfo settingPageInfo))
		{
			return;
		}
		if (UnloadSettingPage())
		{
			object obj = Activator.CreateInstance(settingPageInfo.EditControl);
			EditorHolder.Content = obj;
			XErj5KMypk.Start();
			l6VjxVjjnF(obj);
		}
		else
		{
			EL7jDpA2Pe = true;
			try
			{
				LbMenu.SelectedItem = ((e.RemovedItems.Count > 0) ? e.RemovedItems[0] : null);
			}
			finally
			{
				EL7jDpA2Pe = false;
			}
		}
		if (AppState.HHxtaMaoqJr().RememberLastConfigPage && dDh7g7Xw7JyQPUTbYwJ.BWhtHHAiaSf() != settingPageInfo.Id)
		{
			int num = 0;
			if (Pbn2RcSSV8g7jyRJFRP != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			dDh7g7Xw7JyQPUTbYwJ.tC9tH1ELoWJ(settingPageInfo.Id);
		}
	}

	private void l6VjxVjjnF(object object_0)
	{
		BtnApplySettings.Visibility = ((!(object_0 is SettingPage { ShowSaveButton: not false })) ? Visibility.Collapsed : Visibility.Visible);
	}

	private void KPfjrkviLQ(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void Close()
	{
		if (UnloadSettingPage())
		{
			EditorHolder.Content = null;
			LbMenu.SelectedItem = null;
			((SettingsWindow2)Window.GetWindow(this)).CloseDetailPage();
		}
	}

	public bool UnloadSettingPage()
	{
		if (EditorHolder.Content != null && EditorHolder.Content is SettingPage settingPage)
		{
			bool result = settingPage.OnUnloading();
			XErj5KMypk.Stop();
			return result;
		}
		XErj5KMypk.Stop();
		return true;
	}

	private void tK1jpNUrnA(object sender, RoutedEventArgs e)
	{
		if (EditorHolder.Content != null && EditorHolder.Content is SettingPage settingPage)
		{
			(bool, bool) tuple = settingPage.SaveData();
			BtnRevertSettings.Visibility = ((!tuple.Item2) ? Visibility.Collapsed : Visibility.Visible);
			AppHelper.ShowInformation("已保存设置。");
		}
	}

	private void st5jBxcxLe(object sender, RoutedEventArgs e)
	{
		if (EditorHolder.Content is SettingPage settingPage)
		{
			settingPage.RestoreData();
		}
		BtnRevertSettings.Visibility = Visibility.Collapsed;
	}

	internal static string KEqjQtbCZL(string string_0, string string_1)
	{
		string_0 = string_0.TrimEnd('/');
		string_1 = string_1.TrimStart('/');
		return $"{string_0}/{string_1}";
	}

	private void xctjjNEa8v(object sender, RoutedEventArgs e)
	{
		if (CurrentPage != null)
		{
			if (CurrentPage.HelpLink.IsNullOrEmpty())
			{
				AppHelper.TryOpenUrlOrFile(string.Format("{0}/settings-{1}", "https://getquicker.net/KC/Manual/Doc", CurrentPage.Id));
			}
			else if (CurrentPage.HelpLink.StartsWith("http", StringComparison.OrdinalIgnoreCase))
			{
				AppHelper.TryOpenUrlOrFile(CurrentPage.HelpLink);
			}
			else
			{
				AppHelper.TryOpenUrlOrFile(KEqjQtbCZL("https://getquicker.net/KC/Manual/Doc", CurrentPage.HelpLink));
			}
		}
		else
		{
			AppHelper.ShowWarning("没有加载设置页。");
		}
	}

	private void UabjnAl4ki(object sender, MouseButtonEventArgs e)
	{
		try
		{
			string text = $"quicker://settings:{CurrentPage.Id}";
			ClipboardHelper.SetHtml("<a href='" + text + "'>" + CurrentPage.Title + "</a>", text);
			AppHelper.ShowSuccess("已复制");
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning(exception.GetMessageWithInner());
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!VMQjdH5P4f)
		{
			VMQjdH5P4f = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/controls/settingdetailscreencontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			VMQjdH5P4f = true;
			break;
		case 1:
			GridContent = (Grid)target;
			break;
		case 2:
			LbMenu = (ListBox)target;
			LbMenu.SelectionChanged += tlUjKJTp9v;
			break;
		case 3:
			BtnHelp = (Button)target;
			BtnHelp.Click += xctjjNEa8v;
			BtnHelp.MouseRightButtonDown += UabjnAl4ki;
			break;
		case 4:
			EditorHolder = (ContentControl)target;
			break;
		case 5:
			BtnRevertSettings = (Button)target;
			BtnRevertSettings.Click += st5jBxcxLe;
			break;
		case 6:
			BtnApplySettings = (Button)target;
			BtnApplySettings.Click += tK1jpNUrnA;
			break;
		}
	}

	internal static void eS8JPSSm5YVlfkxnM73()
	{
	}

	internal static bool LihTZjSwrKjhuuC7iFY()
	{
		return Pbn2RcSSV8g7jyRJFRP == null;
	}
}
