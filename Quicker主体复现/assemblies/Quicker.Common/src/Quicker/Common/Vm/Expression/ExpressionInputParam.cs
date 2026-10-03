using System.ComponentModel;
using System.Runtime.CompilerServices;
using Quicker.Common.Annotations;
using Quicker.Public.Actions;

namespace Quicker.Common.Vm.Expression;

public class ExpressionInputParam : INotifyPropertyChanged
{
	private string _sampleValue;

	public string Key { get; set; }

	public VarType VarType { get; set; }

	public string Description { get; set; }

	public string CSharpType { get; set; }

	public bool IsKeyParam { get; set; }

	public bool SaveState { get; set; }

	public string SampleValue
	{
		get
		{
			return _sampleValue;
		}
		set
		{
			_sampleValue = value;
			OnPropertyChanged("SampleValue");
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
