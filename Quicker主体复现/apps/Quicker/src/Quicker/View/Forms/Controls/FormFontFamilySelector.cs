using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;
using Quicker.Utilities;

namespace Quicker.View.Forms.Controls;

public class FormFontFamilySelector : BaseFormFieldControl, IComponentConnector, IFormControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec kkpSoHOw2Ry;

		public static Func<string, string> uxvSo1nT7Lt;

		private static _003C_003Ec ciyilbWCXkco9ZleBbHL;

		static _003C_003Ec()
		{
			kkpSoHOw2Ry = new _003C_003Ec();
		}

		internal string YBaSosmbwOA(string x)
		{
			return x;
		}

		internal static bool KJobiNWC2xslctYqDSYR()
		{
			return ciyilbWCXkco9ZleBbHL == null;
		}
	}

	private static readonly ILog kBnLcF2DJul;

	private IList<string> XAhLcUGJwre = new List<string>();

	private FormField ppuLclCcqdW;

	private bool HJfLciD0Twi;

	internal ComboBox CbValue;

	private bool OjSLc379dUC;

	private static FormFontFamilySelector t4Rs4NFKwG34fYHo6KJr;

	public FormFontFamilySelector()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		ppuLclCcqdW = field;
		if (XAhLcUGJwre.Count == 0)
		{
			try
			{
				XmlLanguage language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name);
				foreach (FontFamily systemFontFamily in Fonts.SystemFontFamilies)
				{
					string item = systemFontFamily.Source;
					if (systemFontFamily.FamilyNames.ContainsKey(language))
					{
						item = systemFontFamily.FamilyNames[language];
					}
					XAhLcUGJwre.Add(item);
				}
				XAhLcUGJwre = XAhLcUGJwre.OrderBy(_003C_003Ec.uxvSo1nT7Lt ?? (_003C_003Ec.uxvSo1nT7Lt = _003C_003Ec.kkpSoHOw2Ry.YBaSosmbwOA)).ToList();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("枚举系统字体异常：" + ex.Message);
			}
			CbValue.ItemsSource = XAhLcUGJwre;
			int num = 0;
			if (t4Rs4NFKwG34fYHo6KJr != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		object value = (context.IsVarExists(field.FieldKey) ? context.GetVarValue(field.FieldKey) : "");
		UpdateValue(value);
		HJfLciD0Twi = true;
	}

	public object GetInputValue()
	{
		return CbValue.Text;
	}

	public (bool isValid, string message) Validate()
	{
		if (ppuLclCcqdW.IsRequired && string.IsNullOrEmpty(GetInputValue() as string))
		{
			return (isValid: false, message: "请选择选项。");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		CbValue.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return CbValue;
	}

	public void SetInputWidth(double width)
	{
		CbValue.HorizontalAlignment = HorizontalAlignment.Left;
		CbValue.Width = width;
	}

	public void UpdateValue(object value)
	{
		CbValue.Text = Convert.ToString(value);
	}

	public void SetReadOnly(bool isReadOnly)
	{
		CbValue.IsReadOnly = isReadOnly;
	}

	private void CbValue_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (HJfLciD0Twi)
		{
			TriggerValueChange(ppuLclCcqdW);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!OjSLc379dUC)
		{
			OjSLc379dUC = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formfontfamilyselector.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			CbValue = (ComboBox)target;
			CbValue.SelectionChanged += CbValue_OnSelectionChanged;
		}
		else
		{
			OjSLc379dUC = true;
		}
	}

	static FormFontFamilySelector()
	{
		kBnLcF2DJul = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool Q6cu85FKTFVKxDnHT8MT()
	{
		return t4Rs4NFKwG34fYHo6KJr == null;
	}

	internal static void HwcbLxFK4RrfK71ZMu3W()
	{
	}
}
