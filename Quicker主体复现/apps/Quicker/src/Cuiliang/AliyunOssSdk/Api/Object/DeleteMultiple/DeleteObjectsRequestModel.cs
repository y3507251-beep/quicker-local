using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Cuiliang.AliyunOssSdk.Api.Object.DeleteMultiple;

[XmlRoot("Delete")]
public class DeleteObjectsRequestModel
{
	[XmlRoot("Object")]
	public class ObjectToDel
	{
		[CompilerGenerated]
		private string b6AvEYdMq41;

		internal static ObjectToDel r9wUJgcjymqn0gmUAYev;

		[XmlElement("Key")]
		public string Key
		{
			[CompilerGenerated]
			get
			{
				return b6AvEYdMq41;
			}
			[CompilerGenerated]
			set
			{
				b6AvEYdMq41 = value;
			}
		}

		internal static bool d06G8wcjpxtYWcLduusp()
		{
			return r9wUJgcjymqn0gmUAYev == null;
		}
	}

	[CompilerGenerated]
	private bool YYEuiWwdJ0;

	[CompilerGenerated]
	private ObjectToDel[] sHyu3V7A6G;

	internal static DeleteObjectsRequestModel BBws2fDyCsnd0e75u7i;

	[XmlElement("Quiet")]
	public bool Quiet
	{
		[CompilerGenerated]
		get
		{
			return YYEuiWwdJ0;
		}
		[CompilerGenerated]
		set
		{
			YYEuiWwdJ0 = value;
		}
	}

	[XmlElement("Object")]
	public ObjectToDel[] Keys
	{
		[CompilerGenerated]
		get
		{
			return sHyu3V7A6G;
		}
		[CompilerGenerated]
		set
		{
			sHyu3V7A6G = value;
		}
	}

	public DeleteObjectsRequestModel()
	{
	}

	public DeleteObjectsRequestModel(bool quiet, IList<string> keys)
	{
		Quiet = quiet;
		List<ObjectToDel> list = new List<ObjectToDel>();
		foreach (string key in keys)
		{
			list.Add(new ObjectToDel
			{
				Key = key
			});
		}
		Keys = list.ToArray();
	}

	internal static bool yVQon0DpImY4il7jibT()
	{
		return BBws2fDyCsnd0e75u7i == null;
	}
}
