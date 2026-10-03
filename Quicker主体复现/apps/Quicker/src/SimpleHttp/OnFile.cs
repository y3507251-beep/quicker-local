using System.IO;

namespace SimpleHttp;

public delegate Stream OnFile(string fieldName, string fileName, string contentType);
