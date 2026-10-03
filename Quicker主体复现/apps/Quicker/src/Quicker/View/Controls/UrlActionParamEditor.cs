using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;

namespace Quicker.View.Controls;

public class UrlActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public ActionItem LJeS36S4OQn;

		private static _003C_003Ec__DisplayClass15_0 zSVmDAy2FoTSa1eASAAu;

		internal bool APFS3bvICq0(SelectionItem x)
		{
			return x.Value == LJeS36S4OQn.Data2;
		}

		internal static bool tu6qqey2c6NHNYG97Ksi()
		{
			return zSVmDAy2FoTSa1eASAAu == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnGetIcon_OnClick_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UrlActionParamEditor _003C_003E4__this;

		private string _003Curl_003E5__2;

		private WaitWindow _003CwaitDlg_003E5__3;

		private string _003Ctitle_003E5__4;

		private ConfiguredTaskAwaitable<WebsiteInfo>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

		internal static object IfThWry2yaxwP5KpF9xe;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UrlActionParamEditor urlActionParamEditor = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0091;
				}
				_003Curl_003E5__2 = urlActionParamEditor.TxtUrl.Text;
				if (_003Curl_003E5__2.StartsWith("http", StringComparison.OrdinalIgnoreCase))
				{
					_003CwaitDlg_003E5__3 = new WaitWindow();
					_003CwaitDlg_003E5__3.Owner = Window.GetWindow(urlActionParamEditor);
					_003CwaitDlg_003E5__3.Show();
					if (!P20fniy2pu1am4QelhLq())
					{
						switch (0)
						{
						}
					}
					goto IL_0091;
				}
				MessageBoxHelper.Show("网址应该以http://或https://开始。", "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				goto end_IL_000e;
				IL_0091:
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					ConfiguredTaskAwaitable<WebsiteInfo>.ConfiguredTaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_01ca;
						}
						awaiter2 = WebSiteInfoHelper.RetriveSiteInfoAsync(_003Curl_003E5__2).ConfigureAwait(true).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_0147;
						}
						num = 0;
						_003C_003E1__state = 0;
						if (IfThWry2yaxwP5KpF9xe == null)
						{
							switch (1)
							{
							case 1:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 2:
								goto end_IL_0091;
							}
						}
					}
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<WebsiteInfo>.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0147;
					IL_01ca:
					string icon = awaiter.GetResult();
					goto IL_01d2;
					IL_0147:
					WebsiteInfo result = awaiter2.GetResult();
					_003Ctitle_003E5__4 = result.Title;
					icon = "";
					if (result.IconImage != null)
					{
						awaiter = urlActionParamEditor.IconManager.UploadFaviconAsync(new Uri(_003Curl_003E5__2).Host, result.IconImage).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01ca;
					}
					goto IL_01d2;
					IL_01d2:
					((ActionEditorWindow)Window.GetWindow(urlActionParamEditor)).UpdateTitleAndIcon(_003Ctitle_003E5__4, icon);
					_003Ctitle_003E5__4 = null;
					end_IL_0091:;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("获取站点信息失败。" + ex.Message);
				}
				finally
				{
					if (num < 0)
					{
						_003CwaitDlg_003E5__3.Close();
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Curl_003E5__2 = null;
				_003CwaitDlg_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Curl_003E5__2 = null;
			_003CwaitDlg_003E5__3 = null;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool P20fniy2pu1am4QelhLq()
		{
			return IfThWry2yaxwP5KpF9xe == null;
		}
	}

	[CompilerGenerated]
	private IconManager thlL4fTR9ed;

	private ActionItem GW2L4z4bebu;

	[CompilerGenerated]
	private string msJL5wslZtm;

	[CompilerGenerated]
	private IList<SelectionItem> OEKL5tYJC8C;

	internal TextBox TxtUrl;

	internal DropDownButton BtnMenu;

	internal ContextMenu MainContextMenu1;

	internal MenuItem MenuAddClipboardText;

	internal MenuItem MenuAddSubprogramOutput;

	internal Button BtnGetIcon;

	internal ComboBox CbBrowser;

	internal TextBlock LblCustomBrowser;

	internal StackPanel PnlCustomBrowser;

	internal TextBoxWithToolsControl txtCustomBrowserExePath;

	private bool CX3L5gETdTI;

	private static UrlActionParamEditor wqJN5fFlFmHybbRcaF7H;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return thlL4fTR9ed;
		}
		[CompilerGenerated]
		private set
		{
			thlL4fTR9ed = value;
		}
	}

	private string IconImage
	{
		[CompilerGenerated]
		get
		{
			return msJL5wslZtm;
		}
		[CompilerGenerated]
		set
		{
			msJL5wslZtm = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IList<SelectionItem> h1oL4lkleex()
	{
		return OEKL5tYJC8C;
	}

	[SpecialName]
	[CompilerGenerated]
	private void XGAL4i0FdIa(IList<SelectionItem> value)
	{
		OEKL5tYJC8C = value;
	}

	public UrlActionParamEditor()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
		base.Loaded += T0pL45nIV2D;
		XGAL4i0FdIa(ActionHelper.GetWebBrowsers());
		CbBrowser.ItemsSource = h1oL4lkleex();
		txtCustomBrowserExePath.TxtEditor.WordWrap = true;
		txtCustomBrowserExePath.SetupTools(new List<TextToolType>
		{
			TextToolType.SelectProcessPath,
			TextToolType.SelectSingleFile
		});
	}

	private void T0pL45nIV2D(object sender, RoutedEventArgs e)
	{
		if (!(Window.GetWindow(this) as ActionEditorWindow).IsEditingSubAction)
		{
			MenuAddSubprogramOutput.Visibility = Visibility.Collapsed;
		}
	}

	public override void SetData(ActionItem actionItem)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.LJeS36S4OQn = actionItem;
		GW2L4z4bebu = _003C_003Ec__DisplayClass15_.LJeS36S4OQn;
		if (_003C_003Ec__DisplayClass15_.LJeS36S4OQn != null)
		{
			TxtUrl.Text = _003C_003Ec__DisplayClass15_.LJeS36S4OQn.Data;
			CbBrowser.SelectedItem = h1oL4lkleex().FirstOrDefault(_003C_003Ec__DisplayClass15_.APFS3bvICq0);
			if (CbBrowser.SelectedIndex == -1)
			{
				CbBrowser.SelectedIndex = 0;
			}
			txtCustomBrowserExePath.Text = _003C_003Ec__DisplayClass15_.LJeS36S4OQn.Data3;
		}
		else
		{
			CbBrowser.SelectedIndex = 0;
			int num = 0;
			if (wqJN5fFlFmHybbRcaF7H != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = TxtUrl.Text;
		actionItem.Data2 = (CbBrowser.SelectedItem as SelectionItem)?.Value;
		actionItem.Data3 = txtCustomBrowserExePath.Text;
		if (!string.IsNullOrEmpty(IconImage))
		{
			actionItem.Icon = IconImage;
		}
	}

	public override (bool isSuccess, string message) Validate()
	{
		if (string.IsNullOrEmpty(TxtUrl.Text))
		{
			return (isSuccess: false, message: "请输入要打开的网址。");
		}
		return (isSuccess: true, message: string.Empty);
	}

	private static string NulL4D1ySiR(Uri uri_0)
	{
		string[] array = uri_0.Host.Split(new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries);
		if (array[0] == "www")
		{
			if (array.Length > 1)
			{
				return array[1];
			}
			return array[0];
		}
		return array[0];
	}

	[AsyncStateMachine(typeof(_003CBtnGetIcon_OnClick_003Ed__19))]
	private void zP0L4dZAsbw(object sender, RoutedEventArgs e)
	{
		_003CBtnGetIcon_OnClick_003Ed__19 stateMachine = default(_003CBtnGetIcon_OnClick_003Ed__19);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void lXmL4oFR06V(object sender, RoutedEventArgs e)
	{
		hR0L4TZs5ju("{cliptext}");
	}

	private void hR0L4TZs5ju(string string_1)
	{
		if (TxtUrl.SelectedText.Length > 0)
		{
			TxtUrl.Text = TxtUrl.Text.Replace(TxtUrl.Text.Substring(TxtUrl.SelectionStart, TxtUrl.SelectionLength), string_1);
		}
		else
		{
			TxtUrl.Text = TxtUrl.Text.Insert(TxtUrl.CaretIndex, string_1);
		}
	}

	private void FjML4MkuZBB(object sender, RoutedEventArgs e)
	{
		hR0L4TZs5ju("{context}");
	}

	private void sM5L4AASnxM(object sender, SelectionChangedEventArgs e)
	{
		SelectionItem selectionItem = (SelectionItem)CbBrowser.SelectedItem;
		TextBlock lblCustomBrowser = LblCustomBrowser;
		Visibility visibility = (PnlCustomBrowser.Visibility = (selectionItem?.Value == "custom").ToVisibility());
		lblCustomBrowser.Visibility = visibility;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!CX3L5gETdTI)
		{
			CX3L5gETdTI = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/urlactionparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			CX3L5gETdTI = true;
			break;
		case 1:
			TxtUrl = (TextBox)target;
			break;
		case 2:
			BtnMenu = (DropDownButton)target;
			break;
		case 3:
			MainContextMenu1 = (ContextMenu)target;
			break;
		case 4:
			MenuAddClipboardText = (MenuItem)target;
			MenuAddClipboardText.Click += lXmL4oFR06V;
			break;
		case 5:
			MenuAddSubprogramOutput = (MenuItem)target;
			MenuAddSubprogramOutput.Click += FjML4MkuZBB;
			break;
		case 6:
		{
			BtnGetIcon = (Button)target;
			int num = 0;
			if (!cMdBuuFlcvEqHOUecSfN())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnGetIcon.Click += zP0L4dZAsbw;
				break;
			}
			break;
		}
		case 7:
			CbBrowser = (ComboBox)target;
			CbBrowser.SelectionChanged += sM5L4AASnxM;
			break;
		case 8:
			LblCustomBrowser = (TextBlock)target;
			break;
		case 9:
			PnlCustomBrowser = (StackPanel)target;
			break;
		case 10:
			txtCustomBrowserExePath = (TextBoxWithToolsControl)target;
			break;
		}
	}

	internal static bool cMdBuuFlcvEqHOUecSfN()
	{
		return wqJN5fFlFmHybbRcaF7H == null;
	}
}
