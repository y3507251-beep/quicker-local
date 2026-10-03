using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.View.X.Controls.ParamEditors;
using Quicker.View.X.StepEditor.ParamEditors;

namespace Quicker.View.X.Nodes;

public class InputParamEditorControl : Control
{
	private ObservableCollection<ActionVariable> I7iLHlV1WTH;

	private StepInParamDef wCFLHiuOIOX;

	private ActionStepParam UreLH3hhHcE;

	[CompilerGenerated]
	private EventHandler m_ValueChanged;

	[CompilerGenerated]
	private ContentControl D44LHfo9LKI;

	[CompilerGenerated]
	private TextBlock xnYLHz7ehXX;

	[CompilerGenerated]
	private Grid VypL1wLxJYi;

	internal static InputParamEditorControl yPEZL6FrONqBpOffp82J;

	public StepInParamDef ParamDef => wCFLHiuOIOX;

	private ContentControl Wrapper
	{
		[CompilerGenerated]
		get
		{
			return D44LHfo9LKI;
		}
		[CompilerGenerated]
		set
		{
			D44LHfo9LKI = value;
		}
	}

	private Grid BodyGrid
	{
		[CompilerGenerated]
		get
		{
			return VypL1wLxJYi;
		}
		[CompilerGenerated]
		set
		{
			VypL1wLxJYi = value;
		}
	}

	protected override int VisualChildrenCount => 1;

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_ValueChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_ValueChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public InputParamEditorControl(ObservableCollection<ActionVariable> variables, StepInParamDef paramDef, ActionStepParam paramData)
	{
		I7iLHlV1WTH = variables;
		wCFLHiuOIOX = paramDef;
		UreLH3hhHcE = paramData;
		l1cLHQFCWCL();
		bcYLHrp0jV6();
		Ay1LHnXxeo9();
		base.Unloaded += q0FLHpMBaTk;
		base.Focusable = false;
	}

	[SpecialName]
	[CompilerGenerated]
	private TextBlock sXcLHM0GBxm()
	{
		return xnYLHz7ehXX;
	}

	[SpecialName]
	[CompilerGenerated]
	private void DW6LHAsEJK7(TextBlock value)
	{
		xnYLHz7ehXX = value;
	}

