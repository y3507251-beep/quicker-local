using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Utilities.UI;

public class VirtualizingWrapPanel : VirtualizingPanel, IScrollInfo
{
	internal class dlcNU3HdhZJqD6NrdKr
	{
		private uCpGCcHuvsaqx3DHgNQ HAh2Pj7Hicw;

		public readonly int a0T2Pn2N2T6;

		private int DS62P4rr5Fg = -1;

		private int tPP2P5kpyOb = -1;

		internal static dlcNU3HdhZJqD6NrdKr CoKK7uyJ1rUkq4UQrvvl;

		public int Section
		{
			get
			{
				if (tPP2P5kpyOb == -1)
				{
					return a0T2Pn2N2T6 / HAh2Pj7Hicw.RV92PUfaiMe;
				}
				return tPP2P5kpyOb;
			}
			set
			{
				if (tPP2P5kpyOb == -1)
				{
					tPP2P5kpyOb = value;
				}
			}
		}

		public dlcNU3HdhZJqD6NrdKr(uCpGCcHuvsaqx3DHgNQ uCpGCcHuvsaqx3DHgNQ_1, int int_3)
		{
			HAh2Pj7Hicw = uCpGCcHuvsaqx3DHgNQ_1;
			a0T2Pn2N2T6 = int_3;
		}

		[SpecialName]
		public int Xqw2PxEY5qy()
		{
			if (DS62P4rr5Fg == -1)
			{
				return a0T2Pn2N2T6 % HAh2Pj7Hicw.RV92PUfaiMe - 1;
			}
			return DS62P4rr5Fg;
		}

		[SpecialName]
		public void oXv2PrfiSIq(int int_3)
		{
			if (DS62P4rr5Fg == -1)
			{
				DS62P4rr5Fg = int_3;
			}
		}

		internal static bool cdg5yNyJKDlKAusdWt0L()
		{
			return CoKK7uyJ1rUkq4UQrvvl == null;
		}
	}

	[DefaultMember("Item")]
	internal class uCpGCcHuvsaqx3DHgNQ : IEnumerable, IEnumerable<dlcNU3HdhZJqD6NrdKr>
	{
		public readonly int tsX2PFuNTkm;

		public int RV92PUfaiMe;

		private int uhi2PleOdGm = -1;

		private int qZb2Pi4SVIq = -1;

		private int Sdp2P3cwlZd;

		private readonly object E1t2PfHNsiA = new object();

		[CompilerGenerated]
		private ReadOnlyCollection<dlcNU3HdhZJqD6NrdKr> Sgn2PzKHqXC;

		internal static uCpGCcHuvsaqx3DHgNQ L4sKnqyJvtUPSHJeiwTt;

		private ReadOnlyCollection<dlcNU3HdhZJqD6NrdKr> Items
		{
			[CompilerGenerated]
			get
			{
				return Sgn2PzKHqXC;
			}
			[CompilerGenerated]
			set
			{
				Sgn2PzKHqXC = value;
			}
		}

		public uCpGCcHuvsaqx3DHgNQ(int int_5)
		{
			List<dlcNU3HdhZJqD6NrdKr> list = new List<dlcNU3HdhZJqD6NrdKr>(int_5);
			for (int i = 0; i < int_5; i++)
			{
				dlcNU3HdhZJqD6NrdKr item = new dlcNU3HdhZJqD6NrdKr(this, i);
				list.Add(item);
			}
			Items = new ReadOnlyCollection<dlcNU3HdhZJqD6NrdKr>(list);
			RV92PUfaiMe = int_5;
			tsX2PFuNTkm = int_5;
		}

		[SpecialName]
		public int uy02PdmkYDA()
		{
			int num = uhi2PleOdGm + 1;
			if (qZb2Pi4SVIq + 1 < Items.Count)
			{
				int num2 = Items.Count - qZb2Pi4SVIq;
				num += num2 / RV92PUfaiMe + 1;
			}
			return num;
		}

