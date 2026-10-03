using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Controls;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.View.X.Controls.ParamEditors;

public abstract class BaseParamEditor : UserControl, IBaseParamEditor
{
	[CompilerGenerated]
	private EventHandler m_ValueChanged;

	protected readonly StepInParamDef _paramDef;

	protected readonly ActionStepParam _paramData;

	private static BaseParamEditor op9aeUFL2Lm3D1Ykagty;

	public StepInParamDef ParamDef => _paramDef;

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_ValueChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_ValueChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ValueChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BaseParamEditor(StepInParamDef paramDef, ActionStepParam paramData)
	{
		_paramDef = paramDef;
		_paramData = paramData;
	}

	public void NotifyValueChange()
	{
		this.m_ValueChanged?.Invoke(this, EventArgs.Empty);
	}

	public abstract ActionStepParam GetParamValue();

	internal static bool RsqLthFLArUmmcaZuQBb()
	{
		return op9aeUFL2Lm3D1Ykagty == null;
	}
}
