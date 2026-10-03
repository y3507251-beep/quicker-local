using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using Quicker.Common;

namespace Quicker.View.Controls;

public abstract class BaseActionParamEditor : UserControl
{
	[CompilerGenerated]
	private EventHandler m_DataChanged;

	internal static BaseActionParamEditor tkYUEKFqThTmurwQ0BHF;

	public event EventHandler DataChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_DataChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_DataChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public abstract void SetData(ActionItem actionItem);

	public abstract void SaveData(ActionItem actionItem);

	protected virtual void OnDataChanged()
	{
		this.m_DataChanged?.Invoke(this, null);
	}

	public virtual Task StartInputAsync(ActionType? newActionType)
	{
		return Task.CompletedTask;
	}

	public virtual (bool isSuccess, string message) Validate()
	{
		return (isSuccess: true, message: string.Empty);
	}

	internal static bool ur7xTdFqmCikW9fHjZmC()
	{
		return tkYUEKFqThTmurwQ0BHF == null;
	}

	internal static void t89nVUFqCnZCao0jNbpW()
	{
	}
}
