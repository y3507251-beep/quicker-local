using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain.Entities;
using Quicker.View.LeftButton;

namespace Quicker.View.ProfileManagement.ExeSettingControls;

public class ExeLeftButtonPlusSettingsControl : UserControl, IComponentConnector
{
	private ExeSettings IKkLNMFFRU3;

	[CompilerGenerated]
	private EventHandler m_DataChanged;

	internal LeftButtonPlusListControl LeftButtonPlusListControl;

	private bool ACZLNAhclUp;

	internal static ExeLeftButtonPlusSettingsControl n6KrbdFDEAmTlWKnNrRh;

	public event EventHandler DataChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ExeLeftButtonPlusSettingsControl()
	{
		InitializeComponent();
	}

	public void SetExe(ExeSettings exeSettings, ExeSettings defaultSettings)
	{
		IKkLNMFFRU3 = exeSettings;
		LeftButtonPlusListControl.SetData(exeSettings?.LeftButtonPlusActions);
	}

	private void LeftButtonPlusListControl_OnDataChanged(object sender, EventArgs e)
	{
		if (IKkLNMFFRU3 != null)
		{
			IKkLNMFFRU3.LeftButtonPlusActions = LeftButtonPlusListControl.GetData();
		}
		this.m_DataChanged?.Invoke(this, e);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ACZLNAhclUp)
		{
			ACZLNAhclUp = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/exesettingcontrols/exeleftbuttonplussettingscontrol.xaml", UriKind.Relative);
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
		if (connectionId == 1)
		{
			LeftButtonPlusListControl = (LeftButtonPlusListControl)target;
		}
		else
		{
			ACZLNAhclUp = true;
		}
	}

	internal static bool nG7DfSFDGXeGPSpNPqpX()
	{
		return n6KrbdFDEAmTlWKnNrRh == null;
	}
}
