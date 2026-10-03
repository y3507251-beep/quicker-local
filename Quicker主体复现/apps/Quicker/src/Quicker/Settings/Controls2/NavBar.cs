using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Quicker.Settings.Code;
using Quicker.Utilities;

namespace Quicker.Settings.Controls2;

public class NavBar : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public SettingMenuCategory? bRavVhtjxic;

		private static _003C_003Ec__DisplayClass7_0 d5wGUbcNtVL7hTaPmsIN;

		internal bool AECvV9vnIxd(SettingMenuCategoryInfo x)
		{
			return x.Category == bRavVhtjxic;
		}

		internal static void K4HhPlcNTvUbRwSLpSQ4()
		{
		}

		internal static bool fHWKNMcNSWQxsWcBYC4p()
		{
			return d5wGUbcNtVL7hTaPmsIN == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHomeBtn_Click_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object vOQo3scNm68LgrZ7sd4t;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = AppHelper.OpenUserHomeWithAutoLoginAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						int num2 = 0;
						if (vOQo3scNm68LgrZ7sd4t != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool YX8AaacNsL6KSn3dZvni()
		{
			return vOQo3scNm68LgrZ7sd4t == null;
		}
	}

	[CompilerGenerated]
	private RoutedEventHandler m_SelectionChanged;

	private bool PjFjOUviaF;

	internal Border AvatarWrapper;

	internal ListBox CategoryList;

	private bool IM9jF5ShA8;

	internal static NavBar ht1jorSh604nQN9QLoI;

	public SettingMenuCategory? SelectedCategory
	{
		get
		{
			return (CategoryList.SelectedItem as SettingMenuCategoryInfo)?.Category;
		}
		set
		{
			SetSelectedCategory(value);
		}
	}

	public event RoutedEventHandler SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = this.m_SelectionChanged;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Combine(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RoutedEventHandler routedEventHandler = this.m_SelectionChanged;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_SelectionChanged, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
	}

	public void SetSelectedCategory(SettingMenuCategory? category)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.bRavVhtjxic = category;
		PjFjOUviaF = true;
		SettingMenuCategoryInfo selectedItem = SettingsMenuProvider.Categories.FirstOrDefault(_003C_003Ec__DisplayClass7_.AECvV9vnIxd);
		CategoryList.SelectedItem = selectedItem;
		PjFjOUviaF = false;
	}

	public NavBar()
	{
		InitializeComponent();
		CategoryList.ItemsSource = SettingsMenuProvider.Categories;
	}

	private void RogjopUg44(object sender, MouseEventArgs e)
	{
	}

	private void ultjTbecpH(object sender, SelectionChangedEventArgs e)
	{
		this.m_SelectionChanged?.Invoke(sender, e);
	}

	private void pL5jMwSK3p(object sender, MouseEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003CHomeBtn_Click_003Ed__12))]
	private void q1tjA5McmT(object sender, MouseButtonEventArgs e)
	{
		_003CHomeBtn_Click_003Ed__12 stateMachine = default(_003CHomeBtn_Click_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public void SetAvatar(string avatarUrl)
	{
		BitmapSource imageSource = ImageCache.GetImageSource(avatarUrl, 64);
		AvatarWrapper.Child = null;
		AvatarWrapper.Background = new ImageBrush(imageSource);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!IM9jF5ShA8)
		{
			IM9jF5ShA8 = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/controls/navbar.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			IM9jF5ShA8 = true;
			break;
		case 1:
			((Border)target).PreviewMouseDown += q1tjA5McmT;
			break;
		case 2:
			AvatarWrapper = (Border)target;
			break;
		case 3:
			CategoryList = (ListBox)target;
			CategoryList.SelectionChanged += ultjTbecpH;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 4)
		{
			((Border)target).MouseEnter += RogjopUg44;
			((Border)target).MouseLeave += pL5jMwSK3p;
		}
	}

	internal static bool nGifdvSH6BWuSdOicWx()
	{
		return ht1jorSh604nQN9QLoI == null;
	}

	internal static void BV4IkewVfa4RHOrtvh8()
	{
	}
}
