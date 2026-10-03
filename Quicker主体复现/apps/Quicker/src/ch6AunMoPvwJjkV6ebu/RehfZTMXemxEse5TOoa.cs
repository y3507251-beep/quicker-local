using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using lUCjKTMbZVPP5v56los;
using PInvoke;
using Quicker.ScreenSelectLib.Processors;
using Quicker.Utilities.Win32;

namespace ch6AunMoPvwJjkV6ebu;

[DesignerCategory("")]
internal class RehfZTMXemxEse5TOoa : Form
{
	[CompilerGenerated]
	private IntPtr CRXLdHytQRX;

	private IContainer t3HLd1kbbB6;

	private Timer V4cLdbWk5Nh;

	private bool ABfLd6gpuKc;

	private lPxZYOM8ws3NP42wph0 T0KLdXWo9iB = new lPxZYOM8ws3NP42wph0();

	private IntPtr Cj5LdmnZxvP = IntPtr.Zero;

	private readonly WindowDetectLevel vWlLdKkw9f3;

	internal static RehfZTMXemxEse5TOoa U4ugN9FZSFX2Q3suhBQ6;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr mlQLdkv8yPr()
	{
		return CRXLdHytQRX;
	}

	[SpecialName]
	[CompilerGenerated]
	public void EXrLdGo4PSB(IntPtr intptr_2)
	{
		CRXLdHytQRX = intptr_2;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && t3HLd1kbbB6 != null)
		{
			t3HLd1kbbB6.Dispose();
		}
		base.Dispose(disposing);
	}

	private void n2cLdcJcTt1()
	{
		t3HLd1kbbB6 = new Container();
		V4cLdbWk5Nh = new Timer(t3HLd1kbbB6);
		SuspendLayout();
		if (YAk33VFZwpkoNFjS1TN3())
		{
			switch (0)
			{
			}
		}
		V4cLdbWk5Nh.Enabled = true;
		V4cLdbWk5Nh.Tick += mT6LdeV9GMd;
		base.AutoScaleDimensions = new SizeF(9f, 18f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(800, 450);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "QuickerWindowSelector";
		Text = "QuickerWindowSelector";
		base.Load += YqWLdhwFqpL;
		ResumeLayout(false);
	}

	public RehfZTMXemxEse5TOoa(WindowDetectLevel windowDetectLevel_1)
	{
		vWlLdKkw9f3 = windowDetectLevel_1;
		base.TopMost = true;
		base.FormBorderStyle = FormBorderStyle.None;
		base.StartPosition = FormStartPosition.Manual;
		base.ImeMode = ImeMode.Disable;
		DoubleBuffered = true;
		base.ShowInTaskbar = false;
		base.KeyPreview = true;
		SetStyle(ControlStyles.DoubleBuffer, true);
		SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		SetStyle(ControlStyles.UserPaint, true);
		SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		SetStyle(ControlStyles.Opaque, false);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		base.Load += fDkLdWN8Ldc;
		n2cLdcJcTt1();
		BackColor = Color.LimeGreen;
		base.TransparencyKey = Color.LimeGreen;
		base.TopMost = true;
		base.MouseDown += L2HLd9hKJF4;
		T0KLdXWo9iB.xCULAKutXGc(HrELdZw276P);
		base.KeyDown += AitLdVIXoTx;
	}

	private void AitLdVIXoTx(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			User32.ReleaseCapture();
			EXrLdGo4PSB(IntPtr.Zero);
			Close();
		}
	}

	private void HrELdZw276P(object sender, MouseEventArgs e)
	{
		T0KLdXWo9iB.Stop();
		if (e.Button == MouseButtons.Left)
		{
			EXrLdGo4PSB(Cj5LdmnZxvP);
		}
		else
		{
			EXrLdGo4PSB(IntPtr.Zero);
		}
		Close();
	}

	private void L2HLd9hKJF4(object sender, MouseEventArgs e)
	{
		User32.ReleaseCapture();
		if (e.Button == MouseButtons.Left)
		{
			EXrLdGo4PSB(Cj5LdmnZxvP);
		}
		else
		{
			EXrLdGo4PSB(IntPtr.Zero);
		}
		Close();
	}

	private void YqWLdhwFqpL(object sender, EventArgs e)
	{
		User32.SetCapture(base.Handle);
		T0KLdXWo9iB.Start();
	}

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);
		T0KLdXWo9iB.Stop();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (!ABfLd6gpuKc)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		using Pen pen = new Pen(Color.OrangeRed, 8f);
		pen.Alignment = PenAlignment.Inset;
		Rectangle clientRectangle = base.ClientRectangle;
		clientRectangle.Inflate(-2, -2);
		graphics.DrawLines(pen, new Point[5]
		{
			new Point(clientRectangle.Left, clientRectangle.Top),
			new Point(clientRectangle.Right, clientRectangle.Top),
			new Point(clientRectangle.Right, clientRectangle.Bottom),
			new Point(clientRectangle.Left, clientRectangle.Bottom),
			new Point(clientRectangle.Left, clientRectangle.Top)
		});
	}

	private void mT6LdeV9GMd(object sender, EventArgs e)
	{
		eCjLdYP984E();
	}

	private void eCjLdYP984E()
	{
		if (!User32.GetCursorPos(out var lpPoint))
		{
			return;
		}
		IntPtr intPtr = User32.WindowFromPoint(lpPoint);
		if (intPtr == base.Handle)
		{
			ABfLd6gpuKc = false;
			Refresh();
			return;
		}
		intPtr = (Cj5LdmnZxvP = FgoLdIsM2xW(intPtr));
		if (!YAk33VFZwpkoNFjS1TN3())
		{
			switch (0)
			{
			}
		}
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
		User32.MoveWindow(base.Handle, windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top, true);
		Refresh();
		ABfLd6gpuKc = true;
	}

	private IntPtr FgoLdIsM2xW(IntPtr intptr_2)
	{
		switch (vWlLdKkw9f3)
		{
		case WindowDetectLevel.TheWindow:
			return intptr_2;
		case WindowDetectLevel.RootWindowOfSameProcess:
			return WindowHelper.GetRootWindowWithSameProcess(intptr_2);
		case WindowDetectLevel.RootWindow:
		{
			IntPtr ancestor = User32.GetAncestor(intptr_2, User32.GetAncestorFlags.GA_ROOT);
			if (ancestor != IntPtr.Zero)
			{
				return ancestor;
			}
			break;
		}
		case WindowDetectLevel.Control:
			throw new InvalidOperationException("不支持此操作。");
		}
		return intptr_2;
	}

	public static IntPtr SelectWindow(WindowDetectLevel detectLevel)
	{
		RehfZTMXemxEse5TOoa rehfZTMXemxEse5TOoa = new RehfZTMXemxEse5TOoa(detectLevel);
		rehfZTMXemxEse5TOoa.ShowDialog();
		rehfZTMXemxEse5TOoa.Dispose();
		return rehfZTMXemxEse5TOoa.mlQLdkv8yPr();
	}

	[CompilerGenerated]
	private void fDkLdWN8Ldc(object sender, EventArgs e)
	{
		Focus();
	}

	internal static bool YAk33VFZwpkoNFjS1TN3()
	{
		return U4ugN9FZSFX2Q3suhBQ6 == null;
	}
}
