using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Forms;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View.Forms;

public class FormDesignerWindow : Window, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec H6uSdAnVwN7;

		public static Func<FormField, string> coDSdOkNFvo;

		public static Func<string, bool> rbsSdFMTwvH;

		private static _003C_003Ec zNaBSVWsL87FhweLZcyX;

		static _003C_003Ec()
		{
			H6uSdAnVwN7 = new _003C_003Ec();
		}

		internal string t60SdTpwA7R(FormField x)
		{
			return x.Group;
		}

		internal bool cJCSdMPZVUG(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal static bool aYMHPgWsuT3o6c2rTRfx()
		{
			return zNaBSVWsL87FhweLZcyX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public FormField KVrSdibbLfr;

		internal static _003C_003Ec__DisplayClass23_0 B96TdBWsb9V2c4Rowl0a;

		internal bool uV3SdUL5HVc(FormField x)
		{
			return string.Equals(KVrSdibbLfr.FieldKey, x.FieldKey);
		}

		internal bool iYtSdltmD5J(ActionVariable x)
		{
			return string.Equals(KVrSdibbLfr.FieldKey, x.Key);
		}

		internal static bool SUeRRjWsqoyUjDQZuoVW()
		{
			return B96TdBWsb9V2c4Rowl0a == null;
		}
	}

	private readonly ObservableCollection<ActionVariable> pdmLqBiHEAs;

	private readonly Form rasLqQmwW34;

	private readonly bool nftLqj2y3Lx;

	public ObservableCollection<FormField> _fields = new ObservableCollection<FormField>();

	[CompilerGenerated]
	private Form PW9LqnrEanH;

	internal ListView LvFields;

	internal MenuItem MenuAddToGroup;

	internal Button btnExport;

	internal Button btnPaste;

	internal Button BtnAddSeparator;

	internal Button BtnAddField;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool iD6Lq4O4qEH;

	internal static FormDesignerWindow nDrw2rF1T29oiQWJRyNJ;

	public Form ResultForm
	{
		[CompilerGenerated]
		get
		{
			return PW9LqnrEanH;
		}
		[CompilerGenerated]
		private set
		{
			PW9LqnrEanH = value;
		}
	}

	public FormDesignerWindow(ObservableCollection<ActionVariable> variables, Form editingForm, bool isForDict)
	{
		pdmLqBiHEAs = variables;
		rasLqQmwW34 = editingForm;
		nftLqj2y3Lx = isForDict;
		InitializeComponent();
		LvFields.ItemsSource = _fields;
		base.Loaded += rhILqITtbgX;
		if (isForDict)
		{
			(LvFields.View as GridView).Columns[0].Header = "词典的键名";
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void rhILqITtbgX(object sender, RoutedEventArgs e)
	{
		if (rasLqQmwW34 != null && rasLqQmwW34.Fields.HasData())
		{
			foreach (FormField field in rasLqQmwW34.Fields)
			{
				_fields.Add(field);
			}
		}
		dJcLqWKjLDd();
	}

	private void dJcLqWKjLDd()
	{
		List<string> list = _fields.Select(_003C_003Ec.coDSdOkNFvo ?? (_003C_003Ec.coDSdOkNFvo = _003C_003Ec.H6uSdAnVwN7.t60SdTpwA7R)).Where(_003C_003Ec.rbsSdFMTwvH ?? (_003C_003Ec.rbsSdFMTwvH = _003C_003Ec.H6uSdAnVwN7.cJCSdMPZVUG)).Distinct()
			.ToList();
		MenuAddToGroup.Items.Clear();
		foreach (string item in list)
		{
			AppHelper.AddMenuItem(MenuAddToGroup.Items, item, null, "", S3qLqGCaS2V).Tag = item;
		}
		AppHelper.AddMenuItem(MenuAddToGroup.Items, "新分组...", "添加到一个新的分组", "", j5jLqkDa50n);
	}

	private void j5jLqkDa50n(object sender, RoutedEventArgs e)
	{
		if (LvFields.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选中要修改分组的条目。");
			return;
		}
		UserInputWindow userInputWindow = new UserInputWindow("text", "请输入分组名称", "", "");
		if (userInputWindow.ShowDialog() != true)
		{
			return;
		}
		string textValue = userInputWindow.TextValue;
		IEnumerator<FormField> enumerator = LvFields.SelectedItems.Cast<FormField>().GetEnumerator();
		if (nDrw2rF1T29oiQWJRyNJ != null)
		{
			switch (0)
			{
			}
		}
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.Group = textValue;
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		dJcLqWKjLDd();
	}

	private void S3qLqGCaS2V(object sender, RoutedEventArgs e)
	{
		if (LvFields.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请选中要修改分组的条目。");
			return;
		}
		string text = (sender as MenuItem).Tag as string;
		foreach (FormField item in LvFields.SelectedItems.Cast<FormField>())
		{
			item.Group = text;
		}
		dJcLqWKjLDd();
	}

	private void PtZLqsREDPu(object sender, RoutedEventArgs e)
	{
		FormField formField_ = (sender as Button).Tag as FormField;
		dScLqmrqkPv(formField_);
		dJcLqWKjLDd();
	}

	private void UIuLqHRAJ5J(object sender, RoutedEventArgs e)
	{
		FormField formField = (sender as Button).Tag as FormField;
		if (AppHelper.Confirm("您确认要删除字段 " + formField.Label + "  么？"))
		{
			_fields.Remove(formField);
		}
	}

	private void baeLq1ZXKBD(object sender, RoutedEventArgs e)
	{
		if (nftLqj2y3Lx)
		{
			EditFormFieldWindowForDict editFormFieldWindowForDict = new EditFormFieldWindowForDict(_fields, null)
			{
				Owner = this
			};
			if (editFormFieldWindowForDict.ShowDialog() == true)
			{
				_fields.Add(editFormFieldWindowForDict.ResultField);
			}
		}
		else
		{
			EditFormFieldWindow editFormFieldWindow = new EditFormFieldWindow(pdmLqBiHEAs, _fields, null)
			{
				Owner = this
			};
			if (editFormFieldWindow.ShowDialog() == true)
			{
				_fields.Add(editFormFieldWindow.ResultField);
			}
		}
		dJcLqWKjLDd();
	}

	private void sqlLqbHxB3a(object sender, RoutedEventArgs e)
	{
		ResultForm = new Form
		{
			Fields = _fields.ToList()
		};
		base.DialogResult = true;
	}

	private void lZxLq6lOUV4(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	private void nFNLqX4bTyK(object sender, MouseButtonEventArgs e)
	{
		FormField formField_ = ((ListViewItem)sender).Content as FormField;
		dScLqmrqkPv(formField_);
	}

	private void dScLqmrqkPv(FormField formField_0)
	{
		if (nftLqj2y3Lx)
		{
			EditFormFieldWindowForDict editFormFieldWindowForDict = new EditFormFieldWindowForDict(_fields, formField_0)
			{
				Owner = this
			};
			if (editFormFieldWindowForDict.ShowDialog() != true)
			{
				return;
			}
			int num = _fields.IndexOf(formField_0);
			if (num >= 0)
			{
				_fields.RemoveAt(num);
				_fields.Insert(num, editFormFieldWindowForDict.ResultField);
				return;
			}
			AppHelper.ShowWarning("数据不正确，请反馈。");
			if (nDrw2rF1T29oiQWJRyNJ == null)
			{
				switch (0)
				{
				}
			}
			return;
		}
		EditFormFieldWindow editFormFieldWindow = new EditFormFieldWindow(pdmLqBiHEAs, _fields, formField_0)
		{
			Owner = this
		};
		if (editFormFieldWindow.ShowDialog() == true)
		{
			int num2 = _fields.IndexOf(formField_0);
			if (num2 >= 0)
			{
				_fields.RemoveAt(num2);
				_fields.Insert(num2, editFormFieldWindow.ResultField);
			}
			else
			{
				AppHelper.ShowWarning("数据不正确，请反馈。");
			}
		}
	}

	private void bBVLqKkQMy0(object sender, RoutedEventArgs e)
	{
		_fields.Add(new FormField
		{
			InputMethod = Quicker.Public.Forms.InputMethod.Separator,
			Label = "分割线"
		});
	}

	private void RqKLqxj8IpO(object sender, RoutedEventArgs e)
	{
		if (LvFields.SelectedItems.Count > 0)
		{
			AppHelper.TryCopy(LvFields.SelectedItems.Cast<FormField>().ToList().ToJson(true), true);
		}
		else
		{
			AppHelper.TryCopy(_fields.ToJson(true), true);
		}
	}

	private void crWLqrJiVYC(object sender, RoutedEventArgs e)
	{
		try
		{
			List<FormField> list = JsonConvert.DeserializeObject<List<FormField>>(ClipboardHelper2.GetUnicodeText());
			if (list == null)
			{
				if (nDrw2rF1T29oiQWJRyNJ != null)
				{
					switch (0)
					{
					}
				}
				AppHelper.ShowWarning("剪贴板中的数据不是有效的Json格式。");
				return;
			}
			if (list.Count == 0)
			{
				AppHelper.ShowWarning("解析到的数据为空，请确认复制的数据格式合法。");
				return;
			}
			using (List<FormField>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					_003C_003Ec__DisplayClass23_.KVrSdibbLfr = enumerator.Current;
					if (_003C_003Ec__DisplayClass23_.KVrSdibbLfr.InputMethod == Quicker.Public.Forms.InputMethod.Separator)
					{
						continue;
					}
					if (!_fields.Any(_003C_003Ec__DisplayClass23_.uV3SdUL5HVc))
					{
						if (!nftLqj2y3Lx && !pdmLqBiHEAs.Any(_003C_003Ec__DisplayClass23_.iYtSdltmD5J))
						{
							AppHelper.ShowWarning("变量不存在：" + _003C_003Ec__DisplayClass23_.KVrSdibbLfr.FieldKey + "。");
							return;
						}
						continue;
					}
					if (!oxj3DmF1mL7uA1KO21ny())
					{
						switch (0)
						{
						}
					}
					AppHelper.ShowWarning("存在重复的字段：" + _003C_003Ec__DisplayClass23_.KVrSdibbLfr.FieldKey + "。");
					return;
				}
			}
			foreach (FormField item in list)
			{
				_fields.Add(item);
			}
			AppHelper.ShowSuccess($"共粘贴了{list.Count}个字段。");
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("出错了：" + ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!iD6Lq4O4qEH)
		{
			iD6Lq4O4qEH = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/formdesignerwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			LvFields = (ListView)target;
			if (oxj3DmF1mL7uA1KO21ny())
			{
				switch (0)
				{
				}
			}
			break;
		case 2:
			MenuAddToGroup = (MenuItem)target;
			break;
		default:
			iD6Lq4O4qEH = true;
			break;
		case 6:
			btnExport = (Button)target;
			btnExport.Click += RqKLqxj8IpO;
			break;
		case 7:
			btnPaste = (Button)target;
			btnPaste.Click += crWLqrJiVYC;
			break;
		case 8:
			BtnAddSeparator = (Button)target;
			BtnAddSeparator.Click += bBVLqKkQMy0;
			break;
		case 9:
			BtnAddField = (Button)target;
			BtnAddField.Click += baeLq1ZXKBD;
			break;
		case 10:
			BtnSave = (Button)target;
			BtnSave.Click += sqlLqbHxB3a;
			break;
		case 11:
			BtnCancel = (Button)target;
			BtnCancel.Click += lZxLq6lOUV4;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 3:
			((Button)target).Click += PtZLqsREDPu;
			break;
		case 4:
			((Button)target).Click += UIuLqHRAJ5J;
			break;
		case 5:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(nFNLqX4bTyK);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		}
	}

	internal static bool oxj3DmF1mL7uA1KO21ny()
	{
		return nDrw2rF1T29oiQWJRyNJ == null;
	}
}
