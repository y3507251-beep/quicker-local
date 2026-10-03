using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NAudio.CoreAudioApi;

namespace AudioDeviceCmdlets;

public class GetAudioDevice
{
	[CompilerGenerated]
	private sealed class _003CList_003Ed__1 : IDisposable, IEnumerable<AudioDevice>, IEnumerator<AudioDevice>, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private AudioDevice _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private MMDeviceEnumerator _003CDevEnum_003E5__2;

		private MMDeviceCollection _003CDeviceCollection_003E5__3;

		private int _003Ci_003E5__4;

		internal static _003CList_003Ed__1 OHPkuqcGZpF78BlpnLKG;

		AudioDevice IEnumerator<AudioDevice>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CList_003Ed__1(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003CDevEnum_003E5__2 = null;
			_003CDeviceCollection_003E5__3 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			(MMDeviceEnumerator, MMDeviceCollection) deviceCollection = default((MMDeviceEnumerator, MMDeviceCollection));
			int num;
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				deviceCollection = GetDeviceCollection();
				num = 0;
				if (OHPkuqcGZpF78BlpnLKG != null)
				{
					goto IL_0059;
				}
				goto IL_0066;
			case 1:
				_003C_003E1__state = -1;
				goto IL_010a;
			case 2:
				{
					_003C_003E1__state = -1;
					num = 1;
					if (OHPkuqcGZpF78BlpnLKG == null)
					{
						goto IL_0059;
					}
					goto IL_0087;
				}
				IL_0059:
				switch (num)
				{
				case 1:
					goto IL_0087;
				}
				goto IL_0066;
				IL_0087:
				_003Ci_003E5__4++;
				goto IL_0097;
				IL_0066:
				_003CDevEnum_003E5__2 = deviceCollection.Item1;
				_003CDeviceCollection_003E5__3 = deviceCollection.Item2;
				_003Ci_003E5__4 = 0;
				goto IL_0097;
				IL_0097:
				if (_003Ci_003E5__4 >= _003CDeviceCollection_003E5__3.Count)
				{
					return false;
				}
				if (_003CDeviceCollection_003E5__3[_003Ci_003E5__4].ID == _003CDevEnum_003E5__2.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).ID || _003CDeviceCollection_003E5__3[_003Ci_003E5__4].ID == _003CDevEnum_003E5__2.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).ID)
				{
					break;
				}
				goto IL_010a;
				IL_010a:
				_003C_003E2__current = new AudioDevice(_003Ci_003E5__4 + 1, _003CDeviceCollection_003E5__3[_003Ci_003E5__4]);
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E2__current = new AudioDevice(_003Ci_003E5__4 + 1, _003CDeviceCollection_003E5__3[_003Ci_003E5__4], true);
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<AudioDevice> IEnumerable<AudioDevice>.GetEnumerator()
		{
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				return this;
			}
			return new _003CList_003Ed__1(0);
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<AudioDevice>)this).GetEnumerator();
		}

		internal static bool wGVmLncG5ApvZMsjglPH()
		{
			return OHPkuqcGZpF78BlpnLKG == null;
		}
	}

	internal static GetAudioDevice CnRFyeOuRKoJhVWplnm;

	public static (MMDeviceEnumerator DevEnum, MMDeviceCollection DeviceCollection) GetDeviceCollection()
	{
		MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		MMDeviceCollection item = mMDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
		return (DevEnum: mMDeviceEnumerator, DeviceCollection: item);
	}

	[IteratorStateMachine(typeof(_003CList_003Ed__1))]
	public static IEnumerable<AudioDevice> List()
	{
		return new _003CList_003Ed__1(-2);
	}

	public static AudioDevice GetById(string id)
	{
		if (string.IsNullOrEmpty(id))
		{
			throw new ArgumentException("Value cannot be null or empty.", "id");
		}
		(MMDeviceEnumerator DevEnum, MMDeviceCollection DeviceCollection) deviceCollection = GetDeviceCollection();
		MMDeviceEnumerator item = deviceCollection.DevEnum;
		MMDeviceCollection item2 = deviceCollection.DeviceCollection;
		if (ahoJBKOoT1V8uowQbxB())
		{
			switch (0)
			{
			}
		}
		int num = 0;
		while (true)
		{
			if (num < item2.Count)
			{
				if (string.Compare(item2[num].ID, id, StringComparison.CurrentCultureIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			throw new ArgumentException("No AudioDevice with that ID");
		}
		if (!(item2[num].ID == item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).ID) && !(item2[num].ID == item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).ID))
		{
			return new AudioDevice(num + 1, item2[num]);
		}
		return new AudioDevice(num + 1, item2[num], true);
	}

	public static AudioDevice GetByIndex(int index)
	{
		var (mMDeviceEnumerator, mMDeviceCollection) = GetDeviceCollection();
		if (index >= 1 && index <= mMDeviceCollection.Count)
		{
			if (!(mMDeviceCollection[index - 1].ID == mMDeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).ID) && !(mMDeviceCollection[index - 1].ID == mMDeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).ID))
			{
				return new AudioDevice(index, mMDeviceCollection[index - 1]);
			}
			return new AudioDevice(index, mMDeviceCollection[index - 1], true);
		}
		throw new ArgumentException("No AudioDevice with that Index");
	}

	public static AudioDevice GetPlayback()
	{
		(MMDeviceEnumerator DevEnum, MMDeviceCollection DeviceCollection) deviceCollection = GetDeviceCollection();
		MMDeviceEnumerator item = deviceCollection.DevEnum;
		MMDeviceCollection item2 = deviceCollection.DeviceCollection;
		int num = 0;
		while (true)
		{
			if (num < item2.Count)
			{
				if (item2[num].ID == item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).ID)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return new AudioDevice(num + 1, item2[num], true);
	}

	public static bool GetPlaybackMute()
	{
		MMDeviceEnumerator item = GetDeviceCollection().DevEnum;
		return item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume.Mute;
	}

	public static string GetPlaybackVolume()
	{
		MMDeviceEnumerator item = GetDeviceCollection().DevEnum;
		return $"{item.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume.MasterVolumeLevelScalar * 100f}%";
	}

	public static AudioDevice GetRecording()
	{
		(MMDeviceEnumerator DevEnum, MMDeviceCollection DeviceCollection) deviceCollection = GetDeviceCollection();
		MMDeviceEnumerator item = deviceCollection.DevEnum;
		MMDeviceCollection item2 = deviceCollection.DeviceCollection;
		int num = 0;
		while (true)
		{
			if (num < item2.Count)
			{
				if (item2[num].ID == item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).ID)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return new AudioDevice(num + 1, item2[num], true);
	}

	public static bool GetRecordingMute()
	{
		MMDeviceEnumerator item = GetDeviceCollection().DevEnum;
		return item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioEndpointVolume.Mute;
	}

	public static string GetRecordingVolume()
	{
		MMDeviceEnumerator item = GetDeviceCollection().DevEnum;
		return $"{item.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia).AudioEndpointVolume.MasterVolumeLevelScalar * 100f}%";
	}

	internal static bool ahoJBKOoT1V8uowQbxB()
	{
		return CnRFyeOuRKoJhVWplnm == null;
	}
}
