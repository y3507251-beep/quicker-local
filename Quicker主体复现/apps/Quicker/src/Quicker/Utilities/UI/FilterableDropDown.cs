using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Quicker.Utilities._3rd;

namespace Quicker.Utilities.UI;

[TemplatePart(Name = "PART_SearchTextBox", Type = typeof(TextBox))]
public class FilterableDropDown : ComboBox
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec J5A20wae9VO;

		public static Func<global::_003C_003Ef__AnonymousType3<object, double>, bool> V1720tjYL4l;

		public static Func<global::_003C_003Ef__AnonymousType3<object, double>, double> gA220gLj9pi;

		public static Func<global::_003C_003Ef__AnonymousType3<object, double>, object> r0r20LivxDC;

		internal static _003C_003Ec Coex7CydG6KAoOYQ4oK8;

		static _003C_003Ec()
		{
			J5A20wae9VO = new _003C_003Ec();
		}

		internal bool uQu2J3yuqXP(global::_003C_003Ef__AnonymousType3<object, double> x)
		{
			return x.Score > 0.0;
		}

		internal double Xx12JfIwShQ(global::_003C_003Ef__AnonymousType3<object, double> x)
		{
			return x.Score;
		}

		internal object L5v2Jzcdews(global::_003C_003Ef__AnonymousType3<object, double> x)
		{
			return x.Item;
		}

		internal static bool ntX5nfyd010xDehXNGVJ()
		{
			return Coex7CydG6KAoOYQ4oK8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass10_0
	{
		public FilterableDropDown Scj20SeawqH;

		public string DQh202ecatQ;

		private static _003C_003Ec__DisplayClass10_0 nvWcLjydKErG7f0cHG7H;

		internal global::_003C_003Ef__AnonymousType3<object, double> ygi20vZkiKh(object o)
		{
			return new global::_003C_003Ef__AnonymousType3<object, double>(o, Scj20SeawqH.pOcvtxUSoyX(o, DQh202ecatQ));
		}

		internal static bool zDOFv6ydBbg5lyGQdeua()
		{
			return nvWcLjydKErG7f0cHG7H == null;
		}
	}

	private TextBox emMvtXlNoor;

	private SmartCollection<object> BgHvtmjKknw = new SmartCollection<object>();

	private IList<object> pUTvtKqodtX;

	private Func<object, string, double> pOcvtxUSoyX;

	private static FilterableDropDown fsMn63FCQcU7NDCGYYvj;

	public FilterableDropDown()
	{
		base.ItemsSource = BgHvtmjKknw;
	}

	public void SetData(IList<object> list, Func<object, string, double> filterFunc)
	{
		pUTvtKqodtX = list;
		pOcvtxUSoyX = filterFunc;
		BgHvtmjKknw.Reset(list);
	}

	protected override void OnDropDownOpened(EventArgs e)
	{
		base.OnDropDownOpened(e);
		base.Dispatcher.InvokeAsync(scovt64yl9R, DispatcherPriority.Background);
	}

	public override void OnApplyTemplate()
	{
		if (emMvtXlNoor != null)
		{
			emMvtXlNoor.TextChanged -= pk9vtboGL1M;
			emMvtXlNoor.PreviewKeyDown -= JBHvt1hUrvF;
		}
		base.OnApplyTemplate();
		emMvtXlNoor = GetTemplateChild("PART_SearchTextBox") as TextBox;
		if (emMvtXlNoor != null)
		{
			emMvtXlNoor.TextChanged += pk9vtboGL1M;
			emMvtXlNoor.PreviewKeyDown += JBHvt1hUrvF;
		}
	}

	private void JBHvt1hUrvF(object sender, KeyEventArgs e)
	{
		if (e.Key != Key.Up && e.Key != Key.Down)
		{
			if (e.Key == Key.Escape)
			{
				base.IsDropDownOpen = false;
			}
			return;
		}
		e.Handled = true;
		if (base.SelectedIndex == -1)
		{
			base.SelectedIndex = 0;
		}
		else if (e.Key == Key.Up)
		{
			int num = 0;
			if (fsMn63FCQcU7NDCGYYvj != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (base.SelectedIndex > 0)
			{
				base.SelectedIndex--;
			}
		}
		else if (base.SelectedIndex < base.Items.Count - 1)
		{
			base.SelectedIndex++;
		}
		emMvtXlNoor.Focus();
	}

	private void pk9vtboGL1M(object sender, TextChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
		_003C_003Ec__DisplayClass10_.Scj20SeawqH = this;
		if (pOcvtxUSoyX != null)
		{
			_003C_003Ec__DisplayClass10_.DQh202ecatQ = emMvtXlNoor.Text;
			if (string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass10_.DQh202ecatQ))
			{
				BgHvtmjKknw.Reset(pUTvtKqodtX);
			}
			else
			{
				BgHvtmjKknw.Reset(pUTvtKqodtX.Select(_003C_003Ec__DisplayClass10_.ygi20vZkiKh).Where(_003C_003Ec.V1720tjYL4l ?? (_003C_003Ec.V1720tjYL4l = _003C_003Ec.J5A20wae9VO.uQu2J3yuqXP)).OrderByDescending(_003C_003Ec.gA220gLj9pi ?? (_003C_003Ec.gA220gLj9pi = _003C_003Ec.J5A20wae9VO.Xx12JfIwShQ))
					.Select(_003C_003Ec.r0r20LivxDC ?? (_003C_003Ec.r0r20LivxDC = _003C_003Ec.J5A20wae9VO.L5v2Jzcdews))
					.ToList());
			}
		}
	}

	[CompilerGenerated]
	private void scovt64yl9R()
	{
		emMvtXlNoor.Focus();
	}

	internal static bool oesnrRFCFm6u6JkLsZrY()
	{
		return fsMn63FCQcU7NDCGYYvj == null;
	}
}
