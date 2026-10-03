using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Newtonsoft.Json;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class CompositeActionParamEditor : BaseActionParamEditor, IComponentConnector, IStyleConnector
{
	private ActionItem BRNL4Qqpcqo;

	[CompilerGenerated]
	private string cZVL4jYy3TZ;

	private readonly ObservableCollection<ActionItem> cKFL4nu66GC = new ObservableCollection<ActionItem>();

	internal ListBox LbActions;

	internal Button BtnNewAction;

	private bool ChWL44vJJdO;

	internal static CompositeActionParamEditor FkHPvkFi49EnskoT2rbu;

	private string IconImage
	{
		[CompilerGenerated]
		get
		{
			return cZVL4jYy3TZ;
		}
		[CompilerGenerated]
		set
		{
			cZVL4jYy3TZ = value;
		}
	}

	public CompositeActionParamEditor()
	{
		InitializeComponent();
		base.Loaded += KtUL4XqPEaA;
	}

	private void KtUL4XqPEaA(object sender, RoutedEventArgs e)
	{
		LbActions.ItemsSource = cKFL4nu66GC;
	}

	public override void SetData(ActionItem actionItem)
	{
		BRNL4Qqpcqo = actionItem;
		if (actionItem == null || string.IsNullOrEmpty(actionItem.Data))
		{
			return;
		}
		foreach (ActionItem item in JsonConvert.DeserializeObject<IList<ActionItem>>(actionItem.Data))
		{
			cKFL4nu66GC.Add(item);
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = JsonConvert.SerializeObject(cKFL4nu66GC.ToList());
		if (!string.IsNullOrEmpty(IconImage))
		{
			actionItem.Icon = IconImage;
		}
	}

	private void nZSL4mlMir4(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			ActionEditorWindow actionEditorWindow = AppState.dAntabrFWrV().Get<ActionEditorWindow>(Array.Empty<IParameter>());
			int num2 = 0;
			if (FkHPvkFi49EnskoT2rbu != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			actionEditorWindow.Title = "添加子动作";
			actionEditorWindow.IsEditingSubAction = true;
			actionEditorWindow.Owner = Window.GetWindow(this);
			if (actionEditorWindow.ShowDialog() == true)
			{
				cKFL4nu66GC.Add(actionEditorWindow.ResultItem);
				OnDataChanged();
			}
			return;
		}
	}

	private void txOL4KFCpr6(object sender, DragEventArgs e)
	{
	}

	private void APoL4xsq07g(object sender, RoutedEventArgs e)
	{
		ActionItem actionItem = (sender as Button).Tag as ActionItem;
		ActionEditorWindow actionEditorWindow = AppState.dAntabrFWrV().Get<ActionEditorWindow>(Array.Empty<IParameter>());
		actionEditorWindow.Owner = Window.GetWindow(this);
		actionEditorWindow.IsEditingSubAction = true;
		actionEditorWindow.EditingActionItem = actionItem;
		actionEditorWindow.Title = "编辑子动作";
		int num = 0;
		if (FkHPvkFi49EnskoT2rbu != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (actionEditorWindow.ShowDialog() == true)
		{
			int num3 = cKFL4nu66GC.IndexOf(actionItem);
			if (num3 < 0)
			{
				AppHelper.ShowWarning("发现了异常数据，请重试。");
				return;
			}
			cKFL4nu66GC[num3] = actionEditorWindow.ResultItem;
			OnDataChanged();
		}
	}

	private void d2dL4rhDVTt(object sender, RoutedEventArgs e)
	{
		ActionItem item = (sender as Button).Tag as ActionItem;
		if (MessageBoxHelper.Show("您确认要删除么？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
		{
			cKFL4nu66GC.Remove(item);
			OnDataChanged();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!ChWL44vJJdO)
		{
			ChWL44vJJdO = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/compositeactionparameditor.xaml", UriKind.Relative);
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
			ChWL44vJJdO = true;
			break;
		case 5:
			BtnNewAction = (Button)target;
			BtnNewAction.Click += nZSL4mlMir4;
			break;
		case 1:
			LbActions = (ListBox)target;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
			((Grid)target).Drop += txOL4KFCpr6;
			break;
		case 3:
			((Button)target).Click += APoL4xsq07g;
			break;
		case 4:
			((Button)target).Click += d2dL4rhDVTt;
			break;
		}
	}

	internal static bool BLKmTfFihWx8BmeYpspo()
	{
		return FkHPvkFi49EnskoT2rbu == null;
	}
}
