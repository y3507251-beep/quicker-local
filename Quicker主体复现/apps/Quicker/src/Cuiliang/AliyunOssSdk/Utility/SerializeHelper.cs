using System.IO;
using System.Xml.Serialization;

namespace Cuiliang.AliyunOssSdk.Utility;

public static class SerializeHelper
{
	public static T Deserialize<T>(Stream xmlStream)
	{
		return (T)new XmlSerializer(typeof(T)).Deserialize(xmlStream);
	}

	public static T Deserialize<T>(string stringContent)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		using TextReader textReader = new StringReader(stringContent);
		return (T)xmlSerializer.Deserialize(textReader);
	}

	public static string Serialize<T>(T obj)
	{
		if (obj == null)
		{
			return string.Empty;
		}
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
		using StringWriter stringWriter = new StringWriter();
		XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
		xmlSerializerNamespaces.Add(string.Empty, string.Empty);
		xmlSerializer.Serialize(stringWriter, obj, xmlSerializerNamespaces);
		return stringWriter.ToString();
	}
}
