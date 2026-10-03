using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using MdXaml;
using oWrbknAkO1qAtBXgONY;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.Modules.Wizard;

public class WizardWindow : System.Windows.Window, IComponentConnector
{
	[CompilerGenerated]
	private readonly SmartCollection<nRxYaRAHoWftqvfsDyQ> aFGOYPD4FC = new SmartCollection<nRxYaRAHoWftqvfsDyQ>();

	public static readonly DependencyProperty CurrentPageProperty;

	internal StepBar StepBar;

	internal TextBlock TxtTitle;

	internal TextBlock TxtSubTitle;

	internal ContentControl TheContent;

	internal Button BtnPrev;

	internal Button BtnNext;

	internal Button BtnClose;

	private bool t9hOIDFkHq;

	internal static WizardWindow eFyNjrzQrc7gtqXZguU;

	public int CurrentPage
	{
		get
		{
			return (int)GetValue(CurrentPageProperty);
		}
		set
		{
			SetValue(CurrentPageProperty, value);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal SmartCollection<nRxYaRAHoWftqvfsDyQ> BetOhPldOU()
	{
		return aFGOYPD4FC;
	}

	internal WizardWindow(IList<nRxYaRAHoWftqvfsDyQ> steps)
	{
		BetOhPldOU().Reset(steps);
		InitializeComponent();
		StepBar.ItemsSource = BetOhPldOU();
		base.Loaded += sWnORl6sbw;
		AppHelper.AddGoToPageCommandBinding(this);
	}

	private void sWnORl6sbw(object sender, RoutedEventArgs e)
	{
		TIvOqm3kjx(0);
	}

	private void TIvOqm3kjx(int int_0)
	{
		if (int_0 >= 0 && int_0 < BetOhPldOU().Count)
		{
			CurrentPage = int_0;
			nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ = BetOhPldOU()[int_0];
			TxtTitle.Text = nRxYaRAHoWftqvfsDyQ.Title;
			TxtSubTitle.Text = nRxYaRAHoWftqvfsDyQ.F8XOLPRHx9();
			if (nRxYaRAHoWftqvfsDyQ.Content is string markdown)
			{
				MarkdownScrollViewer markdownScrollViewer = new MarkdownScrollViewer();
				markdownScrollViewer.VerticalContentAlignment = VerticalAlignment.Top;
				markdownScrollViewer.MarkdownStyle = TryFindResource("MarkdownHelpStyle") as Style;
				int num = 1;
				if (eFyNjrzQrc7gtqXZguU != null)
				{
					int num2 = default(int);
					num = num2;
				}
				do
				{
					switch (num)
					{
					case 1:
						goto IL_009c;
					}
					break;
					IL_009c:
					TheContent.Content = markdownScrollViewer;
					markdownScrollViewer.Markdown = markdown;
					num = 0;
				}
				while (!xBOBLkzFrWkBoWbVDnO());
			}
			else if (nRxYaRAHoWftqvfsDyQ.Content != null)
			{
				TheContent.Content = nRxYaRAHoWftqvfsDyQ.Content;
			}
			else if (nRxYaRAHoWftqvfsDyQ.AOYO0woBof() != null)
			{
				TheContent.Content = nRxYaRAHoWftqvfsDyQ.AOYO0woBof()();
			}
			StepBar.StepIndex = CurrentPage;
			lW4OcNNdX3();
		}
		else
		{
			AppHelper.ShowInformation($"页码{int_0}超出范围。");
		}
	}

	private void lW4OcNNdX3()
	{
		BtnPrev.Visibility = (CurrentPage > 0).ToVisibility();
		BtnNext.Visibility = (CurrentPage < BetOhPldOU().Count - 1).ToVisibility();
		BtnClose.Visibility = (CurrentPage == BetOhPldOU().Count - 1).ToVisibility();
	}

	private void RTCOVkMDtl(object sender, RoutedEventArgs e)
	{
		TIvOqm3kjx(CurrentPage - 1);
	}

	private void GojOZGBrVa(object sender, RoutedEventArgs e)
	{
		TIvOqm3kjx(CurrentPage + 1);
	}

	private void VOmO91enl8(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!t9hOIDFkHq)
		{
			t9hOIDFkHq = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/wizard/wizardwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			t9hOIDFkHq = true;
			break;
		case 1:
			StepBar = (StepBar)target;
			break;
		case 2:
			TxtTitle = (TextBlock)target;
			break;
		case 3:
			TxtSubTitle = (TextBlock)target;
			if (eFyNjrzQrc7gtqXZguU != null)
			{
				switch (0)
				{
				}
			}
			break;
		case 4:
			TheContent = (ContentControl)target;
			break;
		case 5:
			BtnPrev = (Button)target;
			BtnPrev.Click += RTCOVkMDtl;
			break;
		case 6:
			BtnNext = (Button)target;
			BtnNext.Click += GojOZGBrVa;
			break;
		case 7:
			BtnClose = (Button)target;
			BtnClose.Click += VOmO91enl8;
			break;
		}
	}

	static WizardWindow()
	{
		CurrentPageProperty = DependencyProperty.Register("CurrentPage", typeof(int), typeof(WizardWindow), new PropertyMetadata(0));
	}

	internal static bool xBOBLkzFrWkBoWbVDnO()
	{
		return eFyNjrzQrc7gtqXZguU == null;
	}
}
