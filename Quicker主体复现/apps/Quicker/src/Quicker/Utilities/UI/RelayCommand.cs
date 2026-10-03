using System;
using System.Windows.Input;

namespace Quicker.Utilities.UI;

public class RelayCommand : ICommand
{
	private readonly Action<object> XxdvvnTTMZL;

	private static RelayCommand gHSHZfF7ER9agq8wC24O;

	public event EventHandler CanExecuteChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public RelayCommand(Action<object> action)
	{
		XxdvvnTTMZL = action;
	}

	public virtual bool CanExecute(object parameter)
	{
		return true;
	}

	public virtual void Execute(object parameter)
	{
		XxdvvnTTMZL?.Invoke(parameter);
	}

	internal static bool O9BLDmF7Gt8a7LbDUfxD()
	{
		return gHSHZfF7ER9agq8wC24O == null;
	}
}
