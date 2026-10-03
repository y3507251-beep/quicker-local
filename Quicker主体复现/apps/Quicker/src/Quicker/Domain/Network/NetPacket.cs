using System;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Quicker.Domain.Network.Messages;
using Quicker.Domain.Network.Messages.Recv;
using Quicker.Domain.Network.Messages.Send;

namespace Quicker.Domain.Network;

public class NetPacket
{
	public const uint START_FLAG = uint.MaxValue;

	public const uint END_FLAG = 0u;

	[CompilerGenerated]
	private int D0atqAaWyc6;

	[CompilerGenerated]
	private string AMotqOUV1q8;

	internal static NetPacket UVnCoZQGmWVvBbZTfXwO;

	public int MessageType
	{
		[CompilerGenerated]
		get
		{
			return D0atqAaWyc6;
		}
		[CompilerGenerated]
		set
		{
			D0atqAaWyc6 = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return AMotqOUV1q8;
		}
		[CompilerGenerated]
		set
		{
			AMotqOUV1q8 = value;
		}
	}

	public NetPacket()
	{
	}

	public NetPacket(MessageBase msg)
	{
		MessageType = msg.MessageType;
		SetData(msg);
	}

	public void SetData(object dataObj)
	{
		Data = JsonConvert.SerializeObject(dataObj, Formatting.None);
	}

	public MessageBase GetMessage()
	{
		return MessageType switch
		{
			200 => JsonConvert.DeserializeObject<DeviceLoginMessage>(Data), 
			101 => JsonConvert.DeserializeObject<ButtonClickedMessage>(Data), 
			102 => JsonConvert.DeserializeObject<ToggleMuteMessage>(Data), 
			103 => JsonConvert.DeserializeObject<UpdateVolumeMessage>(Data), 
			104 => JsonConvert.DeserializeObject<TextDataMessage>(Data), 
			105 => JsonConvert.DeserializeObject<PhotoMessage>(Data), 
			110 => JsonConvert.DeserializeObject<CommandMessage>(Data), 
			1 => JsonConvert.DeserializeObject<UpdateButtonsMessage>(Data), 
			_ => null, 
		};
	}

	public static int GetIntFromByte(byte[] data, int startPos)
	{
		return (data[startPos] << 24) | (data[startPos + 1] << 16) | (data[startPos + 2] << 8) | data[startPos + 3];
	}

	public static byte[] GetValueBytes(int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	public static byte[] GetValueBytes(uint value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	public static byte[] BuildPacket(NetPacket packet)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(packet.Data);
		byte[] array = new byte[bytes.Length + 16];
		GetValueBytes(uint.MaxValue).CopyTo(array, 0);
		GetValueBytes(packet.MessageType).CopyTo(array, 4);
		GetValueBytes(bytes.Length).CopyTo(array, 8);
		bytes.CopyTo(array, 12);
		GetValueBytes(0u).CopyTo(array, bytes.Length + 12);
		return array;
	}

	public byte[] Build()
	{
		return BuildPacket(this);
	}

	internal static bool JNQhXQQGst7srR5dpQYd()
	{
		return UVnCoZQGmWVvBbZTfXwO == null;
	}
}