		public void cZQ2PD38D6N(int int_5, int int_6)
		{
			lock (E1t2PfHNsiA)
			{
				if (int_6 > uhi2PleOdGm + 1 || int_5 != qZb2Pi4SVIq + 1)
				{
					return;
				}
				qZb2Pi4SVIq++;
				Items[int_5].Section = int_6;
				if (int_6 == uhi2PleOdGm + 1)
				{
					uhi2PleOdGm = int_6;
					if (int_6 > 0)
					{
						RV92PUfaiMe = int_5 / int_6;
					}
					Sdp2P3cwlZd = 1;
				}
				else
				{
					Sdp2P3cwlZd++;
					int num = 0;
					if (L4sKnqyJvtUPSHJeiwTt != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				Items[int_5].oXv2PrfiSIq(Sdp2P3cwlZd - 1);
			}
		}

		[SpecialName]
		public dlcNU3HdhZJqD6NrdKr BrZ2PAndqXR(int int_5)
		{
			return Items[int_5];
		}

		public IEnumerator<dlcNU3HdhZJqD6NrdKr> GetEnumerator()
		{
			return Items.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal static bool wItR7pyJd0seaPnNCJHd()
		{
			return L4sKnqyJvtUPSHJeiwTt == null;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec P3r2EtPeWsm;

		public static Func<dlcNU3HdhZJqD6NrdKr, int> djo2EggXWDl;

		private static _003C_003Ec d2Z82syJaiuu6nPRgOgL;

		static _003C_003Ec()
		{
			P3r2EtPeWsm = new _003C_003Ec();
		}

		internal int Qs62Ew1Gmie(dlcNU3HdhZJqD6NrdKr x)
		{
			return x.Section;
		}

		internal static bool UF5WiAyJrUVmZBOpu1bW()
		{
			return d2Z82syJaiuu6nPRgOgL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public int JO42Eva3Bud;

		internal static _003C_003Ec__DisplayClass28_0 xjI0RbyJ9hyx8Tv6iOcl;

		internal bool I5C2ELy1eec(dlcNU3HdhZJqD6NrdKr x)
		{
			return x.Section == JO42Eva3Bud;
		}

		internal static bool b7aPyMyJLeFslLYb2RDs()
		{
			return xjI0RbyJ9hyx8Tv6iOcl == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public dlcNU3HdhZJqD6NrdKr E6S2EuQIJPo;

		internal static _003C_003Ec__DisplayClass32_0 XFuoVIyJo2JR0sJ3vjR6;

		internal bool fGK2ESgK6Ji(dlcNU3HdhZJqD6NrdKr x)
		{
			return x.Section == E6S2EuQIJPo.Section + 1;
		}

		internal int ohM2E2W2VRG(dlcNU3HdhZJqD6NrdKr x)
		{
			return Math.Abs(x.Xqw2PxEY5qy() - E6S2EuQIJPo.Xqw2PxEY5qy());
		}

		internal static bool d6s0PeyJfnS7qg3CGpbH()
		{
			return XFuoVIyJo2JR0sJ3vjR6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public dlcNU3HdhZJqD6NrdKr wLu2E0VKEv5;

		private static _003C_003Ec__DisplayClass33_0 BrV1UlyJidJIoE5EtPfP;

		internal bool KCw2ENklF8G(dlcNU3HdhZJqD6NrdKr x)
		{
			return x.Section == wLu2E0VKEv5.Section - 1;
		}

		internal int dW22EJS771V(dlcNU3HdhZJqD6NrdKr x)
		{
			return Math.Abs(x.Xqw2PxEY5qy() - wLu2E0VKEv5.Xqw2PxEY5qy());
		}

		internal static void bBqo0DyJ5MQ7ybNNucco()
		{
		}

		internal static bool JMGx2WyJlTMKnQyigti9()
		{
			return BrV1UlyJidJIoE5EtPfP == null;
		}
	}

	private UIElementCollection N71vSQbJG2y;

	private ItemsControl kG6vSj6N9X1;

	private IItemContainerGenerator wGkvSnySE2q;

	private Point JKcvS4kOF5O = new Point(0.0, 0.0);

	private Size dNVvS5Pr69y = new Size(0.0, 0.0);

	private Size DJLvSDc9dlA = new Size(0.0, 0.0);

	private int KW0vSdjFxSg;

	private Size Cu8vSoI4Xqb;

	private Size E3dvSTsiLUt = new Size(0.0, 0.0);

	private Dictionary<UIElement, Rect> T5YvSMw8vML = new Dictionary<UIElement, Rect>();

	private uCpGCcHuvsaqx3DHgNQ ahavSArbEIY;

	public static readonly DependencyProperty ItemHeightProperty;

	public static readonly DependencyProperty ItemWidthProperty;

	public static readonly DependencyProperty OrientationProperty;

	private bool mLIvSOIb2ZK;

	private bool qFZvSF6aXv9;

	private ScrollViewer YL8vSUrTpsP;

	private static VirtualizingWrapPanel URwjhWFh0ji0FdRY4tTb;

	[TypeConverter(typeof(LengthConverter))]
	public double ItemHeight
	{
		get
		{
			return (double)GetValue(ItemHeightProperty);
		}
		set
		{
			SetValue(ItemHeightProperty, value);
		}
	}

	[TypeConverter(typeof(LengthConverter))]
	public double ItemWidth
	{
		get
		{
			return (double)GetValue(ItemWidthProperty);
		}
		set
		{
			SetValue(ItemWidthProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public bool CanHorizontallyScroll
	{
		get
		{
			return mLIvSOIb2ZK;
		}
		set
		{
			mLIvSOIb2ZK = value;
		}
	}

	public bool CanVerticallyScroll
	{
		get
		{
			return qFZvSF6aXv9;
		}
		set
		{
			qFZvSF6aXv9 = value;
		}
	}

	public double ExtentHeight => dNVvS5Pr69y.Height;

	public double ExtentWidth => dNVvS5Pr69y.Width;

	public double HorizontalOffset => JKcvS4kOF5O.X;

	public double VerticalOffset => JKcvS4kOF5O.Y;

	public ScrollViewer ScrollOwner
	{
		get
		{
			return YL8vSUrTpsP;
		}
		set
		{
			YL8vSUrTpsP = value;
		}
	}

	public double ViewportHeight => DJLvSDc9dlA.Height;

	public double ViewportWidth => DJLvSDc9dlA.Width;

	[SpecialName]
	private Size PM8vSpodfl1()
	{
		return new Size(ItemWidth, ItemHeight);
	}

	public void SetFirstRowViewItemIndex(int index)
	{
		SetVerticalOffset((double)index / Math.Floor(DJLvSDc9dlA.Width / Cu8vSoI4Xqb.Width));
		SetHorizontalOffset((double)index / Math.Floor(DJLvSDc9dlA.Height / Cu8vSoI4Xqb.Height));
	}

	private void Oy1vSspMPEI(object sender, EventArgs e)
	{
		if (DJLvSDc9dlA.Width != 0.0)
		{
			int kW0vSdjFxSg = KW0vSdjFxSg;
			ahavSArbEIY = null;
			MeasureOverride(DJLvSDc9dlA);
			SetFirstRowViewItemIndex(KW0vSdjFxSg);
			KW0vSdjFxSg = kW0vSdjFxSg;
		}
	}

	public int GetFirstVisibleSection()
	{
		int num = ahavSArbEIY.Max(_003C_003Ec.djo2EggXWDl ?? (_003C_003Ec.djo2EggXWDl = _003C_003Ec.P3r2EtPeWsm.Qs62Ew1Gmie));
		int num2 = ((Orientation != Orientation.Horizontal) ? ((int)JKcvS4kOF5O.X) : ((int)JKcvS4kOF5O.Y));
		if (num2 > num)
		{
			num2 = num;
		}
		return num2;
	}

	public int GetFirstVisibleIndex()
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.JO42Eva3Bud = GetFirstVisibleSection();
		return ahavSArbEIY.Where(_003C_003Ec__DisplayClass28_.I5C2ELy1eec).FirstOrDefault()?.a0T2Pn2N2T6 ?? 0;
	}

	private void DDdvSHClQn8(int int_1, int int_2)
	{
		int num4 = default(int);
		for (int num = N71vSQbJG2y.Count - 1; num >= 0; num--)
		{
			GeneratorPosition position = new GeneratorPosition(num, 0);
			int num2 = wGkvSnySE2q.IndexFromGeneratorPosition(position);
			if (num2 < int_1 || num2 > int_2)
			{
				if (num2 >= 0)
				{
					wGkvSnySE2q.Remove(position, 1);
				}
				RemoveInternalChildRange(num, 1);
				int num3 = 0;
				if (!zhWaSyFh17a1rbYCm3D1())
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
		}
	}

	private void I5nvS1Z4t8N(Size size_4, int int_1)
	{
		int num = 1;
		while (true)
		{
			if (Orientation == Orientation.Horizontal)
			{
				int num2 = 0;
				if (!zhWaSyFh17a1rbYCm3D1())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
				DJLvSDc9dlA.Height = int_1;
				DJLvSDc9dlA.Width = size_4.Width;
			}
			else
			{
				DJLvSDc9dlA.Width = int_1;
				DJLvSDc9dlA.Height = size_4.Height;
			}
			break;
		}
		if (Orientation == Orientation.Horizontal)
		{
			dNVvS5Pr69y.Height = (double)ahavSArbEIY.uy02PdmkYDA() + ViewportHeight - 1.0;
		}
		else
		{
			dNVvS5Pr69y.Width = (double)ahavSArbEIY.uy02PdmkYDA() + ViewportWidth - 1.0;
		}
		YL8vSUrTpsP.InvalidateScrollInfo();
	}

	private void aanvSbklIth()
	{
		JKcvS4kOF5O.X = 0.0;
		JKcvS4kOF5O.Y = 0.0;
	}

	private int NcWvS6E8E8N(int int_1)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_.E6S2EuQIJPo = ahavSArbEIY.BrZ2PAndqXR(int_1);
		if (_003C_003Ec__DisplayClass32_.E6S2EuQIJPo.Section < ahavSArbEIY.uy02PdmkYDA() - 1)
		{
			return ahavSArbEIY.Where(_003C_003Ec__DisplayClass32_.fGK2ESgK6Ji).OrderBy(_003C_003Ec__DisplayClass32_.ohM2E2W2VRG).First()
				.a0T2Pn2N2T6;
		}
		return int_1;
	}

	private int ifFvSXsuJjW(int int_1)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.wLu2E0VKEv5 = ahavSArbEIY.BrZ2PAndqXR(int_1);
		if (_003C_003Ec__DisplayClass33_.wLu2E0VKEv5.Section > 0)
		{
			return ahavSArbEIY.Where(_003C_003Ec__DisplayClass33_.KCw2ENklF8G).OrderBy(_003C_003Ec__DisplayClass33_.dW22EJS771V).First()
				.a0T2Pn2N2T6;
		}
		return int_1;
	}

	private void xJ9vSmcNKIm()
	{
		ItemContainerGenerator itemContainerGeneratorForPanel = wGkvSnySE2q.GetItemContainerGeneratorForPanel(this);
		UIElement uIElement = (UIElement)Keyboard.FocusedElement;
		int num = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
		int num2 = 0;
		int num3 = 1;
		if (!zhWaSyFh17a1rbYCm3D1())
		{
			int num4 = default(int);
			num3 = num4;
		}
		int index = default(int);
		DependencyObject dependencyObject;
		switch (num3)
		{
		case 1:
			while (num == -1)
			{
				uIElement = (UIElement)VisualTreeHelper.GetParent(uIElement);
				num = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
				num2++;
			}
			dependencyObject = null;
			if (Orientation == Orientation.Horizontal)
			{
				index = NcWvS6E8E8N(num);
				dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index);
				goto IL_0090;
			}
			if (num == ahavSArbEIY.tsX2PFuNTkm - 1)
			{
				return;
			}
			for (dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num + 1); dependencyObject == null; dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num + 1))
			{
				SetHorizontalOffset(HorizontalOffset + 1.0);
				UpdateLayout();
			}
			break;
		default:
			SetVerticalOffset(VerticalOffset + 1.0);
			UpdateLayout();
			dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index);
			goto IL_0090;
		case 2:
			return;
			IL_0090:
			if (dependencyObject != null)
			{
				break;
			}
			goto default;
		}
		while (num2 != 0)
		{
			dependencyObject = VisualTreeHelper.GetChild(dependencyObject, 0);
			num2--;
		}
		(dependencyObject as UIElement).Focus();
	}

	private void MiTvSKgveds()
	{
		ItemContainerGenerator itemContainerGeneratorForPanel = wGkvSnySE2q.GetItemContainerGeneratorForPanel(this);
		UIElement uIElement = (UIElement)Keyboard.FocusedElement;
		int num = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
		int num2 = 0;
		DependencyObject dependencyObject = default(DependencyObject);
		int num4 = default(int);
		while (true)
		{
			int num3;
			if (num == -1)
			{
				uIElement = (UIElement)VisualTreeHelper.GetParent(uIElement);
				num3 = 0;
				if (zhWaSyFh17a1rbYCm3D1())
				{
					goto IL_008b;
				}
				goto IL_009c;
			}
			dependencyObject = null;
			if (Orientation != Orientation.Vertical)
			{
				if (num != 0)
				{
					dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num - 1);
					goto IL_004a;
				}
				return;
			}
			int index = ifFvSXsuJjW(num);
			for (dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index); dependencyObject == null; dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index))
			{
				SetHorizontalOffset(HorizontalOffset - 1.0);
				UpdateLayout();
			}
			break;
			IL_008b:
			switch (num3)
			{
			case 1:
				break;
			default:
				goto IL_009c;
			case 2:
				continue;
			}
			goto IL_004a;
			IL_004a:
			if (dependencyObject != null)
			{
				break;
			}
			SetVerticalOffset(VerticalOffset - 1.0);
			UpdateLayout();
			dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num - 1);
			num3 = 1;
			if (URwjhWFh0ji0FdRY4tTb != null)
			{
				num3 = num4;
			}
			goto IL_008b;
			IL_009c:
			num = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
			num2++;
		}
		while (num2 != 0)
		{
			dependencyObject = VisualTreeHelper.GetChild(dependencyObject, 0);
			num2--;
		}
		(dependencyObject as UIElement).Focus();
	}

