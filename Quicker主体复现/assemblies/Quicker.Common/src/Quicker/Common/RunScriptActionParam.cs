namespace Quicker.Common;

public class RunScriptActionParam
{
	public string Script { get; set; }

	public string Type { get; set; }

	public string Ext { get; set; }

	public bool RunAsAdmin { get; set; }

	public bool WaitForExit { get; set; }

	public string Encoding { get; set; }

	public string WorkingDir { get; set; }
}
