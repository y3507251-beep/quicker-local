using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Controls;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public class BaseFormFieldControl : UserControl
{
	[CompilerGenerated]
	private EventHandler<FormField> m_ValueChanged;

	internal static BaseFormFieldControl tEaQ7aFK1hsk81uhbf7x;

	public event EventHandler<FormField> ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FormField> eventHandler = this.m_ValueChanged;
			EventHandler<FormField> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FormField> value2 = (EventHandler<FormField>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FormField> eventHandler = this.m_ValueChanged;
			EventHandler<FormField> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FormField> value2 = (EventHandler<FormField>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected void TriggerValueChange(FormField field)
	{
		this.m_ValueChanged?.Invoke(this, field);
	}

	internal static bool MNiGVQFKKYrE4OCFmIKE()
	{
		return tEaQ7aFK1hsk81uhbf7x == null;
	}
}
