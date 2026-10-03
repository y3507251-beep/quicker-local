using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Public.Extensions;

namespace Quicker.View.Controls;

public class DictEditorControl : UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec K6RSl4mC1LV;

		public static Func<KeyValuePair, bool> G3uSl5uepgh;

		public static Func<KeyValuePair, string> mJuSlDsRZYJ;

		public static Func<KeyValuePair, string> vkESldWevTy;

		internal static _003C_003Ec nq7hwSyWkgFAN5O8NyRc;

		static _003C_003Ec()
		{
			K6RSl4mC1LV = new _003C_003Ec();
		}

		internal bool EcsSlQj957T(KeyValuePair x)
		{
			if (string.IsNullOrEmpty(x.Key))
			{
				return !string.IsNullOrEmpty(x.Value);
			}
			return true;
		}

		internal string tZSSlj7pLy4(KeyValuePair x)
		{
			return x.Key;
		}

		internal string OnDSlnjLPJI(KeyValuePair x)
		{
			return x.Value;
		}

		internal static bool UYWS40yWa7BPxludYGBh()
		{
			return nq7hwSyWkgFAN5O8NyRc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public IEnumerable<string> mqNSlT45dI8;

		private static _003C_003Ec__DisplayClass10_0 yywuP2yWNAmCOvUQaqVK;

		internal bool tokSloJr9dU(KeyValuePair pair)
		{
			if (pair.Value.IsNullOrEmpty())
			{
				return !mqNSlT45dI8.Contains(pair.Key);
			}
			return false;
		}

		internal static bool fFHJwpyW9jkSQrmWrwx9()
		{
			return yywuP2yWNAmCOvUQaqVK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_1
	{
		public string xsjSlA8l8L2;

		internal static _003C_003Ec__DisplayClass10_1 kEuveLyWuWr0ZydER40M;

		internal bool hULSlMkG7Tx(KeyValuePair x)
		{
			return x.Key == xsjSlA8l8L2;
		}

		internal static bool nvVhEyyWo0Fk1RSLo1b8()
		{
			return kEuveLyWuWr0ZydER40M == null;
		}
	}

	[CompilerGenerated]
	private ObservableCollection<KeyValuePair> rWOLKTddLTd = new ObservableCollection<KeyValuePair>();

	internal ListView lvKeyValue;

	private bool z40LKMEMbAu;

	internal static DictEditorControl ASMrdTFuvx1qiLCL1Hv4;

	public Dictionary<string, string> Data
	{
		get
		{
			return OblLKDiyMDy().Where(_003C_003Ec.G3uSl5uepgh ?? (_003C_003Ec.G3uSl5uepgh = _003C_003Ec.K6RSl4mC1LV.EcsSlQj957T)).ToDictionary(_003C_003Ec.mJuSlDsRZYJ ?? (_003C_003Ec.mJuSlDsRZYJ = _003C_003Ec.K6RSl4mC1LV.tZSSlj7pLy4), _003C_003Ec.vkESldWevTy ?? (_003C_003Ec.vkESldWevTy = _003C_003Ec.K6RSl4mC1LV.OnDSlnjLPJI));
		}
		set
		{
			OblLKDiyMDy().Clear();
			if (value == null)
			{
				return;
			}
			foreach (KeyValuePair<string, string> item in value)
			{
				OblLKDiyMDy().Add(new KeyValuePair
				{
					Key = item.Key,
					Value = item.Value
				});
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private ObservableCollection<KeyValuePair> OblLKDiyMDy()
	{
		return rWOLKTddLTd;
	}

	[SpecialName]
	[CompilerGenerated]
	private void tnOLKdAkvFS(ObservableCollection<KeyValuePair> value)
	{
		rWOLKTddLTd = value;
	}

	public DictEditorControl()
	{
		InitializeComponent();
		lvKeyValue.ItemsSource = OblLKDiyMDy();
	}

	private void IjWLK4PIEsW(object sender, RoutedEventArgs e)
	{
		OblLKDiyMDy().Add(new KeyValuePair
		{
			Key = "",
			Value = ""
		});
	}

	private void K2lLK5mgbce(object sender, RoutedEventArgs e)
	{
		if ((sender as Button).Tag is KeyValuePair item)
		{
			OblLKDiyMDy().Remove(item);
		}
	}

	public void UpdateKeys(IEnumerable<string> keys)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.mqNSlT45dI8 = keys;
		foreach (KeyValuePair item in OblLKDiyMDy().Where(_003C_003Ec__DisplayClass10_.tokSloJr9dU).ToList())
		{
			OblLKDiyMDy().Remove(item);
		}
		using IEnumerator<string> enumerator2 = _003C_003Ec__DisplayClass10_.mqNSlT45dI8.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_1();
			_003C_003Ec__DisplayClass10_2.xsjSlA8l8L2 = enumerator2.Current;
			if (!OblLKDiyMDy().Any(_003C_003Ec__DisplayClass10_2.hULSlMkG7Tx))
			{
				OblLKDiyMDy().Add(new KeyValuePair
				{
					Key = _003C_003Ec__DisplayClass10_2.xsjSlA8l8L2,
					Value = ""
				});
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!z40LKMEMbAu)
		{
			z40LKMEMbAu = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/dicteditorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			z40LKMEMbAu = true;
			break;
		case 3:
			((Button)target).Click += IjWLK4PIEsW;
			break;
		case 1:
			lvKeyValue = (ListView)target;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			((Button)target).Click += K2lLK5mgbce;
		}
	}

	internal static bool O3PQdvFudtIF9maLnmK8()
	{
		return ASMrdTFuvx1qiLCL1Hv4 == null;
	}
}
