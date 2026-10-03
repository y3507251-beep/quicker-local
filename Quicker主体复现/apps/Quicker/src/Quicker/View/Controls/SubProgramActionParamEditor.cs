using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Domain.Actions.SubPrograms;

namespace Quicker.View.Controls;

public class SubProgramActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ph5S3ZjgJG0;

		public static Func<OldSubProgram, bool> AXQS39JRqFs;

		private static _003C_003Ec IJADnTyX2g2KrT8Cp1tn;

		static _003C_003Ec()
		{
			Ph5S3ZjgJG0 = new _003C_003Ec();
		}

		internal bool QsaS3VL23Da(OldSubProgram x)
		{
			return !x.HideInList;
		}

		internal static bool tPUOCkyXAhfiRcxmSdjh()
		{
			return IJADnTyX2g2KrT8Cp1tn == null;
		}
	}

	private ActionItem mTwLnIJj1kd;

	private bool JMVLnWVwAXk = true;

	internal ComboBox CbSubPrograms;

	internal TextBlock LblParam;

	internal StackPanel PnlParam;

	internal TextBox TxtParams;

	internal TextBlock LblParamDesc;

	private bool UKoLnkgp521;

	internal static SubProgramActionParamEditor zhsm8uFqzQs2gENSjauX;

	public SubProgramActionParamEditor()
	{
		InitializeComponent();
		base.Loaded += YFDLnhTxQaS;
		CbSubPrograms.ItemsSource = OldSubProgramMgr.AllSubPrograms.Where(_003C_003Ec.AXQS39JRqFs ?? (_003C_003Ec.AXQS39JRqFs = _003C_003Ec.Ph5S3ZjgJG0.QsaS3VL23Da));
	}

	private void YFDLnhTxQaS(object sender, RoutedEventArgs e)
	{
	}

	public override void SetData(ActionItem actionItem)
	{
		JMVLnWVwAXk = true;
		mTwLnIJj1kd = actionItem;
		if (actionItem != null && !string.IsNullOrEmpty(actionItem.Data))
		{
			OldSubProgram subProgram = OldSubProgramMgr.GetSubProgram(actionItem.Data);
			if (subProgram != null)
			{
				CbSubPrograms.SelectedItem = subProgram;
			}
			TxtParams.Text = actionItem.Data2;
		}
		JMVLnWVwAXk = false;
		int num = 0;
		if (!LmRR1SFiVgOCSwAxQopH())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public override void SaveData(ActionItem actionItem)
	{
		if (CbSubPrograms.SelectedItem == null)
		{
			actionItem.Data = "";
			return;
		}
		OldSubProgram oldSubProgram = CbSubPrograms.SelectedItem as OldSubProgram;
		actionItem.Data = oldSubProgram.Key;
		actionItem.Data2 = TxtParams.Text;
	}

	private void QJRLneT094v(object sender, SelectionChangedEventArgs e)
	{
		if (CbSubPrograms.SelectedItem != null)
		{
			OldSubProgram oldSubProgram = CbSubPrograms.SelectedItem as OldSubProgram;
			if (!JMVLnWVwAXk)
			{
				mTwLnIJj1kd.Title = oldSubProgram.Name;
				int num = 0;
				if (!LmRR1SFiVgOCSwAxQopH())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				mTwLnIJj1kd.Data = oldSubProgram.Key;
			}
			if (oldSubProgram.ShowParamInput)
			{
				LblParam.Visibility = Visibility.Visible;
				PnlParam.Visibility = Visibility.Visible;
				LblParam.Text = (string.IsNullOrEmpty(oldSubProgram.ParamName) ? "子程序参数" : oldSubProgram.ParamName);
				TxtParams.Text = oldSubProgram.DefaultParamData;
				LblParamDesc.Text = oldSubProgram.ParamDescription;
			}
			else
			{
				LblParam.Visibility = Visibility.Collapsed;
				PnlParam.Visibility = Visibility.Collapsed;
			}
			OnDataChanged();
		}
		JMVLnWVwAXk = false;
	}

	public override Task StartInputAsync(ActionType? newActionType)
	{
		base.Dispatcher.Invoke(LyILnYHIEE2);
		return Task.CompletedTask;
	}

	public override (bool isSuccess, string message) Validate()
	{
		if (CbSubPrograms.SelectedItem is OldSubProgram { ValidateParamFunc: not null } oldSubProgram)
		{
			return oldSubProgram.ValidateParamFunc(TxtParams.Text);
		}
		return (isSuccess: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!UKoLnkgp521)
		{
			UKoLnkgp521 = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/subprogramactionparameditor.xaml", UriKind.Relative);
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
			UKoLnkgp521 = true;
			break;
		case 1:
		{
			CbSubPrograms = (ComboBox)target;
			int num = 0;
			if (zhsm8uFqzQs2gENSjauX != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				CbSubPrograms.SelectionChanged += QJRLneT094v;
				break;
			}
			break;
		}
		case 2:
			LblParam = (TextBlock)target;
			break;
		case 3:
			PnlParam = (StackPanel)target;
			break;
		case 4:
			TxtParams = (TextBox)target;
			break;
		case 5:
			LblParamDesc = (TextBlock)target;
			break;
		}
	}

	[CompilerGenerated]
	private void LyILnYHIEE2()
	{
		CbSubPrograms.IsDropDownOpen = true;
	}

	internal static bool LmRR1SFiVgOCSwAxQopH()
	{
		return zhsm8uFqzQs2gENSjauX == null;
	}
}
