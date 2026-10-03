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

public class SelectActionParamEditor : BaseActionParamEditor, IComponentConnector, IStyleConnector
{
	private ActionItem VDrLnm7Z3Je;

	[CompilerGenerated]
	private string C00LnKErpY1;

	private readonly ObservableCollection<ActionItem> mdOLnx0L5hF = new ObservableCollection<ActionItem>();

	internal ListBox LbActions;

	internal Button BtnNewAction;

	private bool HXtLnrnkXC1;

	private static SelectActionParamEditor IrQ5TvFiXcjhqtc5wpCO;

	private string IconImage
	{
		[CompilerGenerated]
		get
		{
			return C00LnKErpY1;
		}
		[CompilerGenerated]
		set
		{
			C00LnKErpY1 = value;
		}
	}

	public SelectActionParamEditor()
	{
		InitializeComponent();
		base.Loaded += BiTLnGXP4tD;
	}

	private void BiTLnGXP4tD(object sender, RoutedEventArgs e)
	{
		LbActions.ItemsSource = mdOLnx0L5hF;
	}

	public override void SetData(ActionItem actionItem)
	{
		VDrLnm7Z3Je = actionItem;
		if (actionItem == null || string.IsNullOrEmpty(actionItem.Data))
		{
			return;
		}
		foreach (ActionItem item in JsonConvert.DeserializeObject<IList<ActionItem>>(actionItem.Data))
		{
			mdOLnx0L5hF.Add(item);
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		actionItem.Data = JsonConvert.SerializeObject(mdOLnx0L5hF.ToList());
		if (!string.IsNullOrEmpty(IconImage))
		{
			actionItem.Icon = IconImage;
		}
	}

	private void RNbLnsOrW0R(object sender, RoutedEventArgs e)
	{
		ActionEditorWindow actionEditorWindow = AppState.dAntabrFWrV().Get<ActionEditorWindow>(Array.Empty<IParameter>());
		actionEditorWindow.IsEditingSubAction = true;
		actionEditorWindow.Owner = Window.GetWindow(this);
		if (actionEditorWindow.ShowDialog() == true)
		{
			mdOLnx0L5hF.Add(actionEditorWindow.ResultItem);
			OnDataChanged();
		}
	}

	private void TyyLnHxMgQx(object sender, DragEventArgs e)
	{
	}

	private void RW1Ln1XXuF1(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			ActionItem actionItem = (sender as Button).Tag as ActionItem;
			int num2 = 0;
			if (!Xrrri0Fi21vtLDNA1ZrV())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			ActionEditorWindow actionEditorWindow = AppState.dAntabrFWrV().Get<ActionEditorWindow>(Array.Empty<IParameter>());
			actionEditorWindow.Owner = Window.GetWindow(this);
			actionEditorWindow.IsEditingSubAction = true;
			actionEditorWindow.EditingActionItem = actionItem;
			if (actionEditorWindow.ShowDialog() == true)
			{
				mdOLnx0L5hF[mdOLnx0L5hF.IndexOf(actionItem)] = actionEditorWindow.ResultItem;
				OnDataChanged();
			}
			return;
		}
	}

	private void xi9LnbfULbB(object sender, RoutedEventArgs e)
	{
		ActionItem item = (sender as Button).Tag as ActionItem;
		if (MessageBoxHelper.Show("您确认要删除么？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
		{
			mdOLnx0L5hF.Remove(item);
			OnDataChanged();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HXtLnrnkXC1)
		{
			HXtLnrnkXC1 = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/selectactionparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			HXtLnrnkXC1 = true;
			break;
		case 5:
			BtnNewAction = (Button)target;
			BtnNewAction.Click += RNbLnsOrW0R;
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
			((Grid)target).Drop += TyyLnHxMgQx;
			break;
		case 3:
			((Button)target).Click += RW1Ln1XXuF1;
			break;
		case 4:
			((Button)target).Click += xi9LnbfULbB;
			break;
		}
	}

	internal static bool Xrrri0Fi21vtLDNA1ZrV()
	{
		return IrQ5TvFiXcjhqtc5wpCO == null;
	}
}
