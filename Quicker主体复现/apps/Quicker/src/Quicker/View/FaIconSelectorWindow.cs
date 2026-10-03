using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using FontAwesome5;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Annotations;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class FaIconSelectorWindow : Window, IComponentConnector, INotifyPropertyChanged, IStyleConnector
{
	[CompilerGenerated]
	private List<EFontAwesomeIcon> kl2gjxr5Aea;

	[CompilerGenerated]
	private string ODSgjrqaAas = "#FF686868";

	[CompilerGenerated]
	private string rX1gjpHfriE = "#FFFFFFFF";

	private ICollectionView r1LgjBMd3QV;

	[CompilerGenerated]
	private EFontAwesomeIcon EC3gjQJdmm3;

	private DebounceTimer ahlgjjDB7CV = new DebounceTimer();

	private Point KNrgjnDJTt7 = new Point(0.0, 0.0);

	private object P8Bgj4HmQDX;

	private string JnOgj5Yakwl = "#000000";

	private string HEGgjD64khZ = "#FFFFFFFF";

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal FaIconSelectorWindow TheWindow;

	internal ComboBox CbFaIconStyle;

	internal TextBox TxtFilter;

	internal Button BtnSearch;

	internal Button BtnUseDarkgray;

	internal Button BtnWeb;

	internal ListBox FaIconList;

	internal StackPanel PnlProInfo;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool fdugjdhphIa;

	private static FaIconSelectorWindow waGDnJFVXTpXhgQcSIST;

	public IList<SelectionItem> FaIconStyles => new List<SelectionItem>
	{
		new SelectionItem("", "--风格--"),
		new SelectionItem("Light", "细"),
		new SelectionItem("Regular", "普通"),
		new SelectionItem("Solid", "实心"),
		new SelectionItem("Brand", "商标")
	};

	public string IconColor
	{
		get
		{
			return JnOgj5Yakwl;
		}
		set
		{
			JnOgj5Yakwl = value;
			OnPropertyChanged("IconColor");
		}
	}

	public string ButtonColor
	{
		get
		{
			return HEGgjD64khZ;
		}
		set
		{
			HEGgjD64khZ = value;
			OnPropertyChanged("ButtonColor");
		}
	}

	public string LabelColor
	{
		[CompilerGenerated]
		get
		{
			return ODSgjrqaAas;
		}
		[CompilerGenerated]
		set
		{
			ODSgjrqaAas = value;
		}
	}

	public string PanelColor
	{
		[CompilerGenerated]
		get
		{
			return rX1gjpHfriE;
		}
		[CompilerGenerated]
		set
		{
			rX1gjpHfriE = value;
		}
	}

	public EFontAwesomeIcon SelectedIcon
	{
		[CompilerGenerated]
		get
		{
			return EC3gjQJdmm3;
		}
		[CompilerGenerated]
		set
		{
			EC3gjQJdmm3 = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private List<EFontAwesomeIcon> jb9gjXMdvwy()
	{
		return kl2gjxr5Aea;
	}

	[SpecialName]
	[CompilerGenerated]
	private void E45gjmDRoXW(List<EFontAwesomeIcon> value)
	{
		kl2gjxr5Aea = value;
	}

	public FaIconSelectorWindow()
	{
		InitializeComponent();
		CbFaIconStyle.ItemsSource = FaIconStyles;
		CbFaIconStyle.SelectedIndex = 1;
		base.Loaded += GpDgjcN5uwt;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void GpDgjcN5uwt(object sender, RoutedEventArgs e)
	{
		E45gjmDRoXW(Enum.GetValues(typeof(EFontAwesomeIcon)).Cast<EFontAwesomeIcon>().ToList());
		r1LgjBMd3QV = CollectionViewSource.GetDefaultView(jb9gjXMdvwy());
		r1LgjBMd3QV.Filter = KApgjVsN5Zh;
		FaIconList.ItemsSource = r1LgjBMd3QV;
		if (!this.IL8vudVpbi3())
		{
			BtnOk.Visibility = Visibility.Collapsed;
		}
		TxtFilter.Focus();
	}

	private bool KApgjVsN5Zh(object object_1)
	{
		string text = (object_1 as EFontAwesomeIcon?).ToString();
		if (text == "None")
		{
			return false;
		}
		string text2 = TxtFilter.Text;
		string value = (CbFaIconStyle.SelectedItem as SelectionItem).Value;
		if (!string.IsNullOrEmpty(value) && !text.StartsWith(value, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(text2))
		{
			return text.IndexOf(text2, StringComparison.OrdinalIgnoreCase) >= ((!string.IsNullOrEmpty(value)) ? value.Length : 0);
		}
		return true;
	}

	private void u7wgjZVvjXU(object sender, SelectionChangedEventArgs e)
	{
		if (jb9gjXMdvwy() != null)
		{
			pcTgjhCjlCZ();
		}
	}

	private void HALgj92foEJ(object sender, RoutedEventArgs e)
	{
		pcTgjhCjlCZ();
	}

	private void pcTgjhCjlCZ()
	{
		r1LgjBMd3QV.Refresh();
		if (FaIconList.Items.Count > 0)
		{
			FaIconList.ScrollIntoView(FaIconList.Items[0]);
		}
	}

	private void CTigjehdl4J(object sender, RoutedEventArgs e)
	{
		SelectedIcon = (FaIconList.SelectedItem as EFontAwesomeIcon?).GetValueOrDefault();
		if (this.IL8vudVpbi3())
		{
			base.DialogResult = true;
		}
		else
		{
			Close();
		}
	}

	private void ndpgjYbTHRR(object sender, TextChangedEventArgs e)
	{
		ahlgjjDB7CV.Debounce(300, mDNgjb9EAUy);
	}

	private void aTegjIWhVlj(object sender, MouseButtonEventArgs e)
	{
		KNrgjnDJTt7 = e.GetPosition(null);
		P8Bgj4HmQDX = sender;
	}

	private void WL2gjWMCMdr(object sender, MouseEventArgs e)
	{
		int num = 1;
		while (true)
		{
			Point position = e.GetPosition(null);
			int num2 = 0;
			if (!FRIRdMFV2oJdlIvyyRnU())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			Vector vector = KNrgjnDJTt7 - position;
			if (e.LeftButton == MouseButtonState.Pressed && P8Bgj4HmQDX == sender && (Math.Abs(vector.X) > SystemParameters.MinimumHorizontalDragDistance || Math.Abs(vector.Y) > SystemParameters.MinimumVerticalDragDistance) && sender is FrameworkElement frameworkElement)
			{
				DataObject data = new DataObject("FA_ICON", frameworkElement.Tag.ToString());
				AppHelper.DoDragDropWrap(frameworkElement, data, DragDropEffects.Copy);
			}
			return;
		}
	}

	private void XhQgjkaUUlD(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void mTugjGbBAAY(object sender, RoutedEventArgs e)
	{
		IconColor = "#666666";
		ButtonColor = "#FFFFFF";
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	private void pmCgjsAgaOI(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://fontawesome.com/icons");
	}

	private void vjlgjHGRDTO(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount >= 2 && FaIconList.SelectedItem != null)
		{
			BtnOk.TiggerClick();
			e.Handled = true;
		}
	}

	private void OHjgj1IxBIv(object sender, RoutedEventArgs e)
	{
		ClipboardHelper.SetText((sender as MenuItem).Tag.ToString());
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!fdugjdhphIa)
		{
			fdugjdhphIa = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/settings/faiconselectorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			TheWindow = (FaIconSelectorWindow)target;
			break;
		case 2:
			CbFaIconStyle = (ComboBox)target;
			CbFaIconStyle.SelectionChanged += u7wgjZVvjXU;
			break;
		case 3:
			TxtFilter = (TextBox)target;
			TxtFilter.TextChanged += ndpgjYbTHRR;
			break;
		case 4:
			BtnSearch = (Button)target;
			num = 1;
			if (waGDnJFVXTpXhgQcSIST != null)
			{
				goto IL_00d1;
			}
			goto IL_00d5;
		case 5:
			BtnUseDarkgray = (Button)target;
			BtnUseDarkgray.Click += mTugjGbBAAY;
			break;
		case 6:
			BtnWeb = (Button)target;
			BtnWeb.Click += pmCgjsAgaOI;
			break;
		case 7:
			FaIconList = (ListBox)target;
			FaIconList.MouseLeftButtonDown += vjlgjHGRDTO;
			break;
		default:
			fdugjdhphIa = true;
			break;
		case 10:
			PnlProInfo = (StackPanel)target;
			break;
		case 11:
			BtnOk = (Button)target;
			BtnOk.Click += CTigjehdl4J;
			break;
		case 12:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += XhQgjkaUUlD;
				break;
			}
			IL_00d5:
			do
			{
				switch (num)
				{
				case 1:
					break;
				default:
					return;
				}
				BtnSearch.Click += HALgj92foEJ;
				num = 0;
			}
			while (FRIRdMFV2oJdlIvyyRnU());
			goto IL_00d1;
			IL_00d1:
			num = num2;
			goto IL_00d5;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 9:
			((MenuItem)target).Click += OHjgj1IxBIv;
			break;
		case 8:
			((Border)target).PreviewMouseLeftButtonDown += aTegjIWhVlj;
			((Border)target).PreviewMouseMove += WL2gjWMCMdr;
			break;
		}
	}

	[CompilerGenerated]
	private void mDNgjb9EAUy(object object_1)
	{
		base.Dispatcher.Invoke(FEDgj6roRZm);
	}

	[CompilerGenerated]
	private void FEDgj6roRZm()
	{
		pcTgjhCjlCZ();
	}

	internal static bool FRIRdMFV2oJdlIvyyRnU()
	{
		return waGDnJFVXTpXhgQcSIST == null;
	}
}
