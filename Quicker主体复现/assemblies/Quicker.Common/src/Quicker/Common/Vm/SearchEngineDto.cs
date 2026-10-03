using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Quicker.Common.Vm;

public class SearchEngineDto : INotifyPropertyChanged
{
	public Guid Id { get; set; }

	public int Revision { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public int DownloadCount { get; set; }

	public string QueryUrl { get; set; }

	public string Icon { get; set; }

	public string TriggerWords { get; set; }

	public string CompletionUrl { get; set; }

	public string CompletionXPath { get; set; }

	public Guid CategoryId { get; set; }

	public string UserName { get; set; }

	public int UserSerial { get; set; }

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		OnPropertyChanged(propertyName);
		return true;
	}
}