	private void dTHvSxCfPpi()
	{
        int num3 = default;
        DependencyObject dependencyObject = default;
		ItemContainerGenerator itemContainerGeneratorForPanel = wGkvSnySE2q.GetItemContainerGeneratorForPanel(this);
		UIElement uIElement = (UIElement)Keyboard.FocusedElement;
		int num = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
		int num2 = 0;
		if (URwjhWFh0ji0FdRY4tTb == null)
		{
			goto IL_00c1;
		}
		goto IL_0140;
		IL_00c1:
		num3 = 0;
		while (num == -1)
		{
			uIElement = (UIElement)VisualTreeHelper.GetParent(uIElement);
			num = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
			num3++;
		}
		dependencyObject = null;
		if (Orientation == Orientation.Vertical)
		{
			int index = NcWvS6E8E8N(num);
			for (dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index); dependencyObject == null; dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index))
			{
				SetHorizontalOffset(HorizontalOffset + 1.0);
				UpdateLayout();
			}
			goto IL_003a;
		}
		goto IL_006a;
		IL_006a:
		if (num == ahavSArbEIY.tsX2PFuNTkm - 1)
		{
			return;
		}
		for (dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num + 1); dependencyObject == null; dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num + 1))
		{
			SetVerticalOffset(VerticalOffset + 1.0);
			UpdateLayout();
		}
		goto IL_003a;
		IL_0140:
		switch (num2)
		{
		case 2:
			break;
		case 1:
			goto IL_006a;
		default:
			goto IL_00c1;
		}
		goto IL_003a;
		IL_003a:
		if (num3 != 0)
		{
			dependencyObject = VisualTreeHelper.GetChild(dependencyObject, 0);
			num3--;
			num2 = 2;
			if (!zhWaSyFh17a1rbYCm3D1())
			{
				int num4 = default(int);
				num2 = num4;
			}
			goto IL_0140;
		}
		(dependencyObject as UIElement).Focus();
	}

	private void SUGvSrjuZnj()
	{
		int num = 3;
		int num4 = default(int);
		int index = default(int);
		DependencyObject dependencyObject = default(DependencyObject);
		while (true)
		{
			ItemContainerGenerator itemContainerGeneratorForPanel = wGkvSnySE2q.GetItemContainerGeneratorForPanel(this);
			int num2 = 2;
			if (!zhWaSyFh17a1rbYCm3D1())
			{
				goto IL_000e;
			}
			goto IL_00bc;
			IL_00bc:
			switch (num2)
			{
			case 2:
				break;
			case 1:
				goto IL_0096;
			case 3:
				continue;
			default:
				goto end_IL_00d3;
			}
			goto IL_000e;
			IL_000e:
			UIElement uIElement = (UIElement)Keyboard.FocusedElement;
			int num3 = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
			num4 = 0;
			while (num3 == -1)
			{
				uIElement = (UIElement)VisualTreeHelper.GetParent(uIElement);
				num3 = itemContainerGeneratorForPanel.IndexFromContainer(uIElement);
				num4++;
			}
			dependencyObject = null;
			if (Orientation == Orientation.Horizontal)
			{
				index = ifFvSXsuJjW(num3);
				dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index);
				goto IL_00a7;
			}
			if (num3 == 0)
			{
				return;
			}
			for (dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num3 - 1); dependencyObject == null; dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(num3 - 1))
			{
				SetHorizontalOffset(HorizontalOffset - 1.0);
				UpdateLayout();
			}
			break;
			IL_0096:
			UpdateLayout();
			dependencyObject = itemContainerGeneratorForPanel.ContainerFromIndex(index);
			goto IL_00a7;
			IL_00a7:
			if (dependencyObject == null)
			{
				SetVerticalOffset(VerticalOffset - 1.0);
				num2 = 1;
				if (zhWaSyFh17a1rbYCm3D1())
				{
					goto IL_0096;
				}
			}
			else
			{
				num2 = 0;
				if (URwjhWFh0ji0FdRY4tTb != null)
				{
					num2 = num;
				}
			}
			goto IL_00bc;
			continue;
			end_IL_00d3:
			break;
		}
		while (num4 != 0)
		{
			dependencyObject = VisualTreeHelper.GetChild(dependencyObject, 0);
			num4--;
		}
		(dependencyObject as UIElement).Focus();
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		switch (e.Key)
		{
		default:
			base.OnKeyDown(e);
			break;
		case Key.Left:
			MiTvSKgveds();
			e.Handled = true;
			break;
		case Key.Up:
			SUGvSrjuZnj();
			e.Handled = true;
			break;
		case Key.Right:
			dTHvSxCfPpi();
			e.Handled = true;
			if (URwjhWFh0ji0FdRY4tTb != null)
			{
				switch (0)
				{
				}
			}
			break;
		case Key.Down:
			xJ9vSmcNKIm();
			e.Handled = true;
			break;
		}
	}

	protected override void OnItemsChanged(object sender, ItemsChangedEventArgs e)
	{
		base.OnItemsChanged(sender, e);
		ahavSArbEIY = null;
		aanvSbklIth();
	}

	protected override void OnInitialized(EventArgs e)
	{
		base.SizeChanged += Oy1vSspMPEI;
		base.OnInitialized(e);
		kG6vSj6N9X1 = ItemsControl.GetItemsOwner(this);
		N71vSQbJG2y = base.InternalChildren;
		wGkvSnySE2q = base.ItemContainerGenerator;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		if (kG6vSj6N9X1 != null && kG6vSj6N9X1.Items.Count != 0)
		{
			if (ahavSArbEIY == null)
			{
				ahavSArbEIY = new uCpGCcHuvsaqx3DHgNQ(kG6vSj6N9X1.Items.Count);
			}
			E3dvSTsiLUt = availableSize;
			T5YvSMw8vML.Clear();
			Size size = availableSize;
			int count = kG6vSj6N9X1.Items.Count;
			int num = 1;
			if (URwjhWFh0ji0FdRY4tTb != null)
			{
				int num2 = default(int);
				num = num2;
			}
			int firstVisibleIndex = default(int);
			GeneratorPosition position = default(GeneratorPosition);
			int num3;
			while (true)
			{
				switch (num)
				{
				case 1:
					firstVisibleIndex = GetFirstVisibleIndex();
					position = wGkvSnySE2q.GeneratorPositionFromIndex(firstVisibleIndex);
					if (position.Offset != 0)
					{
						num = 0;
						if (zhWaSyFh17a1rbYCm3D1())
						{
							continue;
						}
						goto default;
					}
					num3 = position.Index;
					break;
				default:
					num3 = position.Index + 1;
					break;
				}
				break;
			}
			int num4 = num3;
			int num5 = firstVisibleIndex;
			int num6 = 1;
			using (wGkvSnySE2q.StartAt(position, GeneratorDirection.Forward, true))
			{
        UIElement uIElement = default;
        Rect value = default;
				bool flag = false;
				bool flag2 = Orientation == Orientation.Horizontal;
				double num7 = 0.0;
				double num8 = 0.0;
				double num9 = 0.0;
				int num10 = GetFirstVisibleSection();
				int num11 = 1;
				if (zhWaSyFh17a1rbYCm3D1())
				{
					goto IL_02d9;
				}
				goto IL_02e0;
				IL_02d9:
				uIElement = default(UIElement);
				if (num5 < count)
				{
					uIElement = wGkvSnySE2q.GenerateNext(out var isNewlyRealized) as UIElement;
					if (isNewlyRealized)
					{
						if (num4 >= N71vSQbJG2y.Count)
						{
							AddInternalChild(uIElement);
						}
						else
						{
							InsertInternalChild(num4, uIElement);
						}
						wGkvSnySE2q.PrepareItemContainer(uIElement);
						goto IL_0128;
					}
					goto IL_0135;
				}
				goto end_IL_00dc;
				IL_01b9:
				flag = true;
				goto IL_01bc;
				IL_01bc:
				value = default(Rect);
				num7 = value.Right;
				goto IL_0235;
				IL_0282:
				value = new Rect(new Point(num7, num8), Cu8vSoI4Xqb);
				if (!flag2)
				{
					num9 = Math.Max(num9, value.Width);
					if (value.Bottom > size.Height)
					{
						num7 += num9;
						num8 = 0.0;
						num9 = value.Width;
						value.X = num7;
						value.Y = num8;
						num10++;
						num6++;
					}
					if (num7 > size.Width)
					{
						flag = true;
					}
					num8 = value.Bottom;
					goto IL_0235;
				}
				goto IL_0157;
				IL_0157:
				num9 = Math.Max(num9, value.Height);
				if (value.Right > size.Width)
				{
					num8 += num9;
					num7 = 0.0;
					num9 = value.Height;
					value.X = num7;
					value.Y = num8;
					num10++;
					num6++;
				}
				if (num8 > size.Height)
				{
					goto IL_01b9;
				}
				goto IL_01bc;
				IL_0235:
				T5YvSMw8vML.Add(uIElement, value);
				ahavSArbEIY.cZQ2PD38D6N(num5, num10);
				if (!flag)
				{
					num5++;
					num4++;
					goto IL_02d9;
				}
				goto end_IL_00dc;
				IL_0128:
				uIElement.Measure(PM8vSpodfl1());
				goto IL_0135;
				IL_0135:
				Cu8vSoI4Xqb = uIElement.DesiredSize;
				num11 = 0;
				if (URwjhWFh0ji0FdRY4tTb != null)
				{
					goto IL_0282;
				}
				goto IL_02e0;
				IL_02e0:
				switch (num11)
				{
				case 4:
					break;
				case 2:
					goto IL_0157;
				case 3:
					goto IL_01b9;
				default:
					goto IL_0282;
				case 1:
					goto IL_02d9;
				}
				goto IL_0128;
				end_IL_00dc:;
			}
			DDdvSHClQn8(firstVisibleIndex, num5 - 1);
			I5nvS1Z4t8N(availableSize, num6);
			return availableSize;
		}
		return availableSize;
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		if (N71vSQbJG2y != null)
		{
			foreach (UIElement item in N71vSQbJG2y)
			{
				if (T5YvSMw8vML.ContainsKey(item))
				{
					Rect finalRect = T5YvSMw8vML[item];
					item.Arrange(finalRect);
				}
			}
		}
		return finalSize;
	}

	public void LineDown()
	{
		if (Orientation == Orientation.Vertical)
		{
			SetVerticalOffset(VerticalOffset + 20.0);
		}
		else
		{
			SetVerticalOffset(VerticalOffset + 1.0);
		}
	}

	public void LineLeft()
	{
		if (Orientation == Orientation.Horizontal)
		{
			SetHorizontalOffset(HorizontalOffset - 20.0);
		}
		else
		{
			SetHorizontalOffset(HorizontalOffset - 1.0);
		}
	}

	public void LineRight()
	{
		if (Orientation == Orientation.Horizontal)
		{
			SetHorizontalOffset(HorizontalOffset + 20.0);
		}
		else
		{
			SetHorizontalOffset(HorizontalOffset + 1.0);
		}
	}

	public void LineUp()
	{
		if (Orientation == Orientation.Vertical)
		{
			SetVerticalOffset(VerticalOffset - 20.0);
		}
		else
		{
			SetVerticalOffset(VerticalOffset - 1.0);
		}
	}

	public Rect MakeVisible(Visual visual, Rect rectangle)
	{
		int num = 1;
		Rect result = default(Rect);
		double height = default(double);
		while (true)
		{
			ItemContainerGenerator itemContainerGeneratorForPanel = wGkvSnySE2q.GetItemContainerGeneratorForPanel(this);
			int num2 = 0;
			if (!zhWaSyFh17a1rbYCm3D1())
			{
				num2 = num;
			}
			while (true)
			{
				IL_0085:
				switch (num2)
				{
				default:
				{
					while (true)
					{
						UIElement uIElement = (UIElement)visual;
						int num3;
						for (num3 = itemContainerGeneratorForPanel.IndexFromContainer(uIElement); num3 == -1; num3 = itemContainerGeneratorForPanel.IndexFromContainer(uIElement))
						{
							uIElement = (UIElement)VisualTreeHelper.GetParent(uIElement);
						}
						int num4 = ahavSArbEIY.BrZ2PAndqXR(num3).Section;
						result = T5YvSMw8vML[uIElement];
						if (Orientation != Orientation.Horizontal)
						{
							break;
						}
						height = E3dvSTsiLUt.Height;
						num2 = 2;
						if (URwjhWFh0ji0FdRY4tTb != null)
						{
							continue;
						}
						goto IL_0085;
					}
					double width = E3dvSTsiLUt.Width;
					if (result.Right > width)
					{
						JKcvS4kOF5O.X += 1.0;
					}
					else if (result.Left < 0.0)
					{
						JKcvS4kOF5O.X -= 1.0;
					}
					goto IL_0175;
				}
				case 1:
					break;
				case 2:
					{
						if (result.Bottom > height)
						{
							JKcvS4kOF5O.Y += 1.0;
						}
						else if (result.Top < 0.0)
						{
							JKcvS4kOF5O.Y -= 1.0;
						}
						goto IL_0175;
					}
					IL_0175:
					InvalidateMeasure();
					return result;
				}
				break;
			}
		}
	}

	public void MouseWheelDown()
	{
		PageDown();
	}

	public void MouseWheelLeft()
	{
		PageLeft();
	}

	public void MouseWheelRight()
	{
		PageRight();
	}

	public void MouseWheelUp()
	{
		PageUp();
	}

	public void PageDown()
	{
		SetVerticalOffset(VerticalOffset + DJLvSDc9dlA.Height * 0.8);
	}

	public void PageLeft()
	{
		SetHorizontalOffset(HorizontalOffset - DJLvSDc9dlA.Width * 0.8);
	}

	public void PageRight()
	{
		SetHorizontalOffset(HorizontalOffset + DJLvSDc9dlA.Width * 0.8);
	}

	public void PageUp()
	{
		SetVerticalOffset(VerticalOffset - DJLvSDc9dlA.Height * 0.8);
	}

	public void SetHorizontalOffset(double offset)
	{
		if (!(offset < 0.0) && DJLvSDc9dlA.Width < dNVvS5Pr69y.Width)
		{
			if (offset + DJLvSDc9dlA.Width >= dNVvS5Pr69y.Width)
			{
				offset = dNVvS5Pr69y.Width - DJLvSDc9dlA.Width;
			}
		}
		else
		{
			offset = 0.0;
			int num = 0;
			if (!zhWaSyFh17a1rbYCm3D1())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		JKcvS4kOF5O.X = offset;
		if (YL8vSUrTpsP != null)
		{
			YL8vSUrTpsP.InvalidateScrollInfo();
		}
		InvalidateMeasure();
		KW0vSdjFxSg = GetFirstVisibleIndex();
	}

	public void SetVerticalOffset(double offset)
	{
		if (!(offset < 0.0) && DJLvSDc9dlA.Height < dNVvS5Pr69y.Height)
		{
			if (offset + DJLvSDc9dlA.Height >= dNVvS5Pr69y.Height)
			{
				offset = dNVvS5Pr69y.Height - DJLvSDc9dlA.Height;
			}
		}
		else
		{
			offset = 0.0;
		}
		JKcvS4kOF5O.Y = offset;
		int num = 0;
		if (!zhWaSyFh17a1rbYCm3D1())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (YL8vSUrTpsP != null)
		{
			YL8vSUrTpsP.InvalidateScrollInfo();
		}
		InvalidateMeasure();
		KW0vSdjFxSg = GetFirstVisibleIndex();
	}

	static VirtualizingWrapPanel()
	{
		ItemHeightProperty = DependencyProperty.Register("ItemHeight", typeof(double), typeof(VirtualizingWrapPanel), new FrameworkPropertyMetadata(double.PositiveInfinity));
		ItemWidthProperty = DependencyProperty.Register("ItemWidth", typeof(double), typeof(VirtualizingWrapPanel), new FrameworkPropertyMetadata(double.PositiveInfinity));
		OrientationProperty = StackPanel.OrientationProperty.AddOwner(typeof(global::Quicker.Utilities.UI.VirtualizingWrapPanel), new FrameworkPropertyMetadata(Orientation.Horizontal));
	}

	internal static bool zhWaSyFh17a1rbYCm3D1()
	{
		return URwjhWFh0ji0FdRY4tTb == null;
	}
}