	private void bcYLHrp0jV6()
	{
		Grid grid = new Grid
		{
			Margin = new Thickness(0.0, 0.0, 0.0, 10.0),
			Focusable = false
		};
		BodyGrid = grid;
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(120.0)
		});
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(10.0)
		});
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Star)
		});
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(40.0)
		});
		if (wCFLHiuOIOX.Type != VarType.Boolean || wCFLHiuOIOX.VariableMode != ParamVariableMode.Input)
		{
			TextBlock label = new TextBlock
			{
				Margin = new Thickness(5.0),
				HorizontalAlignment = HorizontalAlignment.Right,
				TextWrapping = TextWrapping.Wrap,
				Text = wCFLHiuOIOX.Name
			};
			DW6LHAsEJK7(label);
			Grid.SetColumn(label, 0);
			label.PreviewMouseDown += I4YLHB3IRsc;
			grid.Children.Add(label);
		}

		StackPanel stackPanel = new StackPanel { Focusable = false };
		Grid.SetColumn(stackPanel, 2);
		Wrapper = new ContentControl();
		stackPanel.Children.Add(Wrapper);
		grid.Children.Add(stackPanel);

		if (!string.IsNullOrEmpty(wCFLHiuOIOX.Description))
		{
			if (AppState.HHxtaMaoqJr().ShowParamDescAsToolTip)
			{
				Button button = new Button
				{
					Margin = new Thickness(0.0, 4.0, 0.0, 0.0),
					Style = TryFindResource("HintQuestionStyle") as Style,
					ToolTip = wCFLHiuOIOX.Description
				};
				Grid.SetColumn(button, 3);
				grid.Children.Add(button);
			}
			else
			{
				// 说明和输入控件共用同一个已创建的容器。
				stackPanel.Children.Add(new TextBlock
				{
					Style = TryFindResource("HelpText") as Style,
					Text = wCFLHiuOIOX.Description
				});
			}
		}

		AddVisualChild(grid);
	}

	protected override Visual GetVisualChild(int index)
	{
		if (index != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return BodyGrid;
	}

	private void q0FLHpMBaTk(object sender, RoutedEventArgs e)
	{
		base.Unloaded -= q0FLHpMBaTk;
		if (Wrapper.Content is IBaseParamEditor baseParamEditor)
		{
			try
			{
				baseParamEditor.ValueChanged -= nk6LH4H41LP;
			}
			catch (Exception)
			{
			}
		}
	}

	private void I4YLHB3IRsc(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2 && Wrapper.Content is VarAndValueParamEditor varAndValueParamEditor)
		{
			e.Handled = true;
			varAndValueParamEditor.TriggerCreateVariable();
		}
	}

	private void l1cLHQFCWCL()
	{
		if (UreLH3hhHcE == null)
		{
			if (wCFLHiuOIOX.DefaultValue != null)
			{
				UreLH3hhHcE = new ActionStepParam
				{
					Value = xPFLHdVrhxi()
				};
			}
			else
			{
				UreLH3hhHcE = new ActionStepParam();
			}
		}
	}

	private string jBjLHjdDhfG()
	{
		if (AppState.HHxtaMaoqJr().ShowParamDescAsToolTip)
		{
			return wCFLHiuOIOX.Description.Or(wCFLHiuOIOX.Name);
		}
		return null;
	}

	private void Ay1LHnXxeo9()
	{
		BooleanParamEditor booleanParamEditor = default(BooleanParamEditor);
		int num;
		FormParamEditor content2 = default(FormParamEditor);
		if (wCFLHiuOIOX.Type == VarType.Boolean && wCFLHiuOIOX.VariableMode == ParamVariableMode.Input)
		{
			booleanParamEditor = new BooleanParamEditor(wCFLHiuOIOX, UreLH3hhHcE);
			num = 2;
			if (yPEZL6FrONqBpOffp82J != null)
			{
				goto IL_01cd;
			}
		}
		else
		{
			if (wCFLHiuOIOX.Type == VarType.Form)
			{
				FormParamEditor content = new FormParamEditor(wCFLHiuOIOX, UreLH3hhHcE, false);
				Wrapper.Content = content;
				return;
			}
			if (wCFLHiuOIOX.Type == VarType.FormForDict)
			{
				content2 = new FormParamEditor(wCFLHiuOIOX, UreLH3hhHcE, true);
				num = 1;
				if (yPEZL6FrONqBpOffp82J != null)
				{
					goto IL_01cd;
				}
			}
			else
			{
				if (wCFLHiuOIOX.Type == VarType.Enum && wCFLHiuOIOX.VariableMode == ParamVariableMode.Input)
				{
					EnumParamEditor enumParamEditor = new EnumParamEditor(wCFLHiuOIOX, UreLH3hhHcE);
					Wrapper.Content = enumParamEditor;
					enumParamEditor.ValueChanged += nk6LH4H41LP;
					enumParamEditor.ToolTip = jBjLHjdDhfG();
					return;
				}
				if (wCFLHiuOIOX.VariableMode == ParamVariableMode.UseVarOnly && string.IsNullOrEmpty(UreLH3hhHcE.Value))
				{
					VariableParamSelector variableParamSelector = new VariableParamSelector(I7iLHlV1WTH, wCFLHiuOIOX, UreLH3hhHcE);
					Wrapper.Content = variableParamSelector;
					variableParamSelector.ToolTip = jBjLHjdDhfG();
					return;
				}
				if (!wCFLHiuOIOX.Key.Equals("texttools", StringComparison.OrdinalIgnoreCase))
				{
					VarAndValueParamEditor varAndValueParamEditor = new VarAndValueParamEditor(I7iLHlV1WTH, wCFLHiuOIOX, UreLH3hhHcE);
					Wrapper.Content = varAndValueParamEditor;
					varAndValueParamEditor.ValueChanged += nk6LH4H41LP;
					return;
				}
				TextToolsParamEditor textToolsParamEditor = new TextToolsParamEditor(I7iLHlV1WTH, wCFLHiuOIOX, UreLH3hhHcE);
				Wrapper.Content = textToolsParamEditor;
				textToolsParamEditor.ToolTip = jBjLHjdDhfG();
				num = 0;
				if (!c40oj2FrJSHrTDhjlF4o())
				{
					int num2 = default(int);
					num = num2;
				}
			}
		}
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 2:
			Wrapper.Content = booleanParamEditor;
			booleanParamEditor.ToolTip = jBjLHjdDhfG();
			return;
		}
		goto IL_01cd;
		IL_01cd:
		Wrapper.Content = content2;
	}

	private void nk6LH4H41LP(object sender, EventArgs e)
	{
		IBaseParamEditor obj = sender as IBaseParamEditor;
		StepInParamDef paramDef = obj.ParamDef;
		ActionStepParam paramValue = obj.GetParamValue();
		this.m_ValueChanged?.Invoke(this, new ValueChangedEventArgs
		{
			NewValue = paramValue.Value
		});
	}

	private void TqVLH5YOZd8(StepInParamDef stepInParamDef_1, ActionStepParam actionStepParam_1)
	{
		ParamValueDisplay paramValueDisplay = new ParamValueDisplay(stepInParamDef_1, actionStepParam_1, I7iLHlV1WTH);
		paramValueDisplay.MouseLeftButtonDown += GGWLHDQCsmN;
		Wrapper.Content = paramValueDisplay;
	}

	private void GGWLHDQCsmN(object sender, MouseButtonEventArgs e)
	{
		if (Wrapper.Content is ParamValueDisplay paramValueDisplay)
		{
			paramValueDisplay.MouseLeftButtonDown -= GGWLHDQCsmN;
			((ActionStepEditorWindow)Window.GetWindow(this)).CloseAllParamEditors();
			VarAndValueParamEditor content = new VarAndValueParamEditor(((ActionStepEditorWindow)Window.GetWindow(this)).Variables, wCFLHiuOIOX, UreLH3hhHcE);
			Wrapper.Content = content;
		}
	}

	public void CloseEditor()
	{
		if (Wrapper.Content is VarAndValueParamEditor varAndValueParamEditor)
		{
			UreLH3hhHcE = varAndValueParamEditor.GetParamValue();
			TqVLH5YOZd8(wCFLHiuOIOX, UreLH3hhHcE);
		}
	}

	public ActionStepParam GetParamValue()
	{
		if (Wrapper.Content is IBaseParamEditor baseParamEditor)
		{
			return baseParamEditor.GetParamValue();
		}
		return UreLH3hhHcE;
	}

	[CompilerGenerated]
	private string xPFLHdVrhxi()
	{
		if (wCFLHiuOIOX.DefaultValue == null)
		{
			return string.Empty;
		}
		if (wCFLHiuOIOX.DefaultValue is bool)
		{
			return wCFLHiuOIOX.DefaultValue.ToString().ToLower(CultureInfo.InvariantCulture);
		}
		return Convert.ToString(wCFLHiuOIOX.DefaultValue, CultureInfo.InvariantCulture);
	}

	internal static bool c40oj2FrJSHrTDhjlF4o()
	{
		return yPEZL6FrONqBpOffp82J == null;
	}
}
