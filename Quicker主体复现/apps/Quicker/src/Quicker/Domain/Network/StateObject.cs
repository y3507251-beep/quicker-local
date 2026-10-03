using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using Quicker.Domain.Interfaces;

namespace Quicker.Domain.Network;

public class StateObject
{
	[CompilerGenerated]
	private Socket vtltqlOm0Yq;

	[CompilerGenerated]
	private static readonly int fRPtqiJ0CyB;

	public byte[] recvBuffer = new byte[fRPtqiJ0CyB];

	private readonly byte[] bRJtq3ls765 = new byte[20971520];

	private int O52tqf6BxFE;

	private int J3BtqzdYDWD;

	[CompilerGenerated]
	private IMessageProcessor C9rtcwasHhy;

	[CompilerGenerated]
	private bool Lj1tctptWY4;

	internal static StateObject ygW20cQG7LxnbdZjuaF3;

	public Socket WorkSocket
	{
		[CompilerGenerated]
		get
		{
			return vtltqlOm0Yq;
		}
		[CompilerGenerated]
		set
		{
			vtltqlOm0Yq = value;
		}
	}

	public static int RecvBufferSize
	{
		[CompilerGenerated]
		get
		{
			return fRPtqiJ0CyB;
		}
	}

	public IMessageProcessor MessageProcessor
	{
		[CompilerGenerated]
		get
		{
			return C9rtcwasHhy;
		}
		[CompilerGenerated]
		set
		{
			C9rtcwasHhy = value;
		}
	}

	public bool IsLoggedIn
	{
		[CompilerGenerated]
		get
		{
			return Lj1tctptWY4;
		}
		[CompilerGenerated]
		set
		{
			Lj1tctptWY4 = value;
		}
	}

	public void ProcessData(int length)
	{
		Array.Copy(recvBuffer, 0, bRJtq3ls765, O52tqf6BxFE, length);
		O52tqf6BxFE += length;
		while (UJTtqFdbc0Q())
		{
		}
	}

	private bool UJTtqFdbc0Q()
	{
		int num = O52tqf6BxFE - J3BtqzdYDWD;
		if (num < 12)
		{
			return false;
		}
		int num2 = 0;
		int intFromByte2 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num3;
			if (num2 < 4)
			{
				if (bRJtq3ls765[J3BtqzdYDWD + num2] == ((-1 >>> (4 - num2 - 1) * 8) & 0xFF))
				{
					num2++;
					continue;
				}
				num3 = 0;
				if (Q8jJENQG4KXG4LVb3ouu())
				{
					break;
				}
			}
			else
			{
				int intFromByte = NetPacket.GetIntFromByte(bRJtq3ls765, J3BtqzdYDWD + 4);
				intFromByte2 = NetPacket.GetIntFromByte(bRJtq3ls765, J3BtqzdYDWD + 8);
				if (intFromByte2 > num - 16)
				{
					return false;
				}
				NetPacket netPacket = new NetPacket();
				netPacket.MessageType = intFromByte;
				netPacket.Data = Encoding.UTF8.GetString(bRJtq3ls765, J3BtqzdYDWD + 12, intFromByte2);
				IMessageProcessor messageProcessor = MessageProcessor;
				if (messageProcessor != null)
				{
					messageProcessor.ProcessMessage(netPacket.GetMessage(), this);
					goto IL_0103;
				}
				num3 = 0;
				if (ygW20cQG7LxnbdZjuaF3 != null)
				{
					num3 = num4;
				}
			}
			switch (num3)
			{
			case 1:
				goto end_IL_004c;
			}
			goto IL_0103;
			IL_0103:
			J3BtqzdYDWD += intFromByte2 + 16;
			if (O52tqf6BxFE - J3BtqzdYDWD > 0)
			{
				Buffer.BlockCopy(bRJtq3ls765, J3BtqzdYDWD, bRJtq3ls765, 0, O52tqf6BxFE - J3BtqzdYDWD);
				O52tqf6BxFE -= J3BtqzdYDWD;
				J3BtqzdYDWD = 0;
			}
			else
			{
				J3BtqzdYDWD = 0;
				O52tqf6BxFE = 0;
			}
			return true;
			continue;
			end_IL_004c:
			break;
		}
		return false;
	}

	public void Send(byte[] data)
	{
		WorkSocket.BeginSend(data, 0, data.Length, SocketFlags.None, QkotqUo2LyW, this);
	}

	private static void QkotqUo2LyW(IAsyncResult iasyncResult_0)
	{
		try
		{
			((StateObject)iasyncResult_0.AsyncState).WorkSocket.EndSend(iasyncResult_0);
		}
		catch (Exception)
		{
		}
	}

	static StateObject()
	{
		fRPtqiJ0CyB = 4096000;
	}

	internal static bool Q8jJENQG4KXG4LVb3ouu()
	{
		return ygW20cQG7LxnbdZjuaF3 == null;
	}

	internal static void jhaE3TQ0VAc6rHIhHH0l()
	{
	}
}
