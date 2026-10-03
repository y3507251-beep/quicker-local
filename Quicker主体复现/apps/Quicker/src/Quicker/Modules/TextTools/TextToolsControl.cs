using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using c4LBdq5YohQFUgxFYw4;
using Kr1EWdWMuuNXjRSO1BA;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Entities;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.Controls;
using Quicker.View.UI;
using Quicker.View.X.Nodes;

namespace Quicker.Modules.TextTools;

public class TextToolsControl : Control
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec F4OvW5PxEco;

		public static Func<TextToolType, bool> Ke8vWDVwm9Y;

		public static Func<TextToolItem, bool> JicvWdLlRNM;

		internal static _003C_003Ec iF1iqvc5Z3Ueb5a8DMaA;

		static _003C_003Ec()
		{
			F4OvW5PxEco = new _003C_003Ec();
		}

		internal bool nBkvWnOlTOf(TextToolType x)
		{
			return x != TextToolType.EditInCodeWindow;
		}

		internal bool z43vW4XXuNR(TextToolItem x)
		{
			return x.ToolType == TextToolType.EditInCodeWindow;
		}

		internal static bool NePThgc55pWCfyFGyTT4()
		{
			return iF1iqvc5Z3Ueb5a8DMaA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public qsQtMm5MtHtoYi1dcdV m1cvWTXfdSA;

		internal static _003C_003Ec__DisplayClass56_0 bCsLlAc581qKvMmqYtCT;

		internal void anFvWoOSwxU()
		{
			m1cvWTXfdSA = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Color);
		}

		internal static bool eVnOuMc5R0XfsKOTwkE2()
		{
			return bCsLlAc581qKvMmqYtCT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass65_0
	{
		public TextToolsControl b8ivWAivh9G;

		public string i7LvWOQaIeB;

		internal static _003C_003Ec__DisplayClass65_0 bByALuc5PTvG6f7VRcUX;

		internal void pCEvWMGHbKB(object sender, FileSystemEventArgs e)
		{
			try
			{
				AppHelper.RunOnUiThread(false, new _003C_003Ec__DisplayClass65_1
				{
					N7xvWl0r92s = this,
					gyVvWUC1lAw = b8ivWAivh9G.OhOtLoeWRDR(i7LvWOQaIeB)
				}.npovWFuigBw);
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("无法读取临时文件：" + exception.GetMessageWithInner());
			}
		}

		static _003C_003Ec__DisplayClass65_0()
		{
		}

		internal static bool liiQOXc5MJKqedG4yGNf()
		{
			return bByALuc5PTvG6f7VRcUX == null;
		}

		internal static void cZy8Chc5xC587sA87a11()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass65_1
	{
		public string gyVvWUC1lAw;

		public _003C_003Ec__DisplayClass65_0 N7xvWl0r92s;

		private static _003C_003Ec__DisplayClass65_1 w2D2Kbc5I8R3l53ID9Mc;

		internal void npovWFuigBw()
		{
			N7xvWl0r92s.b8ivWAivh9G.ijHtLHGnQhX(gyVvWUC1lAw, true);
		}

		internal static bool PaHIKKc56OtQmm1QZ77J()
		{
			return w2D2Kbc5I8R3l53ID9Mc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_0
	{
		public string kgAvW3k9FsB;

		public CommonOperationItem eHDvWfxoBBm;

		internal static _003C_003Ec__DisplayClass67_0 oPHyvNc5SobSbhaENFjN;

		internal BaseTextTool ktfvWiZKBjH(TextToolContext context)
		{
			return new aK6wMoWYedrJ3a4Md2C(context, kgAvW3k9FsB, eHDvWfxoBBm.ExtraData);
		}

		internal static bool D0nk5gc5wKgnarJknaQq()
		{
			return oPHyvNc5SobSbhaENFjN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuInsertVariable_Click_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TextToolsControl _003C_003E4__this;

		private string _003Ctext_003E5__2;

		private TaskAwaiter<(bool isSuccess, string button)> _003C_003Eu__1;

		private static object a602mBc5mCWd6Pkd9FHi;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TextToolsControl textToolsControl = _003C_003E4__this;
			try
			{
				TaskAwaiter<(bool, string)> awaiter = default(TaskAwaiter<(bool, string)>);
				int num2;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string)>);
					num = -1;
					_003C_003E1__state = -1;
					num2 = 0;
					if (a602mBc5mCWd6Pkd9FHi != null)
					{
						goto IL_0164;
					}
					goto IL_019a;
				}
				if (sender is MenuItem { Tag: string tag })
				{
					if (textToolsControl.LCZtvw6AkUB == null)
					{
						AppHelper.ShowWarning("内部错误：_textControl为空。");
					}
					else
					{
						textToolsControl.ijHtLHGnQhX("{" + tag + "}");
						_003Ctext_003E5__2 = textToolsControl.LCZtvw6AkUB.GetAllText() ?? "";
						if (!_003Ctext_003E5__2.StartsWithAny(false, "$$", "$="))
						{
							num2 = 2;
							if (a602mBc5mCWd6Pkd9FHi != null)
							{
								goto IL_0164;
							}
							goto IL_019a;
						}
					}
				}
				goto end_IL_0010;
				IL_019a:
				string text2 = default(string);
				(bool, string) result = default((bool, string));
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (Keyboard.Modifiers != ModifierKeys.Shift)
						{
							awaiter = ConfirmDialog.jQyL0Wq9wU6(Window.GetWindow(textToolsControl), "选择参数的工作模式", "", "文本插值：\r\n    将变量值插入到文本字中，以 “$$” 作为开始标记。\r\n\r\n表达式：\r\n    计算表达式并得到结果，以 “$=” 作为开始标记。\r\n\r\n提示：按Ctrl点击变量名可直接开启表达式模式，按Shift可直接开启插值模式。\r\n在输入框按F1可快速切换模式。", "Question", "[text:$$:#1E90FF::b]文本插值|$$\r\n[text:$=:#198754::b]表达式|$=", text2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						textToolsControl.ijHtLHGnQhX("$$" + _003Ctext_003E5__2, true);
						goto end_IL_019a;
					case 2:
						text2 = ((!textToolsControl.DiPtvvkZT9Y) ? "$$" : "$=");
						textToolsControl.ijHtLHGnQhX(text2 + _003Ctext_003E5__2, true);
						goto end_IL_019a;
					case 1:
						if (result.Item1)
						{
							string text = result.Item2.Or(textToolsControl.DiPtvvkZT9Y ? "$=" : "$$");
							textToolsControl.ijHtLHGnQhX(text + _003Ctext_003E5__2, true);
						}
						goto end_IL_019a;
					}
					result = awaiter.GetResult();
					num2 = 1;
					if (kjhFr1c5sDvtUyWZdXnA())
					{
						continue;
					}
					goto IL_0164;
					continue;
					end_IL_019a:
					break;
				}
				goto end_IL_0010;
				IL_0164:
				int num3 = default(int);
				num2 = num3;
				goto IL_019a;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ctext_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Ctext_003E5__2 = null;
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

		internal static bool kjhFr1c5sDvtUyWZdXnA()
		{
			return a602mBc5mCWd6Pkd9FHi == null;
		}
	}

	[CompilerGenerated]
	private EventHandler<TextSelectedEventArgs> m_ValueSelected;

	public VarType? ParamDataType;

	public static readonly DependencyProperty ExtraMenuVisibilityProperty;

	private ITextControl LCZtvw6AkUB;

	private TextToolContext tCKtvtAwHi5;

	private TextToolsContextHint D5ytvghvaDf;

	private string EoetvLALF0S;

	private bool DiPtvvkZT9Y;

	private IList<ActionVariable> fN9tvSaqViV;

	[CompilerGenerated]
	private readonly ObservableCollection<TextToolItem> X6Qtv2okA4O = new ObservableCollection<TextToolItem>();

	private bool NjNtvuEplCq;

	private IDictionary<TextToolItem, BaseTextTool> mIvtvNVqF5P = new Dictionary<TextToolItem, BaseTextTool>();

	[CompilerGenerated]
	private Quicker.View.X.Nodes.CaptureMode JbbtvJVoc89;

	private System.Windows.Point i9Qtv0bWkLG;

	private FileSystemWatcher I6ktvCcI0FM;

	private string bP1tvPZu9RP;

	private ActionExecuteContext jeutvEXoFWs;

	private static TextToolsControl RiA4OcQWhbZauwSmip53;

	public Visibility ExtraMenuVisibility
	{
		get
		{
			return (Visibility)GetValue(ExtraMenuVisibilityProperty);
		}
		set
		{
			SetValue(ExtraMenuVisibilityProperty, value);
		}
	}

	public bool ShowExtMenu
	{
		get
		{
			return ExtraMenuVisibility == Visibility.Visible;
		}
		set
		{
			ExtraMenuVisibility = value.ToVisibility();
		}
	}

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

	static TextToolsControl()
	{
		ExtraMenuVisibilityProperty = DependencyProperty.Register("ExtraMenuVisibility", typeof(Visibility), typeof(TextToolsControl), new PropertyMetadata(Visibility.Collapsed));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(TextToolsControl), new FrameworkPropertyMetadata(typeof(TextToolsControl)));
	}

	public void SetupTools(bool enableEditInCodeWindow, ICollection<TextToolType> tools, ITextControl textControl, TextToolsContextHint contextHint, string defaultHighlightingType, ActionExecuteContext actionExecuteContext = null, VarType? paramDataType = null)
	{
		if (NjNtvuEplCq)
		{
			return;
		}
		LCZtvw6AkUB = textControl;
		D5ytvghvaDf = contextHint;
		EoetvLALF0S = defaultHighlightingType;
		jeutvEXoFWs = actionExecuteContext;
		ParamDataType = paramDataType;
		rjctLFAgXTK().Clear();
		if (tools.HasData())
		{
			foreach (TextToolType item in tools.Distinct().Where(_003C_003Ec.Ke8vWDVwm9Y ?? (_003C_003Ec.Ke8vWDVwm9Y = _003C_003Ec.F4OvW5PxEco.nBkvWnOlTOf)))
			{
				if (item == TextToolType.ExtraSelectMenu)
				{
					ExtraMenuVisibility = Visibility.Visible;
					continue;
				}
				TextToolItem textToolItem = TextToolsProvider.L8Etvx2Bmx1(item);
				if (textToolItem != null)
				{
					rjctLFAgXTK().Add(textToolItem);
				}
			}
		}
		if (enableEditInCodeWindow || (tools != null && tools.Contains(TextToolType.EditInCodeWindow)))
		{
			rjctLFAgXTK().Add(TextToolsProvider.L8Etvx2Bmx1(TextToolType.EditInCodeWindow));
		}
	}

	public void AddExtraTools(IEnumerable<TextToolItem> tools)
	{
		if (NjNtvuEplCq)
		{
			return;
		}
		int num = 0;
		foreach (TextToolItem tool in tools)
		{
			rjctLFAgXTK().Insert(num, tool);
			num++;
		}
	}

	public void SetVariableList(IList<ActionVariable> variables, bool defaultUseExpression)
	{
		DiPtvvkZT9Y = defaultUseExpression;
		fN9tvSaqViV = variables;
	}

	[SpecialName]
	[CompilerGenerated]
	internal ObservableCollection<TextToolItem> rjctLFAgXTK()
	{
		return X6Qtv2okA4O;
	}

	public TextToolsControl()
	{
		base.Unloaded += TsVtLh3cTCL;
		base.Focusable = false;
	}

	private void TsVtLh3cTCL(object sender, RoutedEventArgs e)
	{
		foreach (KeyValuePair<TextToolItem, BaseTextTool> item in mIvtvNVqF5P)
		{
			item.Value?.OnUnload();
		}
		if (I6ktvCcI0FM != null)
		{
			I6ktvCcI0FM.Dispose();
			I6ktvCcI0FM = null;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (GetTemplateChild("ToolButtonList") is ItemsControl itemsControl)
		{
			itemsControl.ItemsSource = rjctLFAgXTK();
			itemsControl.Loaded -= QgstLeCUofC;
			itemsControl.Loaded += QgstLeCUofC;
		}
		if (!(GetTemplateChild("ExtraMenu") is DropDownButton dropDownButton))
		{
			return;
		}
		if (RiA4OcQWhbZauwSmip53 == null)
		{
			switch (0)
			{
			}
		}
		dropDownButton.LazyBuildMenuFunc = fOktLsjV73A;
	}

	private void QgstLeCUofC(object sender, RoutedEventArgs e)
	{
		ItemsControl itemsControl_ = sender as ItemsControl;
		zoAtLY8NL50(itemsControl_);
		NjNtvuEplCq = true;
	}

	private void zoAtLY8NL50(ItemsControl itemsControl_0)
	{
		foreach (object item in (IEnumerable)itemsControl_0.Items)
		{
			ContentPresenter contentPresenter = (ContentPresenter)itemsControl_0.ItemContainerGenerator.ContainerFromItem(item);
			if (contentPresenter == null)
			{
				continue;
			}
			Button button = UIHelper.FindChild<Button>(contentPresenter);
			if (button == null)
			{
				continue;
			}
			button.PreviewMouseDown -= QqvtLIlydlv;
			button.PreviewMouseUp -= BIetLWqnEbD;
			button.PreviewMouseMove -= CVJtLkvlqZO;
			button.PreviewMouseDown += QqvtLIlydlv;
			button.PreviewMouseUp += BIetLWqnEbD;
			button.PreviewMouseMove += CVJtLkvlqZO;
			if (YbDwQvQWHBeA2Zff7u0E())
			{
				switch (0)
				{
				}
			}
		}
	}

	private void QqvtLIlydlv(object sender, MouseButtonEventArgs e)
	{
		TextToolItem textToolItem_ = (sender as FrameworkElement).Tag as TextToolItem;
		fdNtLG0lYKq(textToolItem_).OnMouseDown(sender);
	}

	private void BIetLWqnEbD(object sender, MouseButtonEventArgs e)
	{
		TextToolItem textToolItem_ = (sender as FrameworkElement).Tag as TextToolItem;
		fdNtLG0lYKq(textToolItem_).OnMouseUp(sender);
	}

	private void CVJtLkvlqZO(object sender, MouseEventArgs e)
	{
		TextToolItem textToolItem_ = (sender as FrameworkElement).Tag as TextToolItem;
		fdNtLG0lYKq(textToolItem_).OnMouseMove(sender, e);
	}

	internal BaseTextTool fdNtLG0lYKq(TextToolItem textToolItem_0)
	{
		if (!mIvtvNVqF5P.ContainsKey(textToolItem_0))
		{
			mIvtvNVqF5P[textToolItem_0] = textToolItem_0.CreateToolFunc(GetTextToolContext());
		}
		return mIvtvNVqF5P[textToolItem_0];
	}

	public TextToolContext GetTextToolContext()
	{
		if (tCKtvtAwHi5 == null)
		{
			tCKtvtAwHi5 = new TextToolContext
			{
				ParentWindow = Window.GetWindow(this),
				ProcessSelectedTextFunc = ShotLOPgYUm,
				TextControl = LCZtvw6AkUB,
				ActionVariables = LCZtvw6AkUB?.GetActionVariables(),
				DefaultHighlightingType = EoetvLALF0S,
				ActionExecuteContext = jeutvEXoFWs
			};
			D5ytvghvaDf?.ApplyToContext(tCKtvtAwHi5);
		}
		return tCKtvtAwHi5;
	}

	private void fOktLsjV73A(ContextMenu contextMenu_0)
	{
		int num;
		if (contextMenu_0 != null)
		{
			if (contextMenu_0.Items.Count > 0)
			{
				return;
			}
			if (!rjctLFAgXTK().Any(_003C_003Ec.JicvWdLlRNM ?? (_003C_003Ec.JicvWdLlRNM = _003C_003Ec.F4OvW5PxEco.z43vW4XXuNR)))
			{
				AppHelper.AddMenuItem(contextMenu_0.Items, "在编辑器中打开", "使用编辑器修改参数内容", "fa:Light_ExternalLinkSquare", PoVtL1v4XqN);
				num = 0;
				if (!YbDwQvQWHBeA2Zff7u0E())
				{
					goto IL_0318;
				}
				goto IL_031c;
			}
			goto IL_04b8;
		}
		AppHelper.ShowWarning("菜单对象为空。");
		return;
		IL_0318:
		int num2 = default(int);
		num = num2;
		goto IL_031c;
		IL_031c:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_04b8;
		IL_04b8:
		AppHelper.AddMenuItem(contextMenu_0.Items, "在外部编辑器中编辑", "使用第三方编辑器编辑内容", "fa:Light_ExternalLinkSquare", EditInExternalEditor);
		if (fN9tvSaqViV != null)
		{
			MenuItem menuItem = AppHelper.AddMenuItem(contextMenu_0.Items, "插入变量", "", "/Assets/var.png", null);
			foreach (ActionVariable item in fN9tvSaqViV.Union(new ActionVariable[2]
			{
				new ActionVariable
				{
					Key = "[cliptext]",
					Type = VarType.Text,
					Desc = "*剪贴板文本*"
				},
				new ActionVariable
				{
					Key = "quicker_in_param",
					Type = VarType.Text,
					Desc = "*动作参数*"
				}
			}))
			{
				MenuItem menuItem2 = new MenuItem
				{
					Header = (string.IsNullOrEmpty(item.Desc) ? item.Key.Replace("_", "__") : (item.Key.Replace("_", "__") + " (" + item.Desc + ")")),
					Tag = item.Key,
					Icon = new IconControl
					{
						Width = 16.0,
						Height = 16.0,
						Icon = AppHelper.GetVarTypeIconStr(item.Type)
					}
				};
				menuItem2.Click += FOKtLbRdjNK;
				menuItem.Items.Add(menuItem2);
			}
		}
		AppHelper.AddMenuItem(contextMenu_0.Items, "已安装的软件...", "选择开始菜单中可以找到的程序", "fa:Brands_Windows", LvatL6hC7Zv);
		AppHelper.AddMenuItem(contextMenu_0.Items, "文件...", "选择已存在的文件路径", "fa:Light_File", XGVtLXiL2l8);
		AppHelper.AddMenuItem(contextMenu_0.Items, "文件夹...", "选择文件夹路径", "fa:Light_FolderOpen", nAXtLmqrHib);
		AppHelper.AddMenuItem(contextMenu_0.Items, "另存路径...", "选择文件要保存到的位置", "fa:Light_Save", ysMtLKFhMXP);
		MenuItem menuItem3 = AppHelper.AddMenuItem(contextMenu_0.Items, "窗口信息(拖动选择)...", "选择窗口，获取窗口信息", "fa:Light_Crosshairs", null);
		menuItem3.PreviewMouseDown += rpetLpFGH7A;
		menuItem3.PreviewMouseUp += TlStLBbgnLA;
		MenuItem menuItem4 = AppHelper.AddMenuItem(contextMenu_0.Items, "屏幕颜色(拖动选择)...", "选择指定位置的颜色", "fa:Light_EyeDropper", null);
		menuItem4.PreviewMouseDown += fDUtLQuMghG;
		menuItem4.PreviewMouseUp += EfqtLjGuSrG;
		MenuItem menuItem5 = AppHelper.AddMenuItem(contextMenu_0.Items, "屏幕坐标(拖动选择)...", "选择指定位置的坐标", "fa:Light_Location", null);
		menuItem5.PreviewMouseDown += J9rtLnRhQ5x;
		menuItem5.PreviewMouseUp += npYtL4CX71C;
		AppHelper.AddMenuSeparator(contextMenu_0.Items);
		AppHelper.AddMenuItem(contextMenu_0.Items, "选择动作ID...", "选择动作并填入动作的ID", "", tE6tL5RaxMV);
		AppHelper.AddMenuItem(contextMenu_0.Items, "选择图标...", "选择内置的矢量图标名", "", NjStLDFtN4s);
		num = 1;
		if (!YbDwQvQWHBeA2Zff7u0E())
		{
			goto IL_0318;
		}
		goto IL_031c;
	}

	private void ijHtLHGnQhX(string string_2, bool bool_1 = false)
	{
		this.m_ValueSelected?.Invoke(this, new TextSelectedEventArgs(string_2, bool_1));
	}

	[SpecialName]
	private string KJxtLlpjG9o()
	{
		ITextControl lCZtvw6AkUB = LCZtvw6AkUB;
		object obj;
		if (lCZtvw6AkUB == null)
		{
			obj = null;
		}
		else
		{
			obj = lCZtvw6AkUB.GetAllText();
			if (obj != null)
			{
				goto IL_001b;
			}
		}
		obj = string.Empty;
		goto IL_001b;
		IL_001b:
		return (string)obj;
	}

	private void PoVtL1v4XqN(object sender, RoutedEventArgs e)
	{
		CodeEditorWindow codeEditorWindow = new CodeEditorWindow(fN9tvSaqViV ?? new List<ActionVariable>(), string.IsNullOrEmpty(EoetvLALF0S), EoetvLALF0S)
		{
			Owner = Window.GetWindow(LCZtvw6AkUB as UIElement),
			Text = LCZtvw6AkUB.GetAllText()
		};
		codeEditorWindow.ShowDialog();
		ijHtLHGnQhX(codeEditorWindow.Text, true);
	}

	[AsyncStateMachine(typeof(_003CMenuInsertVariable_Click_003Ed__41))]
	private void FOKtLbRdjNK(object sender, RoutedEventArgs e)
	{
		_003CMenuInsertVariable_Click_003Ed__41 stateMachine = default(_003CMenuInsertVariable_Click_003Ed__41);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void LvatL6hC7Zv(object sender, RoutedEventArgs e)
	{
		AppSelectorWindow appSelectorWindow = new AppSelectorWindow(true)
		{
			Owner = Window.GetWindow(this)
		};
		if (appSelectorWindow.ShowDialog() == true)
		{
			WinAppItem selectedFile = appSelectorWindow.SelectedFile;
			ijHtLHGnQhX(selectedFile.FullPath);
		}
	}

	private void XGVtLXiL2l8(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			DereferenceLinks = false,
			Filter = "可执行程序|*.exe|任意文件|*.*",
			FilterIndex = 2
		};
		if (!string.IsNullOrEmpty(KJxtLlpjG9o()))
		{
			try
			{
				if (File.Exists(KJxtLlpjG9o().Trim()) && Directory.Exists(Path.GetDirectoryName(KJxtLlpjG9o().Trim())))
				{
					openFileDialog.InitialDirectory = Path.GetDirectoryName(KJxtLlpjG9o().Trim());
				}
			}
			catch
			{
			}
		}
		bool? flag = openFileDialog.ShowDialog();
		int num = 0;
		if (RiA4OcQWhbZauwSmip53 != null)
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
			ijHtLHGnQhX(text);
		}
	}

	private void nAXtLmqrHib(object sender, RoutedEventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
		{
			IsFolderPicker = true
		};
		try
		{
			if (!string.IsNullOrEmpty(KJxtLlpjG9o()) && Directory.Exists(KJxtLlpjG9o()))
			{
				commonOpenFileDialog.InitialDirectory = KJxtLlpjG9o();
			}
			if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				string fileName = commonOpenFileDialog.FileName;
				ijHtLHGnQhX(fileName);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("选择文件夹出错：" + ex.Message);
		}
	}

	private void ysMtLKFhMXP(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSaveFileDialog("任意文件类型|*.*", "", "", "", "选择文件保存路径");
		if (tuple.Item1)
		{
			ijHtLHGnQhX(tuple.Item2);
		}
	}

	private void VBBtLxMDq0Z()
	{
		Mouse.OverrideCursor = Cursors.Cross;
	}

	private void vZMtLrxQiE2()
	{
		Mouse.OverrideCursor = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private Quicker.View.X.Nodes.CaptureMode iqQtL3FXpgS()
	{
		return JbbtvJVoc89;
	}

	[SpecialName]
	[CompilerGenerated]
	private void C4MtLfXuGwJ(Quicker.View.X.Nodes.CaptureMode value)
	{
		JbbtvJVoc89 = value;
	}

	private void rpetLpFGH7A(object sender, MouseButtonEventArgs e)
	{
		VBBtLxMDq0Z();
		C4MtLfXuGwJ(Quicker.View.X.Nodes.CaptureMode.ProcessName);
		if (sender is MenuItem menuItem)
		{
			menuItem.CaptureMouse();
		}
		else
		{
			AppHelper.ShowError("菜单项为空。");
		}
	}

	private void TlStLBbgnLA(object sender, MouseButtonEventArgs e)
	{
		vZMtLrxQiE2();
		if (sender is MenuItem menuItem)
		{
			menuItem.ReleaseMouseCapture();
		}
		else
		{
			AppHelper.ShowError("菜单项为空。");
		}
		C4MtLfXuGwJ(Quicker.View.X.Nodes.CaptureMode.None);
		try
		{
			string text = AppHelper.SelectWindowInfo(NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition()), Window.GetWindow(this));
			if (!string.IsNullOrEmpty(text))
			{
				ijHtLHGnQhX(text);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("获取窗口信息失败。" + ex.Message);
		}
	}

	private void fDUtLQuMghG(object sender, MouseButtonEventArgs e)
	{
		VBBtLxMDq0Z();
		(sender as MenuItem)?.CaptureMouse();
		i9Qtv0bWkLG = e.GetPosition(this);
	}

	private void EfqtLjGuSrG(object sender, MouseButtonEventArgs e)
	{
		vZMtLrxQiE2();
		MenuItem obj = sender as MenuItem;
		if (obj != null)
		{
			obj.ReleaseMouseCapture();
			if (YbDwQvQWHBeA2Zff7u0E())
			{
				switch (0)
				{
				}
			}
		}
		if (e.GetPosition(this) == i9Qtv0bWkLG)
		{
			_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
			_003C_003Ec__DisplayClass56_.m1cvWTXfdSA = null;
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_.anFvWoOSwxU);
			if (_003C_003Ec__DisplayClass56_.m1cvWTXfdSA.IsSuccess)
			{
				ijHtLHGnQhX(_003C_003Ec__DisplayClass56_.m1cvWTXfdSA.wZFmIfirit().ToRgbHexString());
			}
		}
		else
		{
			Color colorAt = ColorHelper.GetColorAt(NativeMethods.GetMousePosition());
			ijHtLHGnQhX(colorAt.ToRgbHexString());
		}
	}

	private void J9rtLnRhQ5x(object sender, MouseButtonEventArgs e)
	{
		VBBtLxMDq0Z();
		(sender as MenuItem)?.CaptureMouse();
	}

	private void npYtL4CX71C(object sender, MouseButtonEventArgs e)
	{
		vZMtLrxQiE2();
		(sender as MenuItem)?.ReleaseMouseCapture();
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		ijHtLHGnQhX($"{mousePosition.X},{mousePosition.Y}");
	}

	private void tE6tL5RaxMV(object sender, RoutedEventArgs e)
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
		ijHtLHGnQhX((string)obj);
	}

	private void NjStLDFtN4s(object sender, RoutedEventArgs e)
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow
		{
			Owner = Window.GetWindow(this)
		};
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			ijHtLHGnQhX(faIconSelectorWindow.SelectedIcon.ToString());
		}
	}

	private static string JEstLd64kjR(string string_2)
	{
		Match match = new Regex("\\.\\w+").Match(string_2);
		if (match.Success)
		{
			return match.Value;
		}
		return ".txt";
	}

	public void EditInExternalEditor(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass65_0 _003C_003Ec__DisplayClass65_ = new _003C_003Ec__DisplayClass65_0();
		_003C_003Ec__DisplayClass65_.b8ivWAivh9G = this;
		if (I6ktvCcI0FM != null)
		{
			try
			{
				I6ktvCcI0FM.Dispose();
				I6ktvCcI0FM = null;
			}
			catch
			{
			}
		}
		string text = KJxtLlpjG9o();
		string arg = ".txt";
		string text2 = text;
		if (text2.StartsWith("$$") || text2.StartsWith("$="))
		{
			text2 = text2.Substring(2);
		}
		if (text2.StartsWithAny(false, "//", "<!--", "#"))
		{
			arg = JEstLd64kjR(text2);
		}
		_003C_003Ec__DisplayClass65_.i7LvWOQaIeB = Path.Combine(Path.GetTempPath(), $"quicker_temp_edit_{DateTime.Now:yyyyMMddHHmmssfff}{arg}");
		try
		{
			File.WriteAllText(_003C_003Ec__DisplayClass65_.i7LvWOQaIeB, text, Encoding.UTF8);
			if (I6ktvCcI0FM != null)
			{
				I6ktvCcI0FM.Dispose();
				I6ktvCcI0FM = null;
			}
			I6ktvCcI0FM = new FileSystemWatcher();
			if (!YbDwQvQWHBeA2Zff7u0E())
			{
				switch (0)
				{
				}
			}
			I6ktvCcI0FM.Path = Path.GetDirectoryName(_003C_003Ec__DisplayClass65_.i7LvWOQaIeB);
			I6ktvCcI0FM.Filter = Path.GetFileName(_003C_003Ec__DisplayClass65_.i7LvWOQaIeB);
			I6ktvCcI0FM.NotifyFilter = NotifyFilters.LastWrite;
			I6ktvCcI0FM.Changed += _003C_003Ec__DisplayClass65_.pCEvWMGHbKB;
			try
			{
				Process.Start("rundll32.exe", $"shell32.dll,OpenAs_RunDLL {_003C_003Ec__DisplayClass65_.i7LvWOQaIeB}");
			}
			catch (Exception exception)
			{
				AppHelper.ShowWarning("无法打开临时文件：" + exception.GetMessageWithInner());
				AppHelper.SelectFileInExplorer(_003C_003Ec__DisplayClass65_.i7LvWOQaIeB, true);
			}
			I6ktvCcI0FM.EnableRaisingEvents = true;
		}
		catch (Exception exception2)
		{
			AppHelper.ShowWarning("无法写入临时文件：" + exception2.GetMessageWithInner());
		}
	}

	private string OhOtLoeWRDR(string string_2)
	{
		using FileStream stream = new FileStream(string_2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}

	internal static IList<TextToolItem> hgdtLTVZCx6(string[] string_2)
	{
		IList<TextToolItem> list = new List<TextToolItem>();
		foreach (string text in string_2)
		{
			if (!text.StartsWith("texttool:"))
			{
				continue;
			}
			_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
			string text2 = text.Substring("texttool:".Length);
			_003C_003Ec__DisplayClass67_.eHDvWfxoBBm = CommonOperationItem.ParseLine(text2, true);
			if (_003C_003Ec__DisplayClass67_.eHDvWfxoBBm != null)
			{
				_003C_003Ec__DisplayClass67_.kgAvW3k9FsB = _003C_003Ec__DisplayClass67_.eHDvWfxoBBm.SpName.Or(_003C_003Ec__DisplayClass67_.eHDvWfxoBBm.Data);
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass67_.kgAvW3k9FsB))
				{
					AppHelper.ShowWarning("自定义文本选择器，子程序名称为空。原始定义：" + text);
					continue;
				}
				TextToolItem textToolItem = new TextToolItem();
				textToolItem.ToolType = TextToolType.Custom;
				textToolItem.CanBeUsedInAction = false;
				textToolItem.Icon = _003C_003Ec__DisplayClass67_.eHDvWfxoBBm.Icon;
				textToolItem.Tooltip = string.Join("\r\n", _003C_003Ec__DisplayClass67_.eHDvWfxoBBm.Title, _003C_003Ec__DisplayClass67_.eHDvWfxoBBm.Description).Trim();
				textToolItem.Text = null;
				textToolItem.CreateToolFunc = _003C_003Ec__DisplayClass67_.ktfvWiZKBjH;
				TextToolItem item = textToolItem;
				list.Add(item);
			}
		}
		return list;
	}

	internal static TextToolsReplaceMode? Bu8tLMnxv81(string[] string_2)
	{
		foreach (string text in string_2)
		{
			if (!text.StartsWith("ttmode:"))
			{
				continue;
			}
			string text2 = text.Substring("ttmode:".Length);
			string text3 = text2.ToLower();
			if (text3 != null)
			{
				switch (text3.Length)
				{
				case 1:
				{
					char c = text3[0];
					if ((uint)c <= 59u)
					{
						if (c == ',')
						{
							goto IL_01bf;
						}
						if (c != ';')
						{
							break;
						}
					}
					else
					{
						if (c == '，')
						{
							goto IL_01bf;
						}
						if (c != '；')
						{
							break;
						}
					}
					goto IL_01cd;
				}
				case 2:
					if (!(text3 == "\\n"))
					{
						break;
					}
					goto IL_01c6;
				case 3:
					if (!(text3 == "all"))
					{
						break;
					}
					return TextToolsReplaceMode.ReplaceAll;
				case 5:
					if (!(text3 == "comma"))
					{
						break;
					}
					goto IL_01bf;
				case 6:
					if (!(text3 == "append"))
					{
						break;
					}
					return TextToolsReplaceMode.Append;
				case 8:
					if (!(text3 == "selected"))
					{
						break;
					}
					return TextToolsReplaceMode.ReplaceSelected;
				case 9:
					if (!(text3 == "semicolon"))
					{
						break;
					}
					goto IL_01cd;
				case 15:
					if (!(text3 == "appendwithcomma"))
					{
						break;
					}
					goto IL_01bf;
				case 17:
					if (!(text3 == "appendwithnewline"))
					{
						break;
					}
					goto IL_01c6;
				case 19:
					{
						if (!(text3 == "appendwithsemicolon"))
						{
							break;
						}
						goto IL_01cd;
					}
					IL_01bf:
					return TextToolsReplaceMode.AppendWithComma;
					IL_01cd:
					return TextToolsReplaceMode.AppendWithSemicolon;
					IL_01c6:
					return TextToolsReplaceMode.AppendWithNewline;
				}
			}
			AppHelper.ShowWarning("不支持的文本替换模式：" + text2);
		}
		return null;
	}

	public static void UpdateTextValueWithReplaceMode(ITextControl textControl, TextToolsReplaceMode replaceMode, string eValue)
	{
		switch (replaceMode)
		{
		default:
			AppHelper.ShowWarning($"不支持的文本替换模式：{replaceMode}, 可能您使用的Quicker版本过旧。");
			break;
		case TextToolsReplaceMode.ReplaceSelected:
			textControl.SetSelectedText(eValue);
			break;
		case TextToolsReplaceMode.ReplaceAll:
			textControl.SetAllText(eValue);
			break;
		case TextToolsReplaceMode.Append:
		{
			Ds1tLA8aJPd(textControl, eValue, "");
			int num = 0;
			if (RiA4OcQWhbZauwSmip53 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case TextToolsReplaceMode.AppendWithSemicolon:
			Ds1tLA8aJPd(textControl, eValue, ";");
			break;
		case TextToolsReplaceMode.AppendWithNewline:
			Ds1tLA8aJPd(textControl, eValue, "\r\n");
			break;
		case TextToolsReplaceMode.AppendWithComma:
			Ds1tLA8aJPd(textControl, eValue, ",");
			break;
		}
	}

	private static void Ds1tLA8aJPd(ITextControl itextControl_1, string string_2, string string_3)
	{
		string allText = itextControl_1.GetAllText();
		if (string.IsNullOrEmpty(allText))
		{
			itextControl_1.SetAllText(string_2);
			itextControl_1.MoveCaretToEnd();
			return;
		}
		List<string> list = allText.Split(new string[1] { string_3 }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (!list.Contains(string_2))
		{
			int num = 0;
			if (RiA4OcQWhbZauwSmip53 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			list.Add(string_2);
		}
		string allText2 = string.Join(string_3, list);
		itextControl_1.SetAllText(allText2);
		itextControl_1.MoveCaretToEnd();
	}

	[CompilerGenerated]
	private void ShotLOPgYUm(string string_2, bool bool_1)
	{
		this.m_ValueSelected?.Invoke(this, new TextSelectedEventArgs(string_2, bool_1));
	}

	internal static bool YbDwQvQWHBeA2Zff7u0E()
	{
		return RiA4OcQWhbZauwSmip53 == null;
	}
}
