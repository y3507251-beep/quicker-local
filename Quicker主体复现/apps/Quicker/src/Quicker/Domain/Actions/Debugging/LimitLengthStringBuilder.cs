using System.Text;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.Debugging;

public class LimitLengthStringBuilder
{
	private readonly int WpNt5AtUm9H;

	private StringBuilder Wj6t5OHMDLA;

	private bool g7Qt5FFOO0L;

	internal static LimitLengthStringBuilder QDMLpWQfgM6BTm32jLT5;

	public LimitLengthStringBuilder(int capacity = 1024, int maxLength = 1024000)
	{
		WpNt5AtUm9H = maxLength;
		Wj6t5OHMDLA = new StringBuilder(capacity);
	}

	public void Append(string text)
	{
		if (Wj6t5OHMDLA.Length < WpNt5AtUm9H)
		{
			Wj6t5OHMDLA.Append(text);
		}
		else if (!g7Qt5FFOO0L)
		{
			Wj6t5OHMDLA.AppendLine();
			Wj6t5OHMDLA.AppendLine("**************************************************************");
			Wj6t5OHMDLA.AppendLine("**************************************************************");
			int num = 0;
			if (!eU4b1iQfPMW98Juct4IM())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			Wj6t5OHMDLA.AppendLine("调试日志内容太长了，已中止输出！");
			Wj6t5OHMDLA.AppendLine("**************************************************************");
			Wj6t5OHMDLA.AppendLine("**************************************************************");
			AppHelper.ShowWarning("调试日志内容太长了，已中止输出！");
			g7Qt5FFOO0L = true;
		}
	}

	public void Clear()
	{
		Wj6t5OHMDLA.Clear();
	}

	public override string ToString()
	{
		return Wj6t5OHMDLA.ToString();
	}

	internal static bool eU4b1iQfPMW98Juct4IM()
	{
		return QDMLpWQfgM6BTm32jLT5 == null;
	}
}
