using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain.PowerMouse;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using WindowsInput.Native;

namespace Quicker.Modules.Gestures.Manage;

public class SubActionEditWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public int C1pvWXJ3u7M;

		internal static _003C_003Ec__DisplayClass9_0 mymqp3c5e7wkAdtUkPiT;

		internal bool okvvWbobVBC(SubAction x)
		{
			return x.Key == C1pvWXJ3u7M;
		}

		internal bool RtAvW6fprV6(SubAction x)
		{
			return x.Key == C1pvWXJ3u7M;
		}

		internal static void k1r4ccc53Ocj1iKdeXC1()
		{
		}

		internal static bool DFySV7c5jV0CDuSaap6E()
		{
			return mymqp3c5e7wkAdtUkPiT == null;
		}
	}

	private readonly IList<SubAction> glEtLwKyJ6w;

	private readonly SubAction Qj0tLtYp38j;

	[CompilerGenerated]
	private SubAction NbvtLgbXN4f;

	[CompilerGenerated]
	private bool? RwCtLL7h71G;

	internal HotkeyEditorControl KeyEditor;

	internal TextBox TxtDescription;

	internal QuickActionEditor QuickActionEditor;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool YLGtLvs2lPZ;

	private static SubActionEditWindow CER7FAQWYsXB87r4xIaF;

	public SubAction ResultItem
	{
		[CompilerGenerated]
		get
		{
			return NbvtLgbXN4f;
		}
		[CompilerGenerated]
		set
		{
			NbvtLgbXN4f = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return RwCtLL7h71G;
		}
		[CompilerGenerated]
		set
		{
			RwCtLL7h71G = value;
		}
	}

	public SubActionEditWindow(IList<SubAction> currentSubActions, SubAction editingSubActionItem)
	{
		glEtLwKyJ6w = currentSubActions;
		Qj0tLtYp38j = editingSubActionItem;
		InitializeComponent();
		base.Loaded += ObetgiyD8kF;
	}

	private void ObetgiyD8kF(object sender, RoutedEventArgs e)
	{
		if (Qj0tLtYp38j != null)
		{
			KeyEditor.SetSingleKey(Qj0tLtYp38j.Key);
			TxtDescription.Text = Qj0tLtYp38j.Description;
			QuickActionEditor.SetData(Qj0tLtYp38j);
		}
		else
		{
			KeyEditor.BeginInput();
		}
	}

	private void ergtg3htnML(object sender, RoutedEventArgs e)
	{
		if (KeyEditor.Hotkey == null)
		{
			AppHelper.ShowWarning("请输入按键。");
			int num = 0;
			if (!y9s2rwQW87cCUdi0d939())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			KeyEditor.BeginInput();
			return;
		}
		int key = (int)KeyEditor.Hotkey.Key;
		if (!bUKtgfLDTQR())
		{
			KeyEditor.Focus();
			AppHelper.ShowWarning("当前键 " + KeyboardHelper.GetKeyName((VirtualKeyCode)key) + " 已被使用。");
			return;
		}
		(bool, string) tuple = QuickActionEditor.IsDataValid();
		if (!tuple.Item1)
		{
			AppHelper.ShowWarning(tuple.Item2, true);
			return;
		}
		ResultItem = new SubAction
		{
			Key = key,
			Description = TxtDescription.Text
		};
		QuickActionEditor.SaveData(ResultItem);
		this.ThNvuM5Q9GQ(true);
	}

	private bool bUKtgfLDTQR()
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.C1pvWXJ3u7M = (int)KeyEditor.Hotkey.Key;
		if (Qj0tLtYp38j == null)
		{
			if (glEtLwKyJ6w.Any(_003C_003Ec__DisplayClass9_.okvvWbobVBC))
			{
				return false;
			}
		}
		else
		{
			if (Qj0tLtYp38j.Key == _003C_003Ec__DisplayClass9_.C1pvWXJ3u7M)
			{
				return true;
			}
			if (glEtLwKyJ6w.Any(_003C_003Ec__DisplayClass9_.RtAvW6fprV6))
			{
				return false;
			}
		}
		return true;
	}

	private void KeyEditor_OnHotkeyChanged(object sender, HotkeyDataEventArgs e)
	{
		if (KeyEditor.Hotkey != null)
		{
			int key = (int)KeyEditor.Hotkey.Key;
			if (!bUKtgfLDTQR())
			{
				KeyEditor.Hotkey = null;
				KeyEditor.BeginInput();
				AppHelper.ShowWarning("当前键 " + KeyboardHelper.GetKeyName((VirtualKeyCode)key) + " 已被使用。");
			}
		}
	}

	private void eAAtgz1F8mO(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!YLGtLvs2lPZ)
		{
			YLGtLvs2lPZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/gestures/manage/subactioneditwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			YLGtLvs2lPZ = true;
			break;
		case 1:
			KeyEditor = (HotkeyEditorControl)target;
			break;
		case 2:
			TxtDescription = (TextBox)target;
			break;
		case 3:
			QuickActionEditor = (QuickActionEditor)target;
			break;
		case 4:
			BtnSave = (Button)target;
			BtnSave.Click += ergtg3htnML;
			break;
		case 5:
		{
			BtnCancel = (Button)target;
			BtnCancel.Click += eAAtgz1F8mO;
			int num = 0;
			if (!y9s2rwQW87cCUdi0d939())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	internal static bool y9s2rwQW87cCUdi0d939()
	{
		return CER7FAQWYsXB87r4xIaF == null;
	}
}
