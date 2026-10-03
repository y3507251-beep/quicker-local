using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Quicker.Utilities.Win32;

namespace PbBP6kiXxxQP7h8tKVK;

internal class a0N27uijcmAHZSB2kQT : NativeWindow
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct YEQhMPHfG0PiEng5ujA
	{
		public IntPtr tlJ2JBtPR2D;

		public int Q3O2JQOZsZm;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Iva2JjsvPTP;
	}

	[CompilerGenerated]
	private bool J2kvtwSMx8x;

	[CompilerGenerated]
	private int bUfvttj6wwf;

	[CompilerGenerated]
	private string jVyvtglGafb;

	[CompilerGenerated]
	private readonly AutoResetEvent F7EvtLxFgCP = new AutoResetEvent(false);

	internal static a0N27uijcmAHZSB2kQT t2VXVjFsdCoVESMlikFW;

	public a0N27uijcmAHZSB2kQT()
	{
		CreateHandle(new CreateParams
		{
			X = 0,
			Y = 0,
			Width = 0,
			Height = 0,
			Style = 8388608
		});
	}

	[SpecialName]
	[CompilerGenerated]
	public bool spCvwTiy1KD()
	{
		return J2kvtwSMx8x;
	}

	[SpecialName]
	[CompilerGenerated]
	private void eUvvwM6wHOT(bool bool_1)
	{
		J2kvtwSMx8x = bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int buJvwO82Lwf()
	{
		return bUfvttj6wwf;
	}

	[SpecialName]
	[CompilerGenerated]
	public void CyLvwF67cWq(int int_1)
	{
		bUfvttj6wwf = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string P2cvwlrxQPG()
	{
		return jVyvtglGafb;
	}

	[SpecialName]
	[CompilerGenerated]
	public void oLPvwiMeULT(string string_0)
	{
		jVyvtglGafb = string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public AutoResetEvent pYVvwfSBmVx()
	{
		return F7EvtLxFgCP;
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 74)
		{
			CopyData copyData = Marshal.PtrToStructure<CopyData>(m.LParam);
			CyLvwF67cWq((int)copyData.dwData);
			byte[] array = new byte[copyData.cbData];
			Marshal.Copy(copyData.lpData, array, 0, copyData.cbData);
			oLPvwiMeULT(Encoding.Unicode.GetString(array));
			pYVvwfSBmVx().Set();
		}
		base.WndProc(ref m);
	}

	public void Dispose()
	{
		DestroyHandle();
	}

	[DllImport("user32.dll")]
	private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, ref YEQhMPHfG0PiEng5ujA lParam);

	internal static bool gfUJRsFsOYjY8lIO9MXs()
	{
		return t2VXVjFsdCoVESMlikFW == null;
	}
}
