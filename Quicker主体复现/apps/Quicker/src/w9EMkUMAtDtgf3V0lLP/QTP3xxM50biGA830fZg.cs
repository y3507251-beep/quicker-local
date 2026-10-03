using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using lUCjKTMbZVPP5v56los;
using PInvoke;
using Quicker.Utilities.Hooks;
using Quicker.Utilities.Win32;

namespace w9EMkUMAtDtgf3V0lLP;

[DesignerCategory("")]
internal class QTP3xxM50biGA830fZg : Form
{
	[CompilerGenerated]
	private AutomationElement i1pLDo0PsHO;

	[CompilerGenerated]
	private AutomationElement xipLDTMlyge;

	private IContainer a2kLDM6fmt3;

	private UIA3Automation SwkLDAnbubm = new UIA3Automation();

	private Timer hV7LDOd79KT;

	private bool UFQLDFeYL4B;

	private lPxZYOM8ws3NP42wph0 F9GLDU3FKjC = new lPxZYOM8ws3NP42wph0();

	private AutomationElement CyELDlMS6Il;

	private IntPtr ebeLDiEHJcp = IntPtr.Zero;

	private IntPtr KggLD3AeUXS = IntPtr.Zero;

	private IList<Form> RKALDfAwi5X;

	internal static QTP3xxM50biGA830fZg KDdNIKFZ2hG9K5bFoPkq;

	[SpecialName]
	[CompilerGenerated]
	public AutomationElement L1XLDjRrVi1()
	{
		return i1pLDo0PsHO;
	}

	[SpecialName]
	[CompilerGenerated]
	public void CUyLDnuPv2T(AutomationElement automationElement_3)
	{
		i1pLDo0PsHO = automationElement_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public AutomationElement hILLD5ZHybZ()
	{
		return xipLDTMlyge;
	}

	[SpecialName]
	[CompilerGenerated]
	public void DZeLDDkhXgT(AutomationElement automationElement_3)
	{
		xipLDTMlyge = automationElement_3;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && a2kLDM6fmt3 != null)
		{
			a2kLDM6fmt3.Dispose();
		}
		if (disposing)
		{
			int num = 0;
			if (!lTECoEFZAjOPhSjHGdST())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (SwkLDAnbubm != null)
			{
				SwkLDAnbubm.Dispose();
				SwkLDAnbubm = null;
			}
		}
		if (RKALDfAwi5X != null)
		{
			foreach (Form item in RKALDfAwi5X)
			{
				item.Dispose();
			}
			RKALDfAwi5X = null;
		}
		base.Dispose(disposing);
	}

	private void LJgLDmyonVL()
	{
		int num = 1;
		while (true)
		{
			a2kLDM6fmt3 = new Container();
			int num2 = 0;
			if (!lTECoEFZAjOPhSjHGdST())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			hV7LDOd79KT = new Timer(a2kLDM6fmt3);
			SuspendLayout();
			hV7LDOd79KT.Interval = 300;
			hV7LDOd79KT.Enabled = true;
			hV7LDOd79KT.Tick += wFCLDrX6N1b;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "QuickerWindowSelector";
			Text = "QuickerWindowSelector";
			base.Load += ud2LDxKJrEY;
			ResumeLayout(false);
			return;
		}
	}

	public QTP3xxM50biGA830fZg()
	{
		base.TopMost = true;
		base.FormBorderStyle = FormBorderStyle.None;
		base.StartPosition = FormStartPosition.Manual;
		base.ImeMode = ImeMode.Disable;
		DoubleBuffered = true;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		base.Left = -1000;
		base.Top = -1000;
		base.Width = 1;
		base.Height = 1;
		SetStyle(ControlStyles.DoubleBuffer, true);
		SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		SetStyle(ControlStyles.UserPaint, true);
		LJgLDmyonVL();
		BackColor = Color.LimeGreen;
		base.TransparencyKey = Color.LimeGreen;
		base.TopMost = true;
		F9GLDU3FKjC.xCULAKutXGc(QkxLDKMH4ap);
	}

	private void QkxLDKMH4ap(object sender, MouseEventArgs e)
	{
		if (e is AppMouseEventArgs e2)
		{
			e2.Handled = true;
		}
		F9GLDU3FKjC.Stop();
		CUyLDnuPv2T(CyELDlMS6Il);
		if (ebeLDiEHJcp != IntPtr.Zero)
		{
			DZeLDDkhXgT(SwkLDAnbubm.FromHandle(NativeMethods.GetRootWindow(ebeLDiEHJcp)));
		}
		Close();
	}

