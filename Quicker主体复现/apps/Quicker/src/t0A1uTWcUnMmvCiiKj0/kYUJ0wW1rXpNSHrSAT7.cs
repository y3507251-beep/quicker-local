using System.Runtime.CompilerServices;
using System.Windows.Media;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View;

namespace t0A1uTWcUnMmvCiiKj0;

internal class kYUJ0wW1rXpNSHrSAT7 : BaseTextTool
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public Color? BAqvGAeRqWU;

		public kYUJ0wW1rXpNSHrSAT7 QFdvGOksb3W;

		public Color? kXxvGFTlsQK;

		private static _003C_003Ec__DisplayClass2_0 lwyODdc8RpQRdTpS8KlC;

		internal void WO3vGM2eVn6()
		{
			ColorSelectorWindow colorSelectorWindow = new ColorSelectorWindow(BAqvGAeRqWU)
			{
				Owner = QFdvGOksb3W.Context.ParentWindow
			};
			colorSelectorWindow.ShowDialog();
			kXxvGFTlsQK = colorSelectorWindow.SelectedColor;
		}

		internal static bool BREesuc8gUMOSxlBnAYA()
		{
			return lwyODdc8RpQRdTpS8KlC == null;
		}
	}

	private readonly bool Ln1tSx62RpI;

	internal static kYUJ0wW1rXpNSHrSAT7 G5tHB9QpteN4ZVtVLlTy;

	public kYUJ0wW1rXpNSHrSAT7(TextToolContext textToolContext_1, bool bool_2 = false)
		: base(textToolContext_1)
	{
		Ln1tSx62RpI = bool_2;
	}

	public override void OnMouseUp(object sender)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.QFdvGOksb3W = this;
		base.OnMouseUp(sender);
		int num = 0;
		if (G5tHB9QpteN4ZVtVLlTy != null)
		{
			int num2 = default(int);
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			string text = base.Context.TextControl.GetSelectedText();
			if (string.IsNullOrEmpty(text))
			{
				text = base.Context.TextControl.GetAllText();
			}
			_003C_003Ec__DisplayClass2_.kXxvGFTlsQK = null;
			_003C_003Ec__DisplayClass2_.BAqvGAeRqWU = null;
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					_003C_003Ec__DisplayClass2_.BAqvGAeRqWU = ColorHelper.StringToColor(text);
				}
				catch
				{
				}
			}
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass2_.WO3vGM2eVn6);
			if (_003C_003Ec__DisplayClass2_.kXxvGFTlsQK.HasValue)
			{
				Color value = _003C_003Ec__DisplayClass2_.kXxvGFTlsQK.Value;
				string text2 = (Ln1tSx62RpI ? $"#{value.A:X2}{value.R:X2}{value.G:X2}{value.B:X2}" : $"#{value.R:X2}{value.G:X2}{value.B:X2}");
				base.Context.ProcessSelectedTextFunc(text2, false);
				num = 0;
				if (ciwCYEQpS21EcrspX79I())
				{
					return;
				}
				continue;
			}
			CancelSelection("");
			return;
		}
	}

	internal static bool ciwCYEQpS21EcrspX79I()
	{
		return G5tHB9QpteN4ZVtVLlTy == null;
	}
}
