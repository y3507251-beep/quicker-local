using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Extensions;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class ActionSelector : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private EventHandler<ActionItem> m_ActionSelected;

	private ActionItem NGSLBcbyWeX;

	internal TextBox TxtActionId;

	internal Button BtnSelectAction;

	internal Button BtnEdit;

	internal Button BtnFloat;

	internal IconControl ImgIcon;

	internal TextBlock TextActionTitle;

	private bool KkCLBVs3OGh;

	internal static ActionSelector MyskAoFfg1VdFiCtbKIK;

	public string ActionIdOrName
	{
		get
		{
			return TxtActionId.Text;
		}
		set
		{
			TxtActionId.Text = value;
		}
	}

	public event EventHandler<ActionItem> ActionSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ActionItem> eventHandler = this.m_ActionSelected;
			EventHandler<ActionItem> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActionItem> value2 = (EventHandler<ActionItem>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ActionItem> eventHandler = this.m_ActionSelected;
			EventHandler<ActionItem> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ActionItem> value2 = (EventHandler<ActionItem>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ActionSelected, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ActionSelector()
	{
		InitializeComponent();
	}

	private void gfXLB8xojsf(object sender, RoutedEventArgs e)
	{
		SearchActionWindow searchActionWindow = new SearchActionWindow(AppState.DataService);
		searchActionWindow.Owner = Window.GetWindow(this);
		if (searchActionWindow.ShowDialog() != true)
		{
			return;
		}
		ActionItem result = searchActionWindow.Result;
		TextBox txtActionId = TxtActionId;
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
				goto IL_0051;
			}
		}
		obj = "";
		goto IL_0051;
		IL_0051:
		txtActionId.Text = (string)obj;
		this.m_ActionSelected?.Invoke(this, result);
	}

	private void oXFLBaqKahT(object sender, TextChangedEventArgs e)
	{
		vDPLB7ii1bt();
	}

	private void vDPLB7ii1bt()
	{
		NGSLBcbyWeX = null;
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(TxtActionId.Text);
		if (tuple.Item1 != null)
		{
			ImgIcon.Icon = tuple.Item1.Icon;
			TextActionTitle.Text = tuple.Item1.Title;
			TextActionTitle.Foreground = Brushes.Gray;
			(NGSLBcbyWeX, _) = tuple;
			return;
		}
		ImgIcon.Icon = null;
		TextActionTitle.Text = tuple.Item2;
		TextActionTitle.Foreground = Brushes.Red;
		int num = 0;
		if (!caMAvKFfP8S9QUlk3Qq6())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void ndWLBR0SXuY(object sender, RoutedEventArgs e)
	{
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(TxtActionId.Text);
		if (tuple.Item1 != null)
		{
			AppState.lWutartRfUY().EditActionById(tuple.Item1.Id, null, tuple.Item1.IsReadOnly());
		}
		else
		{
			AppHelper.ShowWarning("未找到动作。");
		}
	}

	private void SqkLBq06HR0(object sender, RoutedEventArgs e)
	{
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(TxtActionId.Text);
		if (tuple.Item1 != null)
		{
			AppState.lWutartRfUY().FloatAction(tuple.Item1, Window.GetWindow(this));
		}
		else
		{
			AppHelper.ShowWarning("未找到动作。");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!KkCLBVs3OGh)
		{
			KkCLBVs3OGh = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/actionselector.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				TxtActionId = (TextBox)target;
				TxtActionId.TextChanged += oXFLBaqKahT;
				return;
			case 2:
				BtnSelectAction = (Button)target;
				BtnSelectAction.Click += gfXLB8xojsf;
				return;
			case 3:
				BtnEdit = (Button)target;
				BtnEdit.Click += ndWLBR0SXuY;
				return;
			case 4:
				BtnFloat = (Button)target;
				BtnFloat.Click += SqkLBq06HR0;
				return;
			case 5:
				ImgIcon = (IconControl)target;
				return;
			case 6:
				TextActionTitle = (TextBlock)target;
				return;
			}
			if (caMAvKFfP8S9QUlk3Qq6())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			KkCLBVs3OGh = true;
			return;
		}
	}

	internal static bool caMAvKFfP8S9QUlk3Qq6()
	{
		return MyskAoFfg1VdFiCtbKIK == null;
	}
}