	private void ud2LDxKJrEY(object sender, EventArgs e)
	{
		F9GLDU3FKjC.Start();
	}

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);
		F9GLDU3FKjC.Stop();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
	}

	private void wFCLDrX6N1b(object sender, EventArgs e)
	{
		zVGLDpTe2ev();
	}

	private void zVGLDpTe2ev()
	{
		if (!User32.GetCursorPos(out var lpPoint))
		{
			return;
		}
		IntPtr intPtr = User32.WindowFromPoint(lpPoint);
		if (!(intPtr == base.Handle) && !(intPtr == User32.GetDesktopWindow()))
		{
			if (RKALDfAwi5X != null)
			{
				foreach (Form item in RKALDfAwi5X)
				{
					if (item.Handle == intPtr)
					{
						return;
					}
				}
			}
			if (lTECoEFZAjOPhSjHGdST())
			{
				switch (0)
				{
				}
			}
			try
			{
				if (intPtr != ebeLDiEHJcp)
				{
					ebeLDiEHJcp = intPtr;
					IntPtr rootWindow = NativeMethods.GetRootWindow(ebeLDiEHJcp);
					if (rootWindow != KggLD3AeUXS)
					{
						KggLD3AeUXS = rootWindow;
						SwkLDAnbubm.FromHandle(rootWindow);
					}
				}
				AutomationElement automationElement = SwkLDAnbubm.FromPoint(lpPoint);
				if (automationElement == null)
				{
					return;
				}
				int num2 = default(int);
				while (automationElement.Properties.NativeWindowHandle.IsSupported && (automationElement.Properties.NativeWindowHandle.Value == base.Handle || automationElement.Properties.NativeWindowHandle.Value == SwkLDAnbubm.GetDesktop().Properties.NativeWindowHandle.Value))
				{
					User32.MoveWindow(base.Handle, -3000, -3000, 1, 1, true);
					int num = 0;
					if (KDdNIKFZ2hG9K5bFoPkq != null)
					{
						num = num2;
					}
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
				}
				CyELDlMS6Il = automationElement;
				Rectangle boundingRectangle = automationElement.BoundingRectangle;
				vAdLDBxrAJG(boundingRectangle);
				UFQLDFeYL4B = true;
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		User32.MoveWindow(base.Handle, -3000, -3000, 1, 1, true);
	}

	private void vAdLDBxrAJG(Rectangle rectangle_0)
	{
        Form form = default;
		int num = default(int);
		if (RKALDfAwi5X == null)
		{
			RKALDfAwi5X = new List<Form>(4);
			num = 0;
			goto IL_0019;
		}
		goto IL_009b;
		IL_00d8:
		int num2 = default(int);
		User32.MoveWindow(RKALDfAwi5X[1].Handle, rectangle_0.Left, rectangle_0.Top, rectangle_0.Width, num2, true);
		User32.MoveWindow(RKALDfAwi5X[2].Handle, rectangle_0.Right - 1, rectangle_0.Top, num2, rectangle_0.Height, true);
		User32.MoveWindow(RKALDfAwi5X[3].Handle, rectangle_0.Left, rectangle_0.Bottom - 1, rectangle_0.Width, num2, true);
		foreach (Form item in RKALDfAwi5X)
		{
			item.Refresh();
		}
		return;
		IL_0019:
		form = default(Form);
		int num3;
		if (num < 4)
		{
			form = new Form();
			form.TopMost = true;
			form.FormBorderStyle = FormBorderStyle.None;
			form.StartPosition = FormStartPosition.Manual;
			form.Left = -3000;
			form.Top = -3000;
			form.Width = 1;
			form.Height = 1;
			form.BackColor = Color.Red;
			num3 = 0;
			if (KDdNIKFZ2hG9K5bFoPkq != null)
			{
				goto IL_0074;
			}
			goto IL_008c;
		}
		goto IL_009b;
		IL_009b:
		num2 = 1;
		User32.MoveWindow(RKALDfAwi5X[0].Handle, rectangle_0.Left, rectangle_0.Top, 1, rectangle_0.Height, true);
		num3 = 1;
		if (KDdNIKFZ2hG9K5bFoPkq != null)
		{
			goto IL_008c;
		}
		goto IL_00d8;
		IL_0074:
		RKALDfAwi5X.Add(form);
		form.Show();
		num++;
		goto IL_0019;
		IL_008c:
		switch (num3)
		{
		case 1:
			goto IL_00d8;
		}
		goto IL_0074;
	}

	public static AutomationElement zWOLDQ5v8tH()
	{
		QTP3xxM50biGA830fZg qTP3xxM50biGA830fZg = new QTP3xxM50biGA830fZg();
		qTP3xxM50biGA830fZg.ShowDialog();
		qTP3xxM50biGA830fZg.Dispose();
		return qTP3xxM50biGA830fZg.L1XLDjRrVi1();
	}

	internal static bool lTECoEFZAjOPhSjHGdST()
	{
		return KDdNIKFZ2hG9K5bFoPkq == null;
	}
}
