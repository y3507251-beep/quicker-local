using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using log4net;
using Quicker.Common;
using Quicker.Utilities;
using Quicker.View.KeyInput;

namespace Quicker.View.Controls;

public class SendKeysActionParamEditor : BaseActionParamEditor, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec qZIS3HF90hL;

		public static Func<KeyInputItem, string> KdMS31RxEb9;

		internal static _003C_003Ec dElEU7yXzOny2e8bJKHj;

		static _003C_003Ec()
		{
			qZIS3HF90hL = new _003C_003Ec();
		}

		internal string nRuS3sYCtMQ(KeyInputItem x)
		{
			return x.ToText();
		}

		internal static bool Jj0bQIy2VXkBKPZmSOFv()
		{
			return dElEU7yXzOny2e8bJKHj == null;
		}
	}

	private static readonly ILog O04L4sOAxQv;

	[CompilerGenerated]
	private ObservableCollection<KeyInputItem> xO4L4H1ufkh = new ObservableCollection<KeyInputItem>();

	internal ListBox LbActions;

	internal Button BtnAddKey;

	private bool FqWL41uqXY0;

	internal static SendKeysActionParamEditor DflAJoFi6wCufN2PFPZ6;

	private ObservableCollection<KeyInputItem> Items
	{
		[CompilerGenerated]
		get
		{
			return xO4L4H1ufkh;
		}
		[CompilerGenerated]
		set
		{
			xO4L4H1ufkh = value;
		}
	}

	public SendKeysActionParamEditor()
	{
		InitializeComponent();
		LbActions.ItemsSource = Items;
	}

	public override void SetData(ActionItem actionItem)
	{
		if (actionItem == null)
		{
			return;
		}
		foreach (KeyInputItem item in KeyInputItem.ParseLines(actionItem.Data))
		{
			Items.Add(item);
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = string.Join("\n", Items.Select(_003C_003Ec.KdMS31RxEb9 ?? (_003C_003Ec.KdMS31RxEb9 = _003C_003Ec.qZIS3HF90hL.nRuS3sYCtMQ)));
	}

	private void GqWL4ePqNUw(object sender, RoutedEventArgs e)
	{
		jSJL4YpGa1V();
	}

	private void jSJL4YpGa1V()
	{
		KeyboardInputEditorWindow keyboardInputEditorWindow = new KeyboardInputEditorWindow();
		keyboardInputEditorWindow.Owner = Window.GetWindow(this);
		if (keyboardInputEditorWindow.ShowDialog() == true)
		{
			Items.Add(keyboardInputEditorWindow.ResultItem);
		}
	}

	private void T9SL4I8g9qb(object sender, RoutedEventArgs e)
	{
		try
		{
			KeyInputItem keyInputItem = (sender as Button).Tag as KeyInputItem;
			KeyboardInputEditorWindow keyboardInputEditorWindow = new KeyboardInputEditorWindow();
			keyboardInputEditorWindow.Owner = Window.GetWindow(this);
			keyboardInputEditorWindow.EditingItem = keyInputItem;
			if (keyboardInputEditorWindow.ShowDialog() == true)
			{
				Items[Items.IndexOf(keyInputItem)] = keyboardInputEditorWindow.ResultItem;
			}
		}
		catch (Exception ex)
		{
			O04L4sOAxQv.Warn("保存按键步骤出错：" + ex.Message, ex);
			AppHelper.ShowWarning("保存出错了。" + ex.Message);
		}
	}

	private void sxGL4W38NWn(object sender, RoutedEventArgs e)
	{
		KeyInputItem item = (sender as Button).Tag as KeyInputItem;
		Items.Remove(item);
	}

	public override Task StartInputAsync(ActionType? newActionType)
	{
		jSJL4YpGa1V();
		return Task.CompletedTask;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!FqWL41uqXY0)
		{
			FqWL41uqXY0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/sendkeysactionparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			FqWL41uqXY0 = true;
			break;
		case 4:
			BtnAddKey = (Button)target;
			BtnAddKey.Click += GqWL4ePqNUw;
			break;
		case 1:
			LbActions = (ListBox)target;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 3:
			((Button)target).Click += sxGL4W38NWn;
			break;
		case 2:
			((Button)target).Click += T9SL4I8g9qb;
			break;
		}
	}

	static SendKeysActionParamEditor()
	{
		O04L4sOAxQv = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool pAfJnJFitwobTmobiGBM()
	{
		return DflAJoFi6wCufN2PFPZ6 == null;
	}
}
