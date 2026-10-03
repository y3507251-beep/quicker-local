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
using HandyControl.Controls;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.View.Forms.Controls;

public class FormCheckComboBoxControl : BaseFormFieldControl, IComponentConnector, IFormControl, IUpdatableFieldControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec StnSom0cKL9;

		public static Func<SimpleOperationItem, string> aIqSoKfVYrX;

		public static Func<SimpleOperationItem, string> z54SoxDQY9d;

		public static Func<SimpleOperationItem, string> gU2SorQmxxr;

		private static _003C_003Ec GPdQMtWCnrXdacYjtIvU;

		static _003C_003Ec()
		{
			StnSom0cKL9 = new _003C_003Ec();
		}

		internal string ux6Sobf7dYM(SimpleOperationItem x)
		{
			return x.Key;
		}

		internal string WpRSo6IZ18b(SimpleOperationItem x)
		{
			return x.Key;
		}

		internal string Fo6SoXHic8i(SimpleOperationItem x)
		{
			return x.Key;
		}

		internal static bool KtVcGYWCeM1NxVjt4PCV()
		{
			return GPdQMtWCnrXdacYjtIvU == null;
		}

		internal static void ULdhRwWCDuoW1iIgRw0w()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public string oL6SoBSpoYj;

		private static _003C_003Ec__DisplayClass6_0 M3KYhpWC3gmFqUu9CkNr;

		internal bool uyMSopPAVW6(SimpleOperationItem x)
		{
			return x.Key == oL6SoBSpoYj;
		}

		internal static bool VyCWUcWCEFKxh38mycu4()
		{
			return M3KYhpWC3gmFqUu9CkNr == null;
		}
	}

	private SmartCollection<SimpleOperationItem> u4eLVCqsff1 = new SmartCollection<SimpleOperationItem>();

	private FormField dtILVPpayM8;

	private ActionVariable mNOLVEx1IdW;

	internal CheckComboBox TheCheckComboBox;

	private bool YyTLVyFsPVZ;

	private static FormCheckComboBoxControl lmc82iFB3suELQxlirQP;

	public FormCheckComboBoxControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		dtILVPpayM8 = field;
		mNOLVEx1IdW = variable;
		string text = field.SelectionItems;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (lmc82iFB3suELQxlirQP != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text);
		}
		PdULVNxvBhF(text);
		TheCheckComboBox.ItemsSource = u4eLVCqsff1;
		object currValue = (context.IsVarExists(field.FieldKey) ? context.GetVarValue(field.FieldKey) : null);
		UpdateValue(currValue);
		if (field.IsRequired)
		{
			InfoElement.SetNecessary(TheCheckComboBox, true);
		}
	}

	private void PdULVNxvBhF(string string_0)
	{
		u4eLVCqsff1.Reset(AppHelper.StringToOperationItems(string_0, true));
	}

	private void J3ULVJD7a2y(IEnumerable<string> ienumerable_0)
	{
		TheCheckComboBox.SelectedItems.Clear();
		using IEnumerator<string> enumerator = ienumerable_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
			_003C_003Ec__DisplayClass6_.oL6SoBSpoYj = enumerator.Current;
			SimpleOperationItem simpleOperationItem = u4eLVCqsff1.FirstOrDefault(_003C_003Ec__DisplayClass6_.uyMSopPAVW6);
			if (simpleOperationItem != null)
			{
				TheCheckComboBox.SelectedItems.Add(simpleOperationItem);
			}
		}
	}

	public object GetInputValue()
	{
		if (mNOLVEx1IdW.Type == VarType.Text)
		{
			return string.Join(";", TheCheckComboBox.SelectedItems.Cast<SimpleOperationItem>().Select(_003C_003Ec.aIqSoKfVYrX ?? (_003C_003Ec.aIqSoKfVYrX = _003C_003Ec.StnSom0cKL9.ux6Sobf7dYM)));
		}
		return TheCheckComboBox.SelectedItems.Cast<SimpleOperationItem>().Select(_003C_003Ec.z54SoxDQY9d ?? (_003C_003Ec.z54SoxDQY9d = _003C_003Ec.StnSom0cKL9.WpRSo6IZ18b)).ToList();
	}

	public (bool isValid, string message) Validate()
	{
		if (dtILVPpayM8.IsRequired && TheCheckComboBox.SelectedItems.Count == 0)
		{
			return (isValid: false, message: "请选择选项。");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		TheCheckComboBox.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return TheCheckComboBox;
	}

	public void SetInputWidth(double width)
	{
		TheCheckComboBox.HorizontalAlignment = HorizontalAlignment.Left;
		TheCheckComboBox.Width = width;
	}

	public void UpdateValue(object currValue)
	{
		if (mNOLVEx1IdW.Type == VarType.Text)
		{
			if (currValue == null)
			{
				return;
			}
			string[] ienumerable_ = Convert.ToString(currValue).Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			if (lmc82iFB3suELQxlirQP == null)
			{
				switch (0)
				{
				}
			}
			J3ULVJD7a2y(ienumerable_);
			return;
		}
		if (mNOLVEx1IdW.Type == VarType.List)
		{
			if (currValue == null)
			{
				return;
			}
			if (currValue.IsList())
			{
				IList<string> list = currValue as IList<string>;
				if (list.HasData())
				{
					J3ULVJD7a2y(list);
				}
			}
			else
			{
				List<string> list2 = VariableHelper.ConvertToList(currValue)?.ToList();
				if (list2 != null)
				{
					J3ULVJD7a2y(list2);
				}
				else
				{
					AppHelper.ShowWarning($"无法加载数据项 {mNOLVEx1IdW.Key}, 不支持的类型({currValue.GetType()})。");
				}
			}
			return;
		}
		throw new InvalidOperationException("(多选列表)不支持的变量类型。" + mNOLVEx1IdW.Type);
	}

	public void SetReadOnly(bool isReadOnly)
	{
		TheCheckComboBox.IsEnabled = !isReadOnly;
	}

	private void hxCLV0MELcZ(object sender, SelectionChangedEventArgs e)
	{
		TriggerValueChange(dtILVPpayM8);
	}

	public bool IsShouldUpdate()
	{
		if (dtILVPpayM8.SelectionItems != null && dtILVPpayM8.SelectionItems.StartsWithAny(false, "$=", "$$"))
		{
			return dtILVPpayM8.ExtraSettings.HasLineStartWith("refresh_items");
		}
		return false;
	}

	public void Update(IVariableContext context)
	{
		if (!IsShouldUpdate())
		{
			return;
		}
		List<string> list = TheCheckComboBox.SelectedItems.Cast<SimpleOperationItem>().Select(_003C_003Ec.gU2SorQmxxr ?? (_003C_003Ec.gU2SorQmxxr = _003C_003Ec.StnSom0cKL9.Fo6SoXHic8i)).ToList();
		string text = dtILVPpayM8.SelectionItems;
		int num = 0;
		if (lmc82iFB3suELQxlirQP != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!string.IsNullOrEmpty(text))
		{
			text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text);
		}
		PdULVNxvBhF(text);
		TheCheckComboBox.ItemsSource = u4eLVCqsff1;
		if (list.HasData())
		{
			J3ULVJD7a2y(list);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!YyTLVyFsPVZ)
		{
			YyTLVyFsPVZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formcheckcomboboxcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TheCheckComboBox = (CheckComboBox)target;
			TheCheckComboBox.SelectionChanged += hxCLV0MELcZ;
		}
		else
		{
			YyTLVyFsPVZ = true;
		}
	}

	internal static bool grnNojFBEfoXGURxZZuW()
	{
		return lmc82iFB3suELQxlirQP == null;
	}
}
