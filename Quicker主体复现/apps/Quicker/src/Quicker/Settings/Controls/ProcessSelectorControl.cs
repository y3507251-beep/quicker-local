using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.View.Controls;

namespace Quicker.Settings.Controls;

public class ProcessSelectorControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xJ8vVq7h7ic;

		public static Func<string, string> EhnvVcUZ3l9;

		internal static _003C_003Ec KY1ZW2cNPpj8FrIHwx6q;

		static _003C_003Ec()
		{
			xJ8vVq7h7ic = new _003C_003Ec();
		}

		internal string Gc6vVRHNhEK(string x)
		{
			return x;
		}

		internal static bool s0wWPqcNMIrC9C8Hd8yw()
		{
			return KY1ZW2cNPpj8FrIHwx6q == null;
		}
	}

	[CompilerGenerated]
	private EventHandler<EventArgs> m_Changed;

	[CompilerGenerated]
	private bool OX0jkXSMlf = true;

	private string bwUjGKw5WT;

	internal TextBox TxtCtrlInsertProcesses;

	private bool CcHjslTLRT;

	private static ProcessSelectorControl CxXCSYSgISaJNWp2gJc;

	public bool AllowMultiple
	{
		[CompilerGenerated]
		get
		{
			return OX0jkXSMlf;
		}
		[CompilerGenerated]
		set
		{
			OX0jkXSMlf = value;
		}
	}

	public string ProcessList
	{
		get
		{
			return TxtCtrlInsertProcesses.Text ?? string.Empty;
		}
		set
		{
			TxtCtrlInsertProcesses.Text = value;
		}
	}

	public event EventHandler<EventArgs> Changed
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs> eventHandler = this.m_Changed;
			EventHandler<EventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs> value2 = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_Changed, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs> eventHandler = this.m_Changed;
			EventHandler<EventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs> value2 = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_Changed, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ProcessSelectorControl()
	{
		InitializeComponent();
	}

	private void WindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		if (AllowMultiple)
		{
			if (string.IsNullOrWhiteSpace(TxtCtrlInsertProcesses.Text))
			{
				TxtCtrlInsertProcesses.Text = e.ProcessName.ToLower();
			}
			else
			{
				string text = TxtCtrlInsertProcesses.Text.Trim().TrimEnd(';') + ";" + e.ProcessName.ToLower();
				if (!QQtDBDSPbPby4Pej6vt())
				{
					switch (0)
					{
					}
				}
				TxtCtrlInsertProcesses.Text = string.Join(";", text.Split(new char[4] { ';', ',', '；', '，' }, StringSplitOptions.RemoveEmptyEntries).Distinct().OrderBy(_003C_003Ec.EhnvVcUZ3l9 ?? (_003C_003Ec.EhnvVcUZ3l9 = _003C_003Ec.xJ8vVq7h7ic.Gc6vVRHNhEK)));
			}
		}
		else
		{
			TxtCtrlInsertProcesses.Text = e.ProcessName.ToLower();
		}
		wsxjWuI9wf();
	}

	private void THYjIrNbU5(object sender, RoutedEventArgs e)
	{
		wsxjWuI9wf();
	}

	private void wsxjWuI9wf()
	{
		if (!string.Equals(TxtCtrlInsertProcesses.Text, bwUjGKw5WT))
		{
			this.m_Changed?.Invoke(this, EventArgs.Empty);
			bwUjGKw5WT = TxtCtrlInsertProcesses.Text;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!CcHjslTLRT)
		{
			CcHjslTLRT = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/controls/processselectorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
			TxtCtrlInsertProcesses = (TextBox)target;
			TxtCtrlInsertProcesses.LostFocus += THYjIrNbU5;
		}
		else
		{
			CcHjslTLRT = true;
		}
	}

	internal static bool QQtDBDSPbPby4Pej6vt()
	{
		return CxXCSYSgISaJNWp2gJc == null;
	}
}
