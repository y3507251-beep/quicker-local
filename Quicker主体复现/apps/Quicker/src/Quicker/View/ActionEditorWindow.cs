using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.View;

public class ActionEditorWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec CAySrJaRFZf;

		public static Func<ActionTypeItem, bool> I1eSr0gOkJe;

		public static Func<ActionTypeItem, bool> nY5SrC74yIG;

		internal static _003C_003Ec QiyQyXWg8aioaxJBkN9L;

		static _003C_003Ec()
		{
			CAySrJaRFZf = new _003C_003Ec();
		}

		internal bool hyYSruJ26Fl(ActionTypeItem x)
		{
			return x.ActionType == ActionType.XAction;
		}

		internal bool YuNSrNNGtHs(ActionTypeItem x)
		{
			return x.ActionType == ActionType.Composite;
		}

		internal static void aD5jEnWgPpOFCGvyqA41()
		{
		}

		internal static bool eLK0QwWgR4Sm0BkFwRlK()
		{
			return QiyQyXWg8aioaxJBkN9L == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionType X1NSrE9IUQT;

		private static _003C_003Ec__DisplayClass40_0 gUAcoZWgUVQXXhFhNYRY;

		internal bool wOtSrPT1sBo(ActionTypeItem x)
		{
			return x.ActionType == X1NSrE9IUQT;
		}

		internal static bool NV2FkxWgx7VSrpLuIDeE()
		{
			return gUAcoZWgUVQXXhFhNYRY == null;
		}
	}

	private readonly IconManager hTVgl5JvqBE;

	[CompilerGenerated]
	private ActionItem NAOglD6Inwf;

	[CompilerGenerated]
	private string Qrdgld6gB5B;

	[CompilerGenerated]
	private bool Kt5gloN2B2A;

	private BaseActionParamEditor GeRglTyjc0v;

	[CompilerGenerated]
	private ActionItem wNUglMqxle0;

	[CompilerGenerated]
	private ActionItem LruglAJZPUg;

	[CompilerGenerated]
	private bool nqUglOsSDfe;

	[CompilerGenerated]
	private ActionType? IMpglFF89AO;

	[CompilerGenerated]
	private bool? tIBglUQtvB9;

	[CompilerGenerated]
	private IList<ActionTypeItem> HwVgllywDgn = new List<ActionTypeItem>();

	internal Grid ActionGrid;

	internal ComboBox CbActionTypes;

	internal ContentControl EditorPlaceholder;

	internal ActionUIEditor UiEditor;

	internal HelpLinkControl HelpLinkControl;

	internal Button Save;

	internal Button BtnCancel;

	private bool Ltcglig0s9G;

	internal static ActionEditorWindow p1SYP8FyUghJCpC21rxT;

	public ActionItem EditingActionItem
	{
		[CompilerGenerated]
		get
		{
			return NAOglD6Inwf;
		}
		[CompilerGenerated]
		set
		{
			NAOglD6Inwf = value;
		}
	}

	public string ExeFile
	{
		[CompilerGenerated]
		get
		{
			return Qrdgld6gB5B;
		}
		[CompilerGenerated]
		set
		{
			Qrdgld6gB5B = value;
		}
	}

	public bool IsEditingSubAction
	{
		[CompilerGenerated]
		get
		{
			return Kt5gloN2B2A;
		}
		[CompilerGenerated]
		set
		{
			Kt5gloN2B2A = value;
		}
	}

	public ActionItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return LruglAJZPUg;
		}
		[CompilerGenerated]
		set
		{
			LruglAJZPUg = value;
		}
	}

	public bool IsReadonly
	{
		[CompilerGenerated]
		get
		{
			return nqUglOsSDfe;
		}
		[CompilerGenerated]
		set
		{
			nqUglOsSDfe = value;
		}
	}

	public ActionType? NewActionType
	{
		[CompilerGenerated]
		get
		{
			return IMpglFF89AO;
		}
		[CompilerGenerated]
		set
		{
			IMpglFF89AO = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return tIBglUQtvB9;
		}
		[CompilerGenerated]
		set
		{
			tIBglUQtvB9 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private ActionItem QL9glpYduhg()
	{
		return wNUglMqxle0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void e66glBto6MJ(ActionItem value)
	{
		wNUglMqxle0 = value;
	}

	public ActionEditorWindow(IconManager iconManager)
	{
		hTVgl5JvqBE = iconManager;
		InitializeComponent();
		base.Loaded += fGqglHU3aej;
		base.Closing += dO7glshuXXx;
	}

	private void dO7glshuXXx(object sender, CancelEventArgs e)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private IList<ActionTypeItem> HQLgljN2PCb()
	{
		return HwVgllywDgn;
	}

	[SpecialName]
	[CompilerGenerated]
	private void vgqglnMEYym(IList<ActionTypeItem> value)
	{
		HwVgllywDgn = value;
	}

	private void fGqglHU3aej(object sender, RoutedEventArgs e)
	{
		Save.IsEnabled = !IsReadonly;
		DHHgl1KqwC4();
		if (EditingActionItem != null)
		{
			ActionTypeManager.FixActionType(EditingActionItem);
			ActionTypeItem actionTypeItem = HQLgljN2PCb().FirstOrDefault(fv9glK7oiC1);
			if (actionTypeItem != null)
			{
				CbActionTypes.SelectedItem = actionTypeItem;
			}
			else
			{
				AppHelper.ShowWarning("已不支持此动作类型：" + EditingActionItem.ActionType);
			}
			o4sgl6LjNBV(EditingActionItem);
		}
		else if (NewActionType.HasValue)
		{
			_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
			_003C_003Ec__DisplayClass40_.X1NSrE9IUQT = AppHelper.GetBaseActionType(NewActionType.Value);
			ActionTypeItem actionTypeItem2 = HQLgljN2PCb().FirstOrDefault(_003C_003Ec__DisplayClass40_.wOtSrPT1sBo);
			if (actionTypeItem2 != null)
			{
				CbActionTypes.SelectedItem = actionTypeItem2;
			}
		}
		UpdateLayout();
		int num = 0;
		if (n73vTgFyx0UHbRTXn9Uf())
		{
			goto IL_0102;
		}
		goto IL_0129;
		IL_0129:
		switch (num)
		{
		case 1:
			return;
		}
		goto IL_0102;
		IL_0102:
		IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowWindowLocation.CenterScreen);
		num = 1;
		if (!n73vTgFyx0UHbRTXn9Uf())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0129;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void DHHgl1KqwC4()
	{
		int num2 = default(int);
		foreach (KeyValuePair<ActionType, ActionTypeInfo> allActionType in ActionTypeManager.AllActionTypes)
		{
			if ((!IsEditingSubAction || !allActionType.Value.CanBeChildAction) && (IsEditingSubAction || !allActionType.Value.CanBeRootAction))
			{
				continue;
			}
			if (AppState.DataService.eZqtmsq6kBc() && allActionType.Key == ActionType.Folder)
			{
				if (EditingActionItem == null)
				{
					continue;
				}
				int num = 0;
				if (p1SYP8FyUghJCpC21rxT != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (EditingActionItem.ActionType != ActionType.Folder)
				{
					continue;
				}
			}
			if (allActionType.Key != ActionType.XAction && (EditingActionItem != null || allActionType.Key != ActionType.Composite))
			{
				HQLgljN2PCb().Add(new ActionTypeItem
				{
					ActionType = allActionType.Key,
					Description = allActionType.Value.Description,
					Icon = allActionType.Value.Icon,
					Name = allActionType.Value.Name
				});
			}
		}
		if (IsEditingSubAction)
		{
			ActionTypeItem actionTypeItem = HQLgljN2PCb().FirstOrDefault(_003C_003Ec.I1eSr0gOkJe ?? (_003C_003Ec.I1eSr0gOkJe = _003C_003Ec.CAySrJaRFZf.hyYSruJ26Fl));
			if (actionTypeItem != null)
			{
				HQLgljN2PCb().Remove(actionTypeItem);
			}
		}
		if (EditingActionItem != null && EditingActionItem.ActionType != ActionType.Composite)
		{
			ActionTypeItem actionTypeItem2 = HQLgljN2PCb().FirstOrDefault(_003C_003Ec.nY5SrC74yIG ?? (_003C_003Ec.nY5SrC74yIG = _003C_003Ec.CAySrJaRFZf.YuNSrNNGtHs));
			if (actionTypeItem2 != null)
			{
				HQLgljN2PCb().Remove(actionTypeItem2);
			}
		}
		CbActionTypes.ItemsSource = HQLgljN2PCb();
		if (!n73vTgFyx0UHbRTXn9Uf())
		{
			switch (0)
			{
			}
		}
	}

	private void LieglbtsuW2(object sender, SelectionChangedEventArgs e)
	{
		if (!(CbActionTypes.SelectedItem is ActionTypeItem actionTypeItem))
		{
			return;
		}
		ActionTypeInfo actionTypeInfo = ActionTypeManager.GetActionTypeInfo(actionTypeItem.ActionType);
		if (!string.IsNullOrWhiteSpace(actionTypeInfo.HelpLink))
		{
			HelpLinkControl.Url = actionTypeInfo.HelpLink;
			HelpLinkControl.Visibility = Visibility.Visible;
		}
		else
		{
			HelpLinkControl.Visibility = Visibility.Collapsed;
		}
		GeRglTyjc0v = ActionTypeManager.CreateParamEditor(actionTypeItem.ActionType);
		EditorPlaceholder.Content = GeRglTyjc0v;
		int num = 0;
		if (!n73vTgFyx0UHbRTXn9Uf())
		{
			goto IL_0126;
		}
		goto IL_012a;
		IL_0126:
		int num2 = default(int);
		num = num2;
		goto IL_012a;
		IL_012a:
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			string text = EditingActionItem?.Id;
			if (EditingActionItem != null && EditingActionItem.ActionType == actionTypeItem.ActionType)
			{
				e66glBto6MJ(EditingActionItem.Clone(false));
			}
			else
			{
				e66glBto6MJ(ActionTypeManager.CreateActionItem(actionTypeItem.ActionType));
				if (!string.IsNullOrEmpty(text))
				{
					QL9glpYduhg().Id = text;
				}
			}
			if (GeRglTyjc0v == null)
			{
				o4sgl6LjNBV(QL9glpYduhg());
				num = 1;
				if (n73vTgFyx0UHbRTXn9Uf())
				{
					continue;
				}
				break;
			}
			GeRglTyjc0v.SetData(QL9glpYduhg());
			o4sgl6LjNBV(QL9glpYduhg());
			GeRglTyjc0v.DataChanged += q6CglxQSAxT;
			if (string.IsNullOrEmpty(QL9glpYduhg().Data))
			{
				base.Dispatcher.InvokeAsync(pyhglr6dRBw);
			}
			return;
		}
		goto IL_0126;
	}

	public void UpdateTitleAndIcon(string title, string icon)
	{
		QL9glpYduhg().Title = title;
		QL9glpYduhg().Icon = icon;
		UiEditor.SetUiData(QL9glpYduhg());
	}

	private void o4sgl6LjNBV(ActionItem actionItem_3)
	{
		if (string.IsNullOrWhiteSpace(UiEditor.ActionTitle))
		{
			UiEditor.SetUiData(actionItem_3);
		}
	}

	private void S0KglX2bW9j(object sender, RoutedEventArgs e)
	{
		string text = default(string);
		int num;
		if (GeRglTyjc0v != null)
		{
			bool flag;
			(flag, text) = GeRglTyjc0v.Validate();
			if (!flag)
			{
				num = 0;
				if (p1SYP8FyUghJCpC21rxT != null)
				{
					goto IL_00ea;
				}
				goto IL_00ee;
			}
		}
		if (CbActionTypes.SelectedItem != null && QL9glpYduhg() != null)
		{
			GeRglTyjc0v?.SaveData(QL9glpYduhg());
			UiEditor.SaveToAction(QL9glpYduhg());
			ResultItem = QL9glpYduhg();
			if (string.IsNullOrEmpty(ResultItem.Title))
			{
				if (AppHelper.AskUser("尚未为动作设置文字标签，您确认不设置标签么？") == MessageBoxResult.OK)
				{
					Result = true;
					if (this.IL8vudVpbi3())
					{
						base.DialogResult = true;
					}
					else
					{
						Close();
					}
				}
				return;
			}
			Result = true;
			num = 1;
			if (!n73vTgFyx0UHbRTXn9Uf())
			{
				goto IL_00ea;
			}
			goto IL_00ee;
		}
		AppHelper.ShowWarning("没有要保存的动作内容。", true);
		return;
		IL_00ea:
		int num2 = default(int);
		num = num2;
		goto IL_00ee;
		IL_00ee:
		switch (num)
		{
		default:
			AppHelper.ShowWarning("参数不合法：" + text);
			break;
		case 1:
			if (!this.IL8vudVpbi3())
			{
				Close();
			}
			else
			{
				base.DialogResult = true;
			}
			break;
		}
	}

	private void xwdglmiVXVA(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Ltcglig0s9G)
		{
			Ltcglig0s9G = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actioneditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			Ltcglig0s9G = true;
			break;
		case 1:
			ActionGrid = (Grid)target;
			break;
		case 2:
			CbActionTypes = (ComboBox)target;
			CbActionTypes.SelectionChanged += LieglbtsuW2;
			break;
		case 3:
			EditorPlaceholder = (ContentControl)target;
			break;
		case 4:
			UiEditor = (ActionUIEditor)target;
			break;
		case 5:
		{
			HelpLinkControl = (HelpLinkControl)target;
			int num = 0;
			if (p1SYP8FyUghJCpC21rxT != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 6:
			Save = (Button)target;
			Save.Click += S0KglX2bW9j;
			break;
		case 7:
			BtnCancel = (Button)target;
			BtnCancel.Click += xwdglmiVXVA;
			break;
		}
	}

	[CompilerGenerated]
	private bool fv9glK7oiC1(ActionTypeItem actionTypeItem_0)
	{
		return actionTypeItem_0.ActionType == EditingActionItem.ActionType;
	}

	[CompilerGenerated]
	private void q6CglxQSAxT(object sender, EventArgs e)
	{
		GeRglTyjc0v.SaveData(QL9glpYduhg());
		o4sgl6LjNBV(QL9glpYduhg());
	}

	[CompilerGenerated]
	private void pyhglr6dRBw()
	{
		GeRglTyjc0v.StartInputAsync(NewActionType).ConfigureAwait(true);
	}

	internal static bool n73vTgFyx0UHbRTXn9Uf()
	{
		return p1SYP8FyUghJCpC21rxT == null;
	}
}
