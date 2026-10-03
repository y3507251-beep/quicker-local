using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Quicker.Modules.Searching.Builtin;

[INotifyPropertyChanged]
public class WebSearchEngine : INotifyPropertyChanged
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	internal interface QTSK8iugxur97H6QAuf<HeNihVuVpllyWfJKTJJ> where HeNihVuVpllyWfJKTJJ : Task
	{
		[SpecialName]
		HeNihVuVpllyWfJKTJJ? XenMrpsYal9();

		[SpecialName]
		void UaAMrPffNWp(HeNihVuVpllyWfJKTJJ? ej9WGIuFdxWukNOBhLG);
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	protected sealed class TaskNotifier : QTSK8iugxur97H6QAuf<Task>
	{
		Task? QTSK8iugxur97H6QAuf<Task>.XenMrpsYal9() => kwnv1kiCh0S;

		void QTSK8iugxur97H6QAuf<Task>.UaAMrPffNWp(Task? value) => kwnv1kiCh0S = value;

		private Task? kwnv1kiCh0S;

		internal static TaskNotifier? BGcQXQcPhFYLoE5hW0Nu;

		Task? Task
		{
			get
			{
				return kwnv1kiCh0S;
			}
			set
			{
				kwnv1kiCh0S = value;
			}
		}

		internal TaskNotifier()
		{
		}

		public static implicit operator Task?(TaskNotifier? notifier)
		{
			return notifier?.kwnv1kiCh0S;
		}

		internal static bool yH08QjcPHoIGP4PmWnFW()
		{
			return BGcQXQcPhFYLoE5hW0Nu == null;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[ExcludeFromCodeCoverage]
	protected sealed class TaskNotifier<T> : QTSK8iugxur97H6QAuf<Task<T>>
	{
		Task<T>? QTSK8iugxur97H6QAuf<Task<T>>.XenMrpsYal9() => JZ5v1G3Hu99;

		void QTSK8iugxur97H6QAuf<Task<T>>.UaAMrPffNWp(Task<T>? value) => JZ5v1G3Hu99 = value;

		private Task<T>? JZ5v1G3Hu99;

		private static object cVMDk6cMV53w2mR6VJ7w;

		Task<T>? Task
		{
			get
			{
				return JZ5v1G3Hu99;
			}
			set
			{
				JZ5v1G3Hu99 = value;
			}
		}

		internal TaskNotifier()
		{
		}

		public static implicit operator Task<T>?(TaskNotifier<T>? notifier)
		{
			return notifier?.JZ5v1G3Hu99;
		}

		internal static bool K0GfAgcMQnov6nBd1lqW()
		{
			return cVMDk6cMV53w2mR6VJ7w == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0<TTask> where TTask : Task
	{
		[StructLayout(LayoutKind.Auto)]
		private struct RarDtrHJpW6eAFS7GF6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass49_0<TTask> _003C_003E4__this;

			private __TaskExtensions.TaskAwaitableWithoutEndValidation.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass49_0<TTask> _003C_003Ec__DisplayClass49_ = _003C_003E4__this;
				try
				{
					__TaskExtensions.TaskAwaitableWithoutEndValidation.Awaiter awaiter;
					if (num != 0)
					{
						awaiter = _003C_003Ec__DisplayClass49_.newValue.GetAwaitableWithoutEndValidation().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(__TaskExtensions.TaskAwaitableWithoutEndValidation.Awaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
					if (_003C_003Ec__DisplayClass49_.taskNotifier.XenMrpsYal9() == _003C_003Ec__DisplayClass49_.newValue)
					{
						_003C_003Ec__DisplayClass49_._003C_003E4__this.OnPropertyChanged(_003C_003Ec__DisplayClass49_.propertyName);
					}
					if (_003C_003Ec__DisplayClass49_.callback != null)
					{
						_003C_003Ec__DisplayClass49_.callback(_003C_003Ec__DisplayClass49_.newValue);
					}
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
		}

		public TTask newValue;

		public QTSK8iugxur97H6QAuf<TTask> taskNotifier;

		public WebSearchEngine _003C_003E4__this;

		public string propertyName;

		public Action<TTask?> callback;

		internal static object wYetVJcMcuVkvhbalTnj;

		[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass49_0<>.RarDtrHJpW6eAFS7GF6))]
		internal void TYMv1swtTT3()
		{
			RarDtrHJpW6eAFS7GF6 stateMachine = default(RarDtrHJpW6eAFS7GF6);
			stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
		}

		internal static bool A3WfS6cMW29tCX0dLZCk()
		{
			return wYetVJcMcuVkvhbalTnj == null;
		}
	}

	[CompilerGenerated]
	private Guid? yBFt0vDU6v3;

	[CompilerGenerated]
	private int G9lt0Se594y;

	[CompilerGenerated]
	private string Pnjt02ZgwT1;

	[CompilerGenerated]
	private string Scvt0uLapER;

	[CompilerGenerated]
	private string SS2t0Nm2e2v;

	[CompilerGenerated]
	private string bmbt0JtyokS;

	[CompilerGenerated]
	private string q9kt00KL21c;

	[CompilerGenerated]
	private string Tsct0CZibDC;

	private string cf5t0PG9DrA;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	internal static WebSearchEngine AJboWpQnfFJOPrAIu3rp;

	public Guid? SearchEngineId
	{
		[CompilerGenerated]
		get
		{
			return yBFt0vDU6v3;
		}
		[CompilerGenerated]
		set
		{
			yBFt0vDU6v3 = value;
		}
	}

	public int EngineRevision
	{
		[CompilerGenerated]
		get
		{
			return G9lt0Se594y;
		}
		[CompilerGenerated]
		set
		{
			G9lt0Se594y = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return Pnjt02ZgwT1;
		}
		[CompilerGenerated]
		set
		{
			Pnjt02ZgwT1 = value;
		}
	}

	public string QueryUrl
	{
		[CompilerGenerated]
		get
		{
			return Scvt0uLapER;
		}
		[CompilerGenerated]
		set
		{
			Scvt0uLapER = value;
		}
	}

	public string TriggerWords
	{
		[CompilerGenerated]
		get
		{
			return SS2t0Nm2e2v;
		}
		[CompilerGenerated]
		set
		{
			SS2t0Nm2e2v = value;
		}
	}

	public string CompletionUrl
	{
		[CompilerGenerated]
		get
		{
			return bmbt0JtyokS;
		}
		[CompilerGenerated]
		set
		{
			bmbt0JtyokS = value;
		}
	}

	public string CompletionXPath
	{
		[CompilerGenerated]
		get
		{
			return q9kt00KL21c;
		}
		[CompilerGenerated]
		set
		{
			q9kt00KL21c = value;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Tsct0CZibDC;
		}
		[CompilerGenerated]
		set
		{
			Tsct0CZibDC = value;
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	public event PropertyChangedEventHandler? PropertyChanged
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

	public string GetIcon()
	{
		return cf5t0PG9DrA ?? (cf5t0PG9DrA = (Icon.IsNullOrEmpty() ? AppHelper.GetUrlFavicon(QueryUrl) : Icon));
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		this.m_PropertyChanged?.Invoke(this, e);
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, newValue))
		{
			return false;
		}
		field = newValue;
		OnPropertyChanged(propertyName);
		return true;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected bool SetProperty<T>(ref T field, T newValue, IEqualityComparer<T> comparer, [CallerMemberName] string? propertyName = null)
	{
		if (comparer.Equals(field, newValue))
		{
			return false;
		}
		field = newValue;
		OnPropertyChanged(propertyName);
		return true;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected bool SetProperty<T>(T oldValue, T newValue, Action<T> callback, [CallerMemberName] string? propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(oldValue, newValue))
		{
			return false;
		}
		callback(newValue);
		OnPropertyChanged(propertyName);
		return true;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected bool SetProperty<T>(T oldValue, T newValue, IEqualityComparer<T> comparer, Action<T> callback, [CallerMemberName] string? propertyName = null)
	{
		if (comparer.Equals(oldValue, newValue))
		{
			return false;
		}
		callback(newValue);
		OnPropertyChanged(propertyName);
		return true;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[ExcludeFromCodeCoverage]
	[DebuggerNonUserCode]
	protected bool SetProperty<TModel, T>(T oldValue, T newValue, TModel model, Action<TModel, T> callback, [CallerMemberName] string? propertyName = null) where TModel : class
	{
		if (EqualityComparer<T>.Default.Equals(oldValue, newValue))
		{
			return false;
		}
		callback(model, newValue);
		OnPropertyChanged(propertyName);
		return true;
	}

	[ExcludeFromCodeCoverage]
	[DebuggerNonUserCode]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	protected bool SetProperty<TModel, T>(T oldValue, T newValue, IEqualityComparer<T> comparer, TModel model, Action<TModel, T> callback, [CallerMemberName] string? propertyName = null) where TModel : class
	{
		if (comparer.Equals(oldValue, newValue))
		{
			return false;
		}
		callback(model, newValue);
		OnPropertyChanged(propertyName);
		return true;
	}

	[ExcludeFromCodeCoverage]
	[DebuggerNonUserCode]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	protected bool SetPropertyAndNotifyOnCompletion(ref TaskNotifier? taskNotifier, Task? newValue, [CallerMemberName] string? propertyName = null)
	{
		return nPGt0LY9alK(taskNotifier ?? (taskNotifier = new TaskNotifier()), newValue, null, propertyName);
	}

	[ExcludeFromCodeCoverage]
	[DebuggerNonUserCode]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	protected bool SetPropertyAndNotifyOnCompletion(ref TaskNotifier? taskNotifier, Task? newValue, Action<Task?> callback, [CallerMemberName] string? propertyName = null)
	{
		return nPGt0LY9alK(taskNotifier ?? (taskNotifier = new TaskNotifier()), newValue, callback, propertyName);
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[DebuggerNonUserCode]
	[ExcludeFromCodeCoverage]
	protected bool SetPropertyAndNotifyOnCompletion<T>(ref TaskNotifier<T>? taskNotifier, Task<T>? newValue, [CallerMemberName] string? propertyName = null)
	{
		return nPGt0LY9alK(taskNotifier ?? (taskNotifier = new TaskNotifier<T>()), newValue, null, propertyName);
	}

	[ExcludeFromCodeCoverage]
	[DebuggerNonUserCode]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	protected bool SetPropertyAndNotifyOnCompletion<T>(ref TaskNotifier<T>? taskNotifier, Task<T>? newValue, Action<Task<T>?> callback, [CallerMemberName] string? propertyName = null)
	{
		return nPGt0LY9alK(taskNotifier ?? (taskNotifier = new TaskNotifier<T>()), newValue, callback, propertyName);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.INotifyPropertyChangedGenerator", "8.3.0.0")]
	[ExcludeFromCodeCoverage]
	private bool nPGt0LY9alK<i3Sxit27OTDUYMfGHxd>(QTSK8iugxur97H6QAuf<i3Sxit27OTDUYMfGHxd> taskNotifier, i3Sxit27OTDUYMfGHxd? YaaUQq2iFoIyQQBLZil, Action<i3Sxit27OTDUYMfGHxd?>? action_0, [CallerMemberName] string? propertyName = null) where i3Sxit27OTDUYMfGHxd : Task
	{
		_003C_003Ec__DisplayClass49_0<i3Sxit27OTDUYMfGHxd> _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0<i3Sxit27OTDUYMfGHxd>();
		_003C_003Ec__DisplayClass49_.newValue = YaaUQq2iFoIyQQBLZil;
		_003C_003Ec__DisplayClass49_.taskNotifier = taskNotifier;
		_003C_003Ec__DisplayClass49_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass49_.propertyName = propertyName;
		_003C_003Ec__DisplayClass49_.callback = action_0;
		if (_003C_003Ec__DisplayClass49_.taskNotifier.XenMrpsYal9() == _003C_003Ec__DisplayClass49_.newValue)
		{
			return false;
		}
		bool num = _003C_003Ec__DisplayClass49_.newValue?.IsCompleted ?? true;
		_003C_003Ec__DisplayClass49_.taskNotifier.UaAMrPffNWp(_003C_003Ec__DisplayClass49_.newValue);
		OnPropertyChanged(_003C_003Ec__DisplayClass49_.propertyName);
		if (num)
		{
			if (_003C_003Ec__DisplayClass49_.callback != null)
			{
				_003C_003Ec__DisplayClass49_.callback(_003C_003Ec__DisplayClass49_.newValue);
			}
			return true;
		}
		_003C_003Ec__DisplayClass49_.TYMv1swtTT3();
		return true;
	}

	internal static bool ItSRI0Qnb1mMxf1YcSWZ()
	{
		return AJboWpQnfFJOPrAIu3rp == null;
	}

	internal static void I1bcV4QnZwuo4Ku7AFZM()
	{
	}
}
