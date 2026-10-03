using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using bEVZu13wruQIEh71Lv;

namespace Cuiliang.AliyunOssSdk.Api.Object.DeleteMultiple;

[XmlRoot("DeleteResult")]
public class DeleteMultipleObjectsResult
{
	[XmlRoot("Deleted")]
	public class DeletedObject
	{
		[CompilerGenerated]
		private string CZ1vEeocEq4;

		internal static DeletedObject Xv9DShcjFJ1rV1KLVULZ;

		[XmlElement("Key")]
		public string Key
		{
			[CompilerGenerated]
			get
			{
				return CZ1vEeocEq4;
			}
			[CompilerGenerated]
			set
			{
				CZ1vEeocEq4 = value;
			}
		}

		internal static bool mJLf9Xcjchxf0upe9byE()
		{
			return Xv9DShcjFJ1rV1KLVULZ == null;
		}
	}

	private DeletedObject[] LoXuU7eaYo;

	[CompilerGenerated]
	private string rDFulUdNiO;

	private static DeleteMultipleObjectsResult QLIFFCDQ3DFDnd89oLK;

	[XmlElement("Deleted")]
	public DeletedObject[] Keys
	{
		get
		{
			if (EncodingType == null)
			{
				return LoXuU7eaYo;
			}
			bool flag = EncodingType.ToLowerInvariant().Equals("url");
			DeletedObject[] loXuU7eaYo = LoXuU7eaYo;
			int num = 0;
			if (!cY2I0PDFfbw5kZMIXQZ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				foreach (DeletedObject deletedObject in loXuU7eaYo)
				{
					deletedObject.Key = (flag ? bThfW9sYygwxKofgvb.i1NSFKMiqH(deletedObject.Key) : deletedObject.Key);
				}
				return LoXuU7eaYo;
			}
		}
		set
		{
			LoXuU7eaYo = value;
		}
	}

	[XmlElement("EncodingType")]
	public string EncodingType
	{
		[CompilerGenerated]
		get
		{
			return rDFulUdNiO;
		}
		[CompilerGenerated]
		set
		{
			rDFulUdNiO = value;
		}
	}

	internal static bool cY2I0PDFfbw5kZMIXQZ()
	{
		return QLIFFCDQ3DFDnd89oLK == null;
	}
}
