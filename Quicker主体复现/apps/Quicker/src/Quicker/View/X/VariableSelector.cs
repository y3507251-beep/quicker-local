using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using DotNetKit.Windows.Controls;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.View.X;

public class VariableSelector : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec r3VSO2NJ5qY;

		public static Func<ActionVariable, string> ciZSOuFI9DP;

		internal static _003C_003Ec Ex81BhWzJHEG3UDQWpd6;

		static _003C_003Ec()
		{
			r3VSO2NJ5qY = new _003C_003Ec();
		}

		internal string JuHSOSnLRBP(ActionVariable x)
		{
			return x.Group + x.Key;
		}

		internal static void dL1dpRWzrWs1ybnLorpj()
		{
		}

		internal static bool bOgPS3WzkmpnojkwS2j2()
		{
			return Ex81BhWzJHEG3UDQWpd6 == null;
		}
	}

	private readonly ObservableCollection<ActionVariable> gslLGIdsgHo;

	private readonly VarType DRWLGWwENyi;

	private readonly string AmeLGkFFvwW;

	private readonly bool SKgLGGEsdPD;

	private readonly IEnumerable<VarType> o17LGsfw25Q;

	private readonly IEnumerable<string> JP1LGHOhtU5;

	private readonly bool ymXLG1a8rDh;

	private readonly string B2JLGbB6YWr;

	private readonly string ie9LG6GacgX;

	private readonly ObservableCollection<ActionVariable> JPbLGXBkTTc = new ObservableCollection<ActionVariable>();

	[CompilerGenerated]
	private EventHandler m_SelectionChanged;

	private readonly ActionVariable basLGmfOIRG = new ActionVariable
	{
		Key = null,
		Type = VarType.NA,
		Desc = "-"
	};

	private string doULGKJjVI0 = "";

	internal AutoCompleteComboBox CbVariables;

	internal StackPanel PnlKey;

	internal TextBlock LblKey;

	internal TextBox TxtKey;

	private bool jtpLGxTStJI;

	private static VariableSelector NI4o85FkgumP17TQk92P;

	public event EventHandler SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_SelectionChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_SelectionChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public VariableSelector(ObservableCollection<ActionVariable> variables, VarType paramVarType, string currentVarKey, bool allowCreateField = true, IEnumerable<VarType> allowedVarTypes = null, IEnumerable<string> hideFieldKeys = null, bool isSubProgram = false, bool isForOutput = true, string paramName = "", string paramDesc = "")
	{
		gslLGIdsgHo = variables;
		DRWLGWwENyi = paramVarType;
		AmeLGkFFvwW = currentVarKey;
		SKgLGGEsdPD = allowCreateField;
		o17LGsfw25Q = allowedVarTypes;
		JP1LGHOhtU5 = hideFieldKeys;
		ymXLG1a8rDh = isSubProgram;
		B2JLGbB6YWr = paramName;
		ie9LG6GacgX = paramDesc;
		InitializeComponent();
		qcsLGc84FXE();
		gslLGIdsgHo.CollectionChanged += eLILGRY4oPe;
		base.Unloaded += rXYLGq1CYkH;
	}

	private void eLILGRY4oPe(object sender, NotifyCollectionChangedEventArgs e)
	{
		qcsLGc84FXE();
	}

	private void rXYLGq1CYkH(object sender, RoutedEventArgs e)
	{
		gslLGIdsgHo.CollectionChanged -= eLILGRY4oPe;
	}

	private void qcsLGc84FXE()
	{
		int num = 2;
		string text = default(string);
		while (true)
		{
			object selectedItem = CbVariables.SelectedItem;
			int num2 = 1;
			if (NI4o85FkgumP17TQk92P != null)
			{
				goto IL_0145;
			}
			goto IL_0146;
			IL_0146:
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = TxtKey.Text;
					JPbLGXBkTTc.Clear();
					JPbLGXBkTTc.Add(basLGmfOIRG);
					foreach (ActionVariable item2 in gslLGIdsgHo.OrderBy(_003C_003Ec.ciZSOuFI9DP ?? (_003C_003Ec.ciZSOuFI9DP = _003C_003Ec.r3VSO2NJ5qY.JuHSOSnLRBP)))
					{
						if (o17LGsfw25Q != null)
						{
							if (Y8LeLcFkPqkoBV9iQfe8())
							{
								switch (0)
								{
								}
							}
							IEnumerable<VarType> enumerable = o17LGsfw25Q;
							if (enumerable == null || !enumerable.Contains(item2.Type))
							{
								continue;
							}
						}
						if (JP1LGHOhtU5 == null || !JP1LGHOhtU5.Contains(item2.Key))
						{
							JPbLGXBkTTc.Add(item2);
						}
					}
					if (SKgLGGEsdPD)
					{
						ActionVariable item = new ActionVariable
						{
							Key = "",
							Type = VarType.CreateVar,
							Desc = "创建变量..."
						};
						JPbLGXBkTTc.Insert(1, item);
					}
					CbVariables.ItemsSource = JPbLGXBkTTc;
					if (selectedItem == null)
					{
						ActionVariable actionVariable = JPbLGXBkTTc.FirstOrDefault(bOwLGYQq40T);
						if (actionVariable != null && AmeLGkFFvwW != null && AmeLGkFFvwW.StartsWith(actionVariable.Key + "."))
						{
							TxtKey.Text = AmeLGkFFvwW.Substring(actionVariable.Key.Length + 1);
						}
						else
						{
							TxtKey.Text = "";
						}
						CbVariables.SelectedItem = actionVariable ?? basLGmfOIRG;
						MxKLGVbKQJ1();
						return;
					}
					goto IL_0138;
				case 2:
					break;
				default:
					CbVariables.SelectedItem = selectedItem;
					if (!string.IsNullOrEmpty(text))
					{
						TxtKey.Text = text;
					}
					return;
				}
				break;
				IL_0138:
				num2 = 0;
				if (Y8LeLcFkPqkoBV9iQfe8())
				{
					continue;
				}
				goto IL_0145;
			}
			continue;
			IL_0145:
			num2 = num;
			goto IL_0146;
		}
	}

	public string GetSelectedVariableKey()
	{
		ActionVariable actionVariable = CbVariables.SelectedItem as ActionVariable;
		if (actionVariable != null && actionVariable.Type == VarType.CreateVar)
		{
			if (NI4o85FkgumP17TQk92P != null)
			{
				switch (0)
				{
				}
			}
			return null;
		}
		string text = actionVariable?.Key;
		if (actionVariable != null && actionVariable.Type == VarType.Dict && PnlKey.IsVisible && !string.IsNullOrEmpty(TxtKey.Text))
		{
			return text + "." + TxtKey.Text;
		}
		return text;
	}

	public ActionVariable GetSelectedVariable()
	{
		ActionVariable actionVariable = CbVariables.SelectedItem as ActionVariable;
		if (actionVariable != null && actionVariable.Type == VarType.CreateVar)
		{
			return null;
		}
		return actionVariable;
	}

	private void CbVariables_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (CbVariables.SelectedIndex < 0)
		{
			CbVariables.SelectedIndex = 0;
			return;
		}
		if (!(CbVariables.SelectedItem is ActionVariable actionVariable))
		{
			this.m_SelectionChanged?.Invoke(this, EventArgs.Empty);
			return;
		}
		if (actionVariable.Type == VarType.CreateVar)
		{
			ActionVariable actionVariable2 = XActionUiHelper.CreateVariable(Window.GetWindow(this), gslLGIdsgHo, DRWLGWwENyi, ymXLG1a8rDh, B2JLGbB6YWr, ie9LG6GacgX, true, true);
			int num = 0;
			if (!Y8LeLcFkPqkoBV9iQfe8())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (actionVariable2 != null)
			{
				CbVariables.SelectedItem = actionVariable2;
			}
			else
			{
				CbVariables.SelectedItem = basLGmfOIRG;
			}
		}
		else
		{
			this.m_SelectionChanged?.Invoke(this, EventArgs.Empty);
		}
		doULGKJjVI0 = "";
		MxKLGVbKQJ1();
	}

	private void MxKLGVbKQJ1()
	{
		if (CbVariables.SelectedItem is ActionVariable { Type: VarType.Dict })
		{
			PnlKey.Visibility = Visibility.Visible;
			return;
		}
		PnlKey.Visibility = Visibility.Collapsed;
		TxtKey.Text = "";
	}

	private void Fj6LGZr6gBa(object sender, KeyEventArgs e)
	{
	}

	private void qKpLG91b9xI(object sender, KeyEventArgs e)
	{
	}

	private void z6kLGhVUEys(object sender, RoutedEventArgs e)
	{
	}

	private void sPTLGeHOtCL(object sender, EventArgs e)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!jtpLGxTStJI)
		{
			jtpLGxTStJI = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/variableselector.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			jtpLGxTStJI = true;
			break;
		case 1:
			CbVariables = (AutoCompleteComboBox)target;
			break;
		case 2:
			PnlKey = (StackPanel)target;
			break;
		case 3:
			LblKey = (TextBlock)target;
			break;
		case 4:
			TxtKey = (TextBox)target;
			break;
		}
	}

	[CompilerGenerated]
	private bool bOwLGYQq40T(ActionVariable actionVariable_1)
	{
		if (!(actionVariable_1.Key == AmeLGkFFvwW) && !AmeLGkFFvwW.StartsWith(actionVariable_1.Key + "."))
		{
			return false;
		}
		return actionVariable_1.Type != VarType.CreateVar;
	}

	internal static bool Y8LeLcFkPqkoBV9iQfe8()
	{
		return NI4o85FkgumP17TQk92P == null;
	}
}
