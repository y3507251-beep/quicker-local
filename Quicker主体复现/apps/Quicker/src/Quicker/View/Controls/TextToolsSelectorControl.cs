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
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Modules.TextTools;
using Quicker.Public.Extensions;

namespace Quicker.View.Controls;

public class TextToolsSelectorControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ir8Si0S4KtT;

		public static Func<TextToolType, bool> xIwSiC28016;

		public static Func<TextToolType, SelectionItem> lxWSiPkxlS7;

		public static Func<SelectionItem, string> QsUSiEP52cV;

		internal static _003C_003Ec R9oPVxyWHAS7BdfKD00s;

		static _003C_003Ec()
		{
			Ir8Si0S4KtT = new _003C_003Ec();
		}

		internal bool Mb5Siu85DOl(TextToolType x)
		{
			if (x != TextToolType.Na && TextToolsProvider.IsToolSupported(x))
			{
				return true;
			}
			return x == TextToolType.ExtraSelectMenu;
		}

		internal SelectionItem DbPSiNomDIS(TextToolType x)
		{
			return new SelectionItem(x.ToString(), x.GetEnumDisplayName());
		}

		internal string xqkSiJbtNY0(SelectionItem x)
		{
			return x.Value;
		}

		internal static void kNPG4tyyQ4u9WGDsoCdU()
		{
		}

		internal static bool bDP3kByWzAWgmlY799EB()
		{
			return R9oPVxyWHAS7BdfKD00s == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public string T2WSi8UWAr4;

		internal static _003C_003Ec__DisplayClass2_0 xDnhJiyyFvXGtVAfA5fQ;

		internal bool i6WSiyM2M2t(SelectionItem x)
		{
			return x.Value == T2WSi8UWAr4;
		}

		internal static bool SYpFTcyycVTMk0kLKWUy()
		{
			return xDnhJiyyFvXGtVAfA5fQ == null;
		}
	}

	private IList<SelectionItem> jP2LpLxa7mT;

	internal CheckComboBox ChkTextTools;

	private bool DAjLpvbbFS1;

	private static TextToolsSelectorControl NyvhiCFoMMuyfm0CUYa0;

	public TextToolsSelectorControl()
	{
		InitializeComponent();
		jP2LpLxa7mT = Enum.GetValues(typeof(TextToolType)).Cast<TextToolType>().Where(_003C_003Ec.xIwSiC28016 ?? (_003C_003Ec.xIwSiC28016 = _003C_003Ec.Ir8Si0S4KtT.Mb5Siu85DOl))
			.Select(_003C_003Ec.lxWSiPkxlS7 ?? (_003C_003Ec.lxWSiPkxlS7 = _003C_003Ec.Ir8Si0S4KtT.DbPSiNomDIS))
			.ToList();
		ChkTextTools.ItemsSource = jP2LpLxa7mT;
	}

	public void SetSelectedToolsString(string tools)
	{
		if (string.IsNullOrEmpty(tools))
		{
			return;
		}
		string[] array = tools.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			_003C_003Ec__DisplayClass2_.T2WSi8UWAr4 = array[i];
			SelectionItem selectionItem = jP2LpLxa7mT.FirstOrDefault(_003C_003Ec__DisplayClass2_.i6WSiyM2M2t);
			if (selectionItem == null)
			{
				continue;
			}
			ChkTextTools.SelectedItems.Add(selectionItem);
			if (pk101AFoUX1uKAOu8yNO())
			{
				switch (0)
				{
				}
			}
		}
	}

	public string GetSelectedToolsString()
	{
		return string.Join(",", ChkTextTools.SelectedItems.Cast<SelectionItem>().Select(_003C_003Ec.QsUSiEP52cV ?? (_003C_003Ec.QsUSiEP52cV = _003C_003Ec.Ir8Si0S4KtT.xqkSiJbtNY0)));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!DAjLpvbbFS1)
		{
			DAjLpvbbFS1 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/texttoolsselectorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			ChkTextTools = (CheckComboBox)target;
		}
		else
		{
			DAjLpvbbFS1 = true;
		}
	}

	internal static bool pk101AFoUX1uKAOu8yNO()
	{
		return NyvhiCFoMMuyfm0CUYa0 == null;
	}
}
