using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities._3rd;

namespace Quicker.View.ProfileManagement;

public class ProfileExeSelectorControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec a1JSjkwXBda;

		public static Func<ExeInfo, string> fV8SjGZgk3D;

		internal static _003C_003Ec QkFqpNWICDJW15RYDtCf;

		static _003C_003Ec()
		{
			a1JSjkwXBda = new _003C_003Ec();
		}

		internal string fAGSjWqXZY8(ExeInfo x)
		{
			return x.Name;
		}

		internal static bool BPqN2PWI72kvTHTaep9m()
		{
			return QkFqpNWICDJW15RYDtCf == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string xBsSjHDYSN4;

		private static _003C_003Ec__DisplayClass3_0 SKixGZWIh5oXL0XSpetO;

		internal bool dOGSjs3DcLe(ExeInfo x)
		{
			return x.Exe == xBsSjHDYSN4;
		}

		internal static bool daB3blWIHKNr8NJsh6JJ()
		{
			return SKixGZWIh5oXL0XSpetO == null;
		}
	}

	private SmartCollection<ExeInfo> v6BLu0wEk7M;

	internal ComboBox CbExeList;

	private bool ouALuCd4nd0;

	private static ProfileExeSelectorControl n4Kj1KFjBfqTYBy2RlwB;

	public string Exe
	{
		get
		{
			if (CbExeList.SelectedItem != null)
			{
				return (CbExeList.SelectedItem as ExeInfo)?.Exe;
			}
			return "";
		}
		set
		{
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			_003C_003Ec__DisplayClass3_.xBsSjHDYSN4 = value;
			ExeInfo exeInfo = v6BLu0wEk7M.FirstOrDefault(_003C_003Ec__DisplayClass3_.dOGSjs3DcLe);
			if (exeInfo != null)
			{
				CbExeList.SelectedItem = exeInfo;
			}
		}
	}

	public ProfileExeSelectorControl()
	{
		InitializeComponent();
		r7wLuJBFPEw();
	}

	private void r7wLuJBFPEw()
	{
		v6BLu0wEk7M = new SmartCollection<ExeInfo>();
		IOrderedEnumerable<ExeInfo> range = AppState.DataService.Vo4tXXBRrsb(true).OrderBy(_003C_003Ec.fV8SjGZgk3D ?? (_003C_003Ec.fV8SjGZgk3D = _003C_003Ec.a1JSjkwXBda.fAGSjWqXZY8));
		v6BLu0wEk7M.Reset(range);
		CbExeList.ItemsSource = v6BLu0wEk7M;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ouALuCd4nd0)
		{
			ouALuCd4nd0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/profileexeselectorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			CbExeList = (ComboBox)target;
		}
		else
		{
			ouALuCd4nd0 = true;
		}
	}

	internal static bool D61OfoFjvmBNJFLe0MEw()
	{
		return n4Kj1KFjBfqTYBy2RlwB == null;
	}
}
