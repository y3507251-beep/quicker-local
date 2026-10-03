using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Baidu.Aip.Speech;

public class TlvPacket
{
	[CompilerGenerated]
	private sealed class _003CParseFromBytes_003Ed__16 : IEnumerable<TlvPacket>, IEnumerator<TlvPacket>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private TlvPacket _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private byte[] data;

		public byte[] _003C_003E3__data;

		private int _003Ci_003E5__2;

		private int _003Cl_003E5__3;

		internal static _003CParseFromBytes_003Ed__16 iOJgnqcep4F2wcOcc6qU;

		TlvPacket IEnumerator<TlvPacket>.Current
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
		public _003CParseFromBytes_003Ed__16(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 += _003Cl_003E5__3;
				break;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				break;
			}
			int num;
			int num2;
			if (_003Ci_003E5__2 < data.Length)
			{
				num = BitConverter.ToInt32(data, _003Ci_003E5__2);
				_003Ci_003E5__2 += 4;
				_003Cl_003E5__3 = BitConverter.ToInt32(data, _003Ci_003E5__2);
				num2 = 1;
				if (iOJgnqcep4F2wcOcc6qU != null)
				{
					goto IL_00f9;
				}
				goto IL_00fd;
			}
			return false;
			IL_00f9:
			int num3 = default(int);
			num2 = num3;
			goto IL_00fd;
			IL_00fd:
			do
			{
				switch (num2)
				{
				case 1:
					_003Ci_003E5__2 += 4;
					if (BitConverter.IsLittleEndian)
					{
						num = IPAddress.NetworkToHostOrder(num);
						_003Cl_003E5__3 = IPAddress.NetworkToHostOrder(_003Cl_003E5__3);
					}
					break;
				default:
					return true;
				}
				_003C_003E2__current = new TlvPacket((TlvType)num, data, _003Ci_003E5__2, _003Cl_003E5__3);
				_003C_003E1__state = 1;
				num2 = 0;
			}
			while (IxXroaceXD7v6iFxpmkM());
			goto IL_00f9;
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
		IEnumerator<TlvPacket> IEnumerable<TlvPacket>.GetEnumerator()
		{
			_003CParseFromBytes_003Ed__16 _003CParseFromBytes_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CParseFromBytes_003Ed__ = this;
			}
			else
			{
				_003CParseFromBytes_003Ed__ = new _003CParseFromBytes_003Ed__16(0);
			}
			_003CParseFromBytes_003Ed__.data = _003C_003E3__data;
			return _003CParseFromBytes_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TlvPacket>)this).GetEnumerator();
		}

		internal static bool IxXroaceXD7v6iFxpmkM()
		{
			return iOJgnqcep4F2wcOcc6qU == null;
		}
	}

	[CompilerGenerated]
	private TlvType x8OSbrc00k;

	[CompilerGenerated]
	private byte[] gqmS6nnArU;

	internal static TlvPacket Is2bKtAyv5pX184wg47;

	public TlvType T
	{
		[CompilerGenerated]
		get
		{
			return x8OSbrc00k;
		}
		[CompilerGenerated]
		set
		{
			x8OSbrc00k = value;
		}
	}

	public byte[] V
	{
		[CompilerGenerated]
		get
		{
			return gqmS6nnArU;
		}
		[CompilerGenerated]
		set
		{
			gqmS6nnArU = value;
		}
	}

	public int L => V.Length;

	public TlvPacket(TlvType type)
	{
		T = type;
		V = new byte[0];
	}

	public TlvPacket(TlvType type, byte[] value)
	{
		T = type;
		V = new byte[value.Length];
		value.CopyTo(V, 0);
	}

	public TlvPacket(TlvType type, byte[] value, int count)
	{
		T = type;
		V = new byte[value.Length];
		Array.Copy(value, V, count);
	}

	public TlvPacket(TlvType type, byte[] value, int offset, int count)
	{
		T = type;
		V = new byte[value.Length];
		Array.Copy(value, offset, V, 0, count);
	}

	public TlvPacket(TlvType type, string value)
	{
		T = type;
		V = Encoding.UTF8.GetBytes(value);
	}

	public byte[] ToBytes()
	{
		byte[] array = new byte[8 + L];
		int value = (int)T;
		int num = V.Length;
		if (BitConverter.IsLittleEndian)
		{
			value = IPAddress.HostToNetworkOrder((int)T);
			num = IPAddress.HostToNetworkOrder(num);
		}
		BitConverter.GetBytes(value).CopyTo(array, 0);
		BitConverter.GetBytes(num).CopyTo(array, 4);
		if (Is2bKtAyv5pX184wg47 != null)
		{
			switch (0)
			{
			}
		}
		V.CopyTo(array, 8);
		return array;
	}

	[IteratorStateMachine(typeof(_003CParseFromBytes_003Ed__16))]
	public static IEnumerable<TlvPacket> ParseFromBytes(byte[] data)
	{
		return new _003CParseFromBytes_003Ed__16(-2)
		{
			_003C_003E3__data = data
		};
	}

	internal static bool U1qLY8ApaKsDaDxnmOo()
	{
		return Is2bKtAyv5pX184wg47 == null;
	}
}
