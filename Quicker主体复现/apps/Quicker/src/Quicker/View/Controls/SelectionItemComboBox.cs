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
using Quicker.Domain.Actions.X.StepRunners;

namespace Quicker.View.Controls;

public class SelectionItemComboBox : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public string bYFSi2y8byr;

		private static _003C_003Ec__DisplayClass6_0 TT5hlZyWtqDtnF8dAPkP;

		internal bool vv9SiSrk8CI(SelectionItem x)
		{
			return x.Value == bYFSi2y8byr;
		}

		static _003C_003Ec__DisplayClass6_0()
		{
		}

		internal static bool Gf9mYGyWS1V03YU1SnWj()
		{
			return TT5hlZyWtqDtnF8dAPkP == null;
		}

		internal static void kVICC7yWT0SZF0VrCELm()
		{
		}
	}

	private IList<SelectionItem> nySLx3yfwQF;

	internal ComboBox TheComboBox;

	private bool CDMLxfm4QXb;

	internal static SelectionItemComboBox pR2eT5FoBFJ3yXe0EJp9;

	public IList<SelectionItem> ItemSource
	{
		set
		{
			TheComboBox.ItemsSource = value;
			nySLx3yfwQF = value;
		}
	}

	public string SelectedValue
	{
		get
		{
			if (TheComboBox.SelectedItem != null)
			{
				return ((SelectionItem)TheComboBox.SelectionBoxItem).Value;
			}
			return null;
		}
		set
		{
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
			_003C_003Ec__DisplayClass6_.bYFSi2y8byr = value;
			if (nySLx3yfwQF != null)
			{
				SelectionItem selectionItem = nySLx3yfwQF.FirstOrDefault(_003C_003Ec__DisplayClass6_.vv9SiSrk8CI);
				if (selectionItem != null)
				{
					TheComboBox.SelectedItem = selectionItem;
				}
				else
				{
					TheComboBox.SelectedItem = null;
				}
			}
			else
			{
				TheComboBox.SelectedItem = null;
			}
		}
	}

	public SelectionItemComboBox()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!CDMLxfm4QXb)
		{
			CDMLxfm4QXb = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/selectionitemcombobox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TheComboBox = (ComboBox)target;
		}
		else
		{
			CDMLxfm4QXb = true;
		}
	}

	internal static bool BEYrU4FovU3tQHOc334w()
	{
		return pR2eT5FoBFJ3yXe0EJp9 == null;
	}
}
