using System;
using System.Runtime.CompilerServices;
using IOn6RhAJdTUbfGy6gwn;

namespace DotNetKit.Windows.Controls;

public class AutoCompleteComboBoxSetting
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public Func<object, string> wnPvy0nnnRo;

		public string IiOvyCJNuOi;

		internal static _003C_003Ec__DisplayClass0_0 yxvWqwcDpQCjMeKc8ZEj;

		internal bool ACCvyJIaRFo(object item)
		{
			return tkxn6HAKAgMT8gvXbyh.IsMatch(wnPvy0nnnRo(item), IiOvyCJNuOi);
		}

		internal static bool l19YHBcDXOjOp0fPX45D()
		{
			return yxvWqwcDpQCjMeKc8ZEj == null;
		}
	}

	private static AutoCompleteComboBoxSetting K1kJz0abdK;

	internal static AutoCompleteComboBoxSetting DnR7Xm3ZrPDOWYOhcO5;

	public virtual int MaxSuggestionCount => 100;

	public virtual TimeSpan Delay => TimeSpan.FromMilliseconds(300.0);

	public static AutoCompleteComboBoxSetting Default
	{
		get
		{
			return K1kJz0abdK;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			K1kJz0abdK = value;
		}
	}

	public virtual Predicate<object> GetFilter(string query, Func<object, string> stringFromItem)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.wnPvy0nnnRo = stringFromItem;
		_003C_003Ec__DisplayClass0_.IiOvyCJNuOi = query;
		return _003C_003Ec__DisplayClass0_.ACCvyJIaRFo;
	}

	static AutoCompleteComboBoxSetting()
	{
		K1kJz0abdK = new AutoCompleteComboBoxSetting();
	}

	internal static bool Co5s9i35En9nQYPdG0T()
	{
		return DnR7Xm3ZrPDOWYOhcO5 == null;
	}
}
