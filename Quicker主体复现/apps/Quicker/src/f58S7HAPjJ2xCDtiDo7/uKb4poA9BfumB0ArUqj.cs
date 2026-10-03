using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CodeCompletionServer.Entities;
using Quicker.Annotations;

namespace f58S7HAPjJ2xCDtiDo7;

internal class uKb4poA9BfumB0ArUqj : INotifyPropertyChanged
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSummary_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Task<ItemDescriptionResult> lazySummary;

		public uKb4poA9BfumB0ArUqj _003C_003E4__this;

		private TaskAwaiter<ItemDescriptionResult> _003C_003Eu__1;

		private static object MGDqEBciqOUdD5EYmJ5C;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			uKb4poA9BfumB0ArUqj uKb4poA9BfumB0ArUqj2 = _003C_003E4__this;
			try
			{
				TaskAwaiter<ItemDescriptionResult> awaiter;
				if (num != 0)
				{
					awaiter = lazySummary.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						int num2 = 0;
						if (MGDqEBciqOUdD5EYmJ5C != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ItemDescriptionResult>);
					num = -1;
					_003C_003E1__state = -1;
				}
				ItemDescriptionResult result = awaiter.GetResult();
				object obj;
				if (result == null)
				{
					obj = null;
				}
				else
				{
					obj = result.TaggedParts;
					if (obj != null)
					{
						goto IL_00a7;
					}
				}
				obj = new TaggedText[0];
				goto IL_00a7;
				IL_00a7:
				uKb4poA9BfumB0ArUqj2.Summary = (TaggedText[])obj;
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

		internal static bool A2p1cQciikbjSFtBsfDr()
		{
			return MGDqEBciqOUdD5EYmJ5C == null;
		}
	}

	private TaggedText[] Qvkl1N199a;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static uKb4poA9BfumB0ArUqj G9iCdoQVaY8VqXe8cj0m;

	public TaggedText[] Summary
	{
		get
		{
			return Qvkl1N199a;
		}
		private set
		{
			Qvkl1N199a = value;
			OnPropertyChanged("Summary");
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

	public uKb4poA9BfumB0ArUqj(Task<ItemDescriptionResult> task_0)
	{
		GRJlGsrBj8(task_0);
	}

	[AsyncStateMachine(typeof(_003CUpdateSummary_003Ed__5))]
	private void GRJlGsrBj8(Task<ItemDescriptionResult> task_0)
	{
		_003CUpdateSummary_003Ed__5 stateMachine = default(_003CUpdateSummary_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.lazySummary = task_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool EDHKKRQVr8Fh3e2swTOe()
	{
		return G9iCdoQVaY8VqXe8cj0m == null;
	}
}
