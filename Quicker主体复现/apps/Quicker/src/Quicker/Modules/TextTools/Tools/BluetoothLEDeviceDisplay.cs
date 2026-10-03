using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using Windows.Devices.Enumeration;

namespace Quicker.Modules.TextTools.Tools;

public class BluetoothLEDeviceDisplay : INotifyPropertyChanged
{
	[CompilerGenerated]
	private DeviceInformation eXstSWBZWfA;

	[CompilerGenerated]
	private BitmapImage sOotSkNx0Cj;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static BluetoothLEDeviceDisplay U8DC2YQpNBwHILaRVZ5E;

	public DeviceInformation DeviceInformation
	{
		[CompilerGenerated]
		get
		{
			return eXstSWBZWfA;
		}
		[CompilerGenerated]
		private set
		{
			eXstSWBZWfA = value;
		}
	}

	public string Id => DeviceInformation.Id;

	public string Name => DeviceInformation.Name;

	public bool IsPaired => DeviceInformation.Pairing.IsPaired;

	public bool IsConnected => (bool?)DeviceInformation.Properties["System.Devices.Aep.IsConnected"] == true;

	public bool IsConnectable => (bool?)DeviceInformation.Properties["System.Devices.Aep.Bluetooth.Le.IsConnectable"] == true;

	public IReadOnlyDictionary<string, object> Properties => DeviceInformation.Properties;

	public BitmapImage GlyphBitmapImage
	{
		[CompilerGenerated]
		get
		{
			return sOotSkNx0Cj;
		}
		[CompilerGenerated]
		private set
		{
			sOotSkNx0Cj = value;
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

	public BluetoothLEDeviceDisplay(DeviceInformation deviceInfoIn)
	{
		DeviceInformation = deviceInfoIn;
	}

	public void Update(DeviceInformationUpdate deviceInfoUpdate)
	{
		DeviceInformation.Update(deviceInfoUpdate);
		OnPropertyChanged("Id");
		OnPropertyChanged("Name");
		OnPropertyChanged("DeviceInformation");
		OnPropertyChanged("IsPaired");
		OnPropertyChanged("IsConnected");
		OnPropertyChanged("Properties");
		OnPropertyChanged("IsConnectable");
	}

	protected void OnPropertyChanged(string name)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	internal static bool gWTPlfQp9f86hDP0e5Yl()
	{
		return U8DC2YQpNBwHILaRVZ5E == null;
	}
}
