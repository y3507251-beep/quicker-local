using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using log4net;
using Quicker.Actions.XActions.Storage;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Converters;
using Quicker.Utilities.UI.Wpf;
using Quicker.View;
using Quicker.View.Controls;
using t8SGKhhgLWTgeqjGcrq;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.Modules.Tables;

public class TableManageWindow : HandyControl.Controls.Window, IComponentConnector, IStyleConnector, iTHRNJY2ZQQokysD4pN, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xRKvscIYsyq;

		public static Func<DataGridColumn, double> qZEvsVxM4YG;

		public static Func<MenuItem, bool> VyivsZ2lmMR;

		public static Func<MenuItem, bool> qYjvs9p790R;

		public static Predicate<DataGridClipboardCellContent> r82vsh8geGq;

		internal static _003C_003Ec ztnj49cRbmhHhlqYcHcS;

		static _003C_003Ec()
		{
			xRKvscIYsyq = new _003C_003Ec();
		}

		internal double HtmvsaA0RIS(DataGridColumn x)
		{
			return x.ActualWidth;
		}

		internal bool J8Qvs7I1n44(MenuItem x)
		{
			return x.Name == "MenuCopyMode";
		}

		internal bool VJfvsRkBjuo(MenuItem x)
		{
			return x.Name == "MenuCopyMode";
		}

		internal bool mxZvsqnNMhj(DataGridClipboardCellContent c)
		{
			return true;
		}

		internal static bool F6E9G1cRqBTT4ChtqKCN()
		{
			return ztnj49cRbmhHhlqYcHcS == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public TableManageWindow GHMvsYmLLe6;

		public string t20vsIClMQx;

		internal static _003C_003Ec__DisplayClass16_0 PmMioCcRlIuMnpAl8Xc8;

		internal void G9ivsecK5Ct(object sender, RoutedEventArgs e)
		{
			try
			{
				_003C_003Ec__DisplayClass16_1 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_1
				{
					lAMvsHe1GDl = this
				};
				Hyperlink hyperlink = (Hyperlink)sender;
				_003C_003Ec__DisplayClass16_.aLbvskIIPfa = ((Run)hyperlink.Inlines.FirstInline).Text;
				object dataContext = ((TextBlock)hyperlink.Parent).DataContext;
				_003C_003Ec__DisplayClass16_.OojvsGQG6Kj = new Dictionary<string, object>();
				_003C_003Ec__DisplayClass16_.pPfvssB1Hgx = null;
				if (dataContext is DataRowView dataRowView)
				{
					_003C_003Ec__DisplayClass16_.pPfvssB1Hgx = dataRowView;
					foreach (DataColumn column in dataRowView.Row.Table.Columns)
					{
						_003C_003Ec__DisplayClass16_.OojvsGQG6Kj[column.ColumnName] = dataRowView[column.ColumnName];
					}
				}
				else if (dataContext != null)
				{
					int num3 = default(int);
					while (true)
					{
						IL_0149:
						PropertyInfo[] properties = dataContext.GetType().GetProperties();
						for (int num = 0; num < properties.Length; num++)
						{
							int num2 = 1;
							if (!Cr9h9pcRZk3AN1RZIsZY())
							{
								goto IL_0124;
							}
							goto IL_0128;
							IL_0124:
							num2 = num3;
							goto IL_0128;
							IL_0128:
							while (true)
							{
								switch (num2)
								{
								case 1:
									goto IL_00f4;
								default:
									goto end_IL_0128;
								case 2:
									break;
								}
								goto IL_0149;
								IL_00f4:
								PropertyInfo propertyInfo = properties[num];
								_003C_003Ec__DisplayClass16_.OojvsGQG6Kj[propertyInfo.Name] = propertyInfo.GetValue(dataContext);
								num2 = 0;
								if (PmMioCcRlIuMnpAl8Xc8 == null)
								{
									continue;
								}
								goto IL_0124;
								continue;
								end_IL_0128:
								break;
							}
						}
						break;
					}
				}
				string text = (string.IsNullOrEmpty(t20vsIClMQx) ? _003C_003Ec__DisplayClass16_.aLbvskIIPfa : string.Format(t20vsIClMQx, _003C_003Ec__DisplayClass16_.aLbvskIIPfa));
				if (text.StartsWith("sp:"))
				{
					_003C_003Ec__DisplayClass16_.sp = text.Substring("sp:".Length);
					if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass16_.sp))
					{
						Task.Run((Action)_003C_003Ec__DisplayClass16_.WIwvsWkVg7r);
					}
				}
				else if (!string.IsNullOrEmpty(text))
				{
					AppHelper.TryOpenUrlOrFile(text);
					e.Handled = true;
				}
				else
				{
					AppHelper.ShowWarning("要打开的内容为空。");
				}
				e.Handled = true;
			}
			catch (Exception ex)
			{
				trptu14hSb5.Warn("打开单元格链接出错：" + ex.Message, ex);
				AppHelper.ShowWarning("打开单元格链接出错：" + ex.Message);
			}
		}

		internal static bool Cr9h9pcRZk3AN1RZIsZY()
		{
			return PmMioCcRlIuMnpAl8Xc8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_1
	{
		public string aLbvskIIPfa;

		public Dictionary<string, object> OojvsGQG6Kj;

		public DataRowView pPfvssB1Hgx;

		public string sp;

		public _003C_003Ec__DisplayClass16_0 lAMvsHe1GDl;

		internal static _003C_003Ec__DisplayClass16_1 g5kFnicRgNcau0OEsBea;

		internal void WIwvsWkVg7r()
		{
			try
			{
				ActionExecuteContext qPktuWumR2l = lAMvsHe1GDl.GHMvsYmLLe6.QPktuWumR2l;
				object obj;
				if (qPktuWumR2l == null)
				{
					int num = 0;
					if (g5kFnicRgNcau0OEsBea != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					obj = null;
				}
				else
				{
					obj = qPktuWumR2l.RunSp(sp, new Dictionary<string, object>
					{
						{ "input", aLbvskIIPfa },
						{ "row", OojvsGQG6Kj }
					});
				}
				IDictionary<string, object> dictionary = (IDictionary<string, object>)obj;
				if (pPfvssB1Hgx == null || dictionary == null || !dictionary.ContainsKey("changes"))
				{
					return;
				}
				IDictionary<string, object> dictionary2 = VariableHelper.ConvertToDict(dictionary["changes"]);
				if (dictionary2 == null)
				{
					return;
				}
				foreach (KeyValuePair<string, object> item in dictionary2)
				{
					pPfvssB1Hgx[item.Key] = item.Value;
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("执行子程序(" + sp + ")出错：" + ex.Message);
			}
		}

		internal static bool okLDgKcRPLtKW2N5OGyA()
		{
			return g5kFnicRgNcau0OEsBea == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public string z3Wvsbsc6WD;

		internal static _003C_003Ec__DisplayClass17_0 rHNXlPcRUr8ROlKKxLip;

		internal void Cdkvs1wHuV6()
		{
			ImageViewerWindow imageViewerWindow = new ImageViewerWindow(new BitmapImage(new Uri(z3Wvsbsc6WD)))
			{
				ImageFilePath = "",
				Location = ShowWindowLocation.CenterScreen,
				InitialScale = -1.0,
				AutoCloseSeconds = 0.0,
				AutoCloseKey = ""
			};
			if (rHNXlPcRUr8ROlKKxLip != null)
			{
				switch (0)
				{
				}
			}
			if (!string.IsNullOrEmpty(z3Wvsbsc6WD))
			{
				imageViewerWindow.ImageFilePath = z3Wvsbsc6WD;
			}
			imageViewerWindow.Show();
		}

		internal static bool sDQm20cRx87fPqdIW2BU()
		{
			return rHNXlPcRUr8ROlKKxLip == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass43_0
	{
		public DataColumn vkQvsXDE2Fd;

		internal static _003C_003Ec__DisplayClass43_0 PHSQHacRtSP41oN2OvmP;

		internal bool hZYvs6L63MI(TableField x)
		{
			return x.FieldKey == vkQvsXDE2Fd.ColumnName;
		}

		internal static bool VY7hd4cRSx43llFZtpu4()
		{
			return PHSQHacRtSP41oN2OvmP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnAdd_Click_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TableManageWindow _003C_003E4__this;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object iK5RrecRmaGeug1IvJeh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableManageWindow tableManageWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					awaiter = new TableRecordEditWindow(RecordEditMode.Add, tableManageWindow.XFBtueaGZrW, "添加行", tableManageWindow.lK6tuYXqbiQ, 80.0, null, false, tableManageWindow.QPktuWumR2l)
					{
						Owner = tableManageWindow
					}.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						int num2 = 0;
						if (iK5RrecRmaGeug1IvJeh != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool Fds4SDcRsufFPyDFLI61()
		{
			return iK5RrecRmaGeug1IvJeh == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEdit_Click_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TableManageWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object Sm4lqAcR7jBWErYO87Vn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableManageWindow tableManageWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!YOOE0ocR4mIso8i9Oi7t())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					goto IL_00c4;
				}
				DataRow dataRow = ((sender as FrameworkElement)?.Tag as DataRowView)?.Row;
				if (dataRow != null)
				{
					awaiter = tableManageWindow.JYatuP4kshy(dataRow, !tableManageWindow.g47tukWVUQH).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00c4;
				}
				goto end_IL_0010;
				IL_00c4:
				awaiter.GetResult();
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool YOOE0ocR4mIso8i9Oi7t()
		{
			return Sm4lqAcR7jBWErYO87Vn == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItemAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TableManageWindow _003C_003E4__this;

		public DataRow row;

		public bool isReadonly;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object aM2wwycRHusc4CN9Avoc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableManageWindow tableManageWindow = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<bool?> awaiter;
					if (num != 0)
					{
						awaiter = new TableRecordEditWindow(RecordEditMode.Edit, tableManageWindow.XFBtueaGZrW, "编辑行", tableManageWindow.lK6tuYXqbiQ, 80.0, row, isReadonly, tableManageWindow.QPktuWumR2l)
						{
							Owner = tableManageWindow
						}.MjdLOXIjD10(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<bool?>);
						num = -1;
						_003C_003E1__state = -1;
					}
					bool valueOrDefault = awaiter.GetResult() == true;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("保存数据出错：" + ex.Message);
					trptu14hSb5.Warn("编辑表格数据出错。" + ex.Message, ex);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool fN6OfycRzSQMMTWd4vMi()
		{
			return aM2wwycRHusc4CN9Avoc == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListViewItem_MouseDoubleClick_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TableManageWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object mYsTo0cgQMq9nKl8YnLE;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableManageWindow tableManageWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a7;
				}
				DataRow row = (((ListViewItem)sender).DataContext as DataRowView).Row;
				if (row != null)
				{
					awaiter = tableManageWindow.JYatuP4kshy(row, !tableManageWindow.g47tukWVUQH).GetAwaiter();
					if (!Ua1INDcgFMv2UBpSnHv1())
					{
						switch (0)
						{
						}
					}
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a7;
				}
				goto end_IL_000e;
				IL_00a7:
				awaiter.GetResult();
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool Ua1INDcgFMv2UBpSnHv1()
		{
			return mYsTo0cgQMq9nKl8YnLE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuItem_CopyCreate_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TableManageWindow _003C_003E4__this;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object HDTPPxcgWLHXWGyJJj3Z;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableManageWindow tableManageWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0256;
				}
				if (tableManageWindow.TheGrid.SelectedCells.Count > 0)
				{
					int num2 = 0;
					if (HDTPPxcgWLHXWGyJJj3Z != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					HashSet<DataRow> hashSet = default(HashSet<DataRow>);
					while (true)
					{
						switch (num2)
						{
						default:
							do
							{
								hashSet = new HashSet<DataRow>();
								num2 = 1;
							}
							while (!V0v1BhcgyFiORVOaxVu2());
							continue;
						case 1:
							break;
						}
						break;
					}
					IEnumerator<DataGridCellInfo> enumerator = tableManageWindow.TheGrid.SelectedCells.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Item is DataRowView dataRowView)
							{
								hashSet.Add(dataRowView.Row);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator?.Dispose();
						}
					}
					if (hashSet.Count > 0)
					{
						DataRow dataRow = tableManageWindow.XFBtueaGZrW.NewRow();
						DataRow dataRow2 = hashSet.First();
						IEnumerator enumerator2 = tableManageWindow.XFBtueaGZrW.Columns.GetEnumerator();
						try
						{
							int num5 = default(int);
							while (enumerator2.MoveNext())
							{
								_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0
								{
									vkQvsXDE2Fd = (DataColumn)enumerator2.Current
								};
								int num4 = 0;
								if (!V0v1BhcgyFiORVOaxVu2())
								{
									num4 = num5;
								}
								switch (num4)
								{
								}
								if (!_003C_003Ec__DisplayClass43_.vkQvsXDE2Fd.AutoIncrement)
								{
									TableField tableField = tableManageWindow.lK6tuYXqbiQ?.Fields.FirstOrDefault(_003C_003Ec__DisplayClass43_.hZYvs6L63MI);
									if (!_003C_003Ec__DisplayClass43_.vkQvsXDE2Fd.Unique || (tableField != null && tableField.InputMethod != Quicker.Public.Forms.InputMethod.None))
									{
										dataRow[_003C_003Ec__DisplayClass43_.vkQvsXDE2Fd.ColumnName] = dataRow2[_003C_003Ec__DisplayClass43_.vkQvsXDE2Fd];
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator2 is IDisposable disposable)
							{
								disposable.Dispose();
							}
						}
						awaiter = new TableRecordEditWindow(RecordEditMode.Add, tableManageWindow.XFBtueaGZrW, "添加行", tableManageWindow.lK6tuYXqbiQ, 80.0, dataRow, false, tableManageWindow.QPktuWumR2l)
						{
							Owner = tableManageWindow
						}.MjdLOXIjD10(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0256;
					}
				}
				goto end_IL_0010;
				IL_0256:
				awaiter.GetResult();
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool V0v1BhcgyFiORVOaxVu2()
		{
			return HDTPPxcgWLHXWGyJJj3Z == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRow_DoubleClick_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TableManageWindow _003C_003E4__this;

		public MouseButtonEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		internal static object yEOEBYcgXs2n2VEna0Id;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableManageWindow tableManageWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				int num2;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					num2 = 1;
					if (yEOEBYcgXs2n2VEna0Id != null)
					{
						goto IL_00c3;
					}
					goto IL_00c7;
				}
				if (((DataGridRow)sender)?.DataContext is DataRowView { Row: { } row })
				{
					awaiter = tableManageWindow.JYatuP4kshy(row, !tableManageWindow.g47tukWVUQH).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00de;
				}
				goto end_IL_0010;
				IL_00de:
				awaiter.GetResult();
				e.Handled = true;
				goto end_IL_0010;
				IL_00c3:
				int num3 = default(int);
				num2 = num3;
				goto IL_00c7;
				IL_00c7:
				while (true)
				{
					switch (num2)
					{
					case 1:
						goto IL_00aa;
					}
					break;
					IL_00aa:
					_003C_003Eu__1 = default(TaskAwaiter);
					num2 = 0;
					if (XfKOq6cg2HpAAxwN4kGc())
					{
						continue;
					}
					goto IL_00c3;
				}
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00de;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool XfKOq6cg2HpAAxwN4kGc()
		{
			return yEOEBYcgXs2n2VEna0Id == null;
		}
	}

	private readonly DataTable XFBtueaGZrW;

	private readonly TableDef lK6tuYXqbiQ;

	private readonly bool guFtuIcKkvl;

	private readonly ActionExecuteContext QPktuWumR2l;

	private bool g47tukWVUQH;

	private GridSelectionMode HjltuGchDgi;

	[CompilerGenerated]
	private string x01tusboXTd;

	[CompilerGenerated]
	private bool? K6qtuHETMEV;

	private static readonly ILog trptu14hSb5;

	[CompilerGenerated]
	private CancellationTokenRegistration? rbntubiSkFo;

	internal TextBlock TxtHelpText;

	internal DataGrid TheGrid;

	internal MenuItem MenuCopyMode;

	internal DataGridTemplateColumn ogQtu62p9PL;

	internal Button BtnAdd;

	internal FilterBoxControl FilterControl;

	internal Button BtnRestore;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool dgHtuXZ9Bi5;

	private static TableManageWindow A9aQxgQ2ZZlC8O3oaylO;

	public string WinSizeStr
	{
		[CompilerGenerated]
		get
		{
			return x01tusboXTd;
		}
		[CompilerGenerated]
		set
		{
			x01tusboXTd = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return K6qtuHETMEV;
		}
		[CompilerGenerated]
		set
		{
			K6qtuHETMEV = value;
		}
	}

	public string HelpText
	{
		get
		{
			return TxtHelpText.Text;
		}
		set
		{
			TxtHelpText.Text = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return rbntubiSkFo;
		}
		[CompilerGenerated]
		set
		{
			rbntubiSkFo = value;
		}
	}

	public TableManageWindow(DataTable table, TableDef tableDef, bool isReadOnly, GridSelectionMode selectionMode, ActionExecuteContext actionExecuteContext)
	{
		XFBtueaGZrW = table;
		XFBtueaGZrW.AcceptChanges();
		lK6tuYXqbiQ = tableDef;
		guFtuIcKkvl = isReadOnly;
		QPktuWumR2l = actionExecuteContext;
		InitializeComponent();
		TheGrid.ItemsSource = XFBtueaGZrW.DefaultView;
		WDntuSl1eZ8(selectionMode);
		if (isReadOnly)
		{
			TheGrid.IsReadOnly = true;
			TheGrid.CanUserAddRows = false;
			TheGrid.CanUserDeleteRows = false;
			BtnAdd.Visibility = Visibility.Collapsed;
			BtnCancel.Content = "关闭(_C)";
			if (HjltuGchDgi == GridSelectionMode.Cells)
			{
				BtnOk.Visibility = Visibility.Collapsed;
			}
			BtnRestore.Visibility = Visibility.Collapsed;
			ogQtu62p9PL.Visibility = Visibility.Collapsed;
		}
		else
		{
			g47tukWVUQH = true;
			if (tableDef != null && tableDef.Fields.HasData())
			{
				TheGrid.IsReadOnly = true;
			}
			else
			{
				TheGrid.IsReadOnly = false;
				TheGrid.CanUserAddRows = false;
			}
		}
		E0XtuuiaOen();
		base.Loaded += anXtu2FhLsN;
		base.Closing += Fibtuvk4Ki8;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void Fibtuvk4Ki8(object sender, CancelEventArgs e)
	{
		if (!Result.HasValue && XFBtueaGZrW.GetChanges() != null)
		{
			switch (MessageBoxHelper.Show(this, "数据已修改，是否需要保存？", "Quicker", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Yes))
			{
			case MessageBoxResult.Cancel:
				e.Cancel = true;
				if (N2ARgYQ25Nln3ucJFpU3())
				{
					switch (0)
					{
					}
				}
				return;
			case MessageBoxResult.Yes:
				EAXtu8ClCMK(sender, null);
				break;
			default:
				try
				{
					XFBtueaGZrW.RejectChanges();
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("无法撤销数据更改。" + ex.Message, true);
					return;
				}
				break;
			}
		}
		XFBtueaGZrW.DefaultView.RowFilter = null;
	}

	private void WDntuSl1eZ8(GridSelectionMode gridSelectionMode_0)
	{
		HjltuGchDgi = gridSelectionMode_0;
		switch (HjltuGchDgi)
		{
		case GridSelectionMode.Cells:
			TheGrid.SelectionUnit = DataGridSelectionUnit.CellOrRowHeader;
			break;
		case GridSelectionMode.OneRow:
		case GridSelectionMode.OneRowRequired:
			TheGrid.SelectionUnit = DataGridSelectionUnit.FullRow;
			TheGrid.SelectionMode = DataGridSelectionMode.Single;
			break;
		case GridSelectionMode.Rows:
		case GridSelectionMode.RowsRequired:
			TheGrid.SelectionUnit = DataGridSelectionUnit.FullRow;
			TheGrid.SelectionMode = DataGridSelectionMode.Extended;
			break;
		}
	}

	private void anXtu2FhLsN(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrEmpty(WinSizeStr))
		{
			IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, ShowWindowLocation.CenterScreen, WinSizeStr, false);
		}
		if (!(TheGrid.Columns.Sum(_003C_003Ec.qZEvsVxM4YG ?? (_003C_003Ec.qZEvsVxM4YG = _003C_003Ec.xRKvscIYsyq.HtmvsaA0RIS)) > TheGrid.ActualWidth))
		{
			return;
		}
		double num = 2.0 * TheGrid.ActualWidth / (double)TheGrid.Columns.Count;
		foreach (DataGridColumn column in TheGrid.Columns)
		{
			if (column.ActualWidth > num)
			{
				column.Width = new DataGridLength(num);
			}
		}
	}

	private void E0XtuuiaOen()
	{
		TableDef tableDef = lK6tuYXqbiQ;
		if (tableDef != null && tableDef.Fields?.HasData() == true)
		{
			TheGrid.AutoGenerateColumns = false;
			int num = 0;
			IEnumerator<TableField> enumerator = lK6tuYXqbiQ.Fields.GetEnumerator();
			int num2 = 0;
			if (!N2ARgYQ25Nln3ucJFpU3())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			try
			{
				int num5 = default(int);
				while (enumerator.MoveNext())
				{
					TableField current = enumerator.Current;
					if (current.ShowInList)
					{
						DataGridColumn dataGridColumn = qxVtuNy8WvK(current);
						if (current.ColumnWidth > 10.0)
						{
							dataGridColumn.Width = current.ColumnWidth;
						}
						HeaderTextBlock headerTextBlock = new HeaderTextBlock();
						headerTextBlock.Text = current.Label;
						int num4 = 0;
						if (!N2ARgYQ25Nln3ucJFpU3())
						{
							num4 = num5;
						}
						switch (num4)
						{
						}
						headerTextBlock.ToolTip = current.FieldKey;
						dataGridColumn.Header = headerTextBlock;
						TheGrid.Columns.Insert(num++, dataGridColumn);
					}
				}
				return;
			}
			finally
			{
				enumerator?.Dispose();
			}
		}
		TheGrid.AutoGenerateColumns = true;
	}

	private DataGridColumn qxVtuNy8WvK(TableField tableField_0)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.GHMvsYmLLe6 = this;
		if (tableField_0.QuickerVarType == VarType.DateTime)
		{
			return new DataGridTextColumn
			{
				Binding = new Binding(tableField_0.FieldKey)
				{
					StringFormat = "{0:yyyy-MM-dd HH:mm:ss}"
				}
			};
		}
		if (tableField_0.ExtraSettings.HasLineStartWith("image:"))
		{
			string lineStartWith = tableField_0.ExtraSettings.GetLineStartWith("image:");
			int num = 0;
			if (!N2ARgYQ25Nln3ucJFpU3())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				double result = 50.0;
				if (lineStartWith.Length > "image:".Length)
				{
					double.TryParse(lineStartWith.Substring("image:".Length), out result);
				}
				DataGridTemplateColumn dataGridTemplateColumn = new DataGridTemplateColumn();
				DataTemplate dataTemplate = new DataTemplate();
				FrameworkElementFactory frameworkElementFactory = new FrameworkElementFactory(typeof(Image));
				frameworkElementFactory.SetValue(FrameworkElement.WidthProperty, result);
				frameworkElementFactory.SetValue(FrameworkElement.HeightProperty, result);
				frameworkElementFactory.SetValue(Image.StretchProperty, Stretch.Uniform);
				Binding binding = new Binding(tableField_0.FieldKey);
				ImageResizeConverter converter = new ImageResizeConverter
				{
					DecodePixelWidth = (int)result,
					DecodePixelHeight = 0
				};
				binding.Converter = converter;
				frameworkElementFactory.SetBinding(Image.SourceProperty, binding);
				Binding binding2 = new Binding(tableField_0.FieldKey);
				frameworkElementFactory.SetBinding(FrameworkElement.TagProperty, binding2);
				frameworkElementFactory.AddHandler(UIElement.PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(GnltuJ3oNmO));
				dataTemplate.VisualTree = frameworkElementFactory;
				dataGridTemplateColumn.CellTemplate = dataTemplate;
				return dataGridTemplateColumn;
			}
			}
		}
		if (tableField_0.ExtraSettings.HasLineStartWith("link:"))
		{
			string lineStartWith2 = tableField_0.ExtraSettings.GetLineStartWith("link:");
			_003C_003Ec__DisplayClass16_.t20vsIClMQx = lineStartWith2.Substring("link:".Length);
			DataGridTemplateColumn dataGridTemplateColumn2 = new DataGridTemplateColumn();
			FrameworkElementFactory frameworkElementFactory2 = new FrameworkElementFactory(typeof(TextBlock));
			FrameworkElementFactory frameworkElementFactory3 = new FrameworkElementFactory(typeof(Hyperlink));
			Style style = new Style(typeof(global::System.Windows.Documents.Hyperlink))
			{
				Setters = { (SetterBase)new Setter(Inline.TextDecorationsProperty, TextDecorations.Underline) }
			};
			frameworkElementFactory3.SetValue(FrameworkContentElement.StyleProperty, style);
			DataTrigger item = new DataTrigger
			{
				Binding = new Binding("IsSelected")
				{
					RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(DataGridCell), 1)
				},
				Value = true,
				Setters = { (SetterBase)new Setter(TextElement.ForegroundProperty, Brushes.White) }
			};
			style.Triggers.Add(item);
			FrameworkElementFactory frameworkElementFactory4 = new FrameworkElementFactory(typeof(Run));
			frameworkElementFactory4.SetBinding(Run.TextProperty, new Binding(tableField_0.FieldKey));
			frameworkElementFactory3.AppendChild(frameworkElementFactory4);
			frameworkElementFactory3.AddHandler(Hyperlink.ClickEvent, new RoutedEventHandler(_003C_003Ec__DisplayClass16_.G9ivsecK5Ct));
			frameworkElementFactory2.AppendChild(frameworkElementFactory3);
			dataGridTemplateColumn2.CellTemplate = new DataTemplate
			{
				VisualTree = frameworkElementFactory2
			};
			return dataGridTemplateColumn2;
		}
		return new DataGridTextColumn
		{
			Binding = new Binding(tableField_0.FieldKey)
		};
	}

	private void GnltuJ3oNmO(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2 && sender is Image image)
		{
			_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
			_003C_003Ec__DisplayClass17_.z3Wvsbsc6WD = image.Tag as string;
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass17_.Cdkvs1wHuV6);
			e.Handled = true;
		}
	}

	[AsyncStateMachine(typeof(_003CBtnAdd_Click_003Ed__25))]
	private void JFLtu01jNFp(object sender, RoutedEventArgs e)
	{
		_003CBtnAdd_Click_003Ed__25 stateMachine = default(_003CBtnAdd_Click_003Ed__25);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CListViewItem_MouseDoubleClick_003Ed__26))]
	private void p3wtuCpc9Mn(object sender, MouseButtonEventArgs e)
	{
		_003CListViewItem_MouseDoubleClick_003Ed__26 stateMachine = default(_003CListViewItem_MouseDoubleClick_003Ed__26);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditItemAsync_003Ed__28))]
	private Task JYatuP4kshy(DataRow dataRow_0, bool bool_2 = false)
	{
		_003CEditItemAsync_003Ed__28 stateMachine = default(_003CEditItemAsync_003Ed__28);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.row = dataRow_0;
		stateMachine.isReadonly = bool_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnEdit_Click_003Ed__29))]
	private void D7LtuEaJ3kl(object sender, RoutedEventArgs e)
	{
		_003CBtnEdit_Click_003Ed__29 stateMachine = default(_003CBtnEdit_Click_003Ed__29);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void zn3tuyn2dgP(object sender, RoutedEventArgs e)
	{
		DataRow dataRow = ((sender as FrameworkElement)?.Tag as DataRowView)?.Row;
		if (dataRow == null || !AppHelper.Confirm("您确认要删除此行么？"))
		{
			return;
		}
		try
		{
			dataRow.Delete();
		}
		catch (Exception)
		{
		}
	}

	private void EAXtu8ClCMK(object sender, RoutedEventArgs e)
	{
		try
		{
			XFBtueaGZrW.AcceptChanges();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法合并数据更改。" + ex.Message, true);
			return;
		}
		if (HjltuGchDgi.IsEither(GridSelectionMode.RowsRequired, GridSelectionMode.OneRowRequired) && TheGrid.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请至少选择一行。");
		}
		else
		{
			this.ThNvuM5Q9GQ(true);
		}
	}

	private void IwHtua4RX50(object sender, RoutedEventArgs e)
	{
		if (guFtuIcKkvl || XFBtueaGZrW.GetChanges() == null || AppHelper.Confirm("您确认要丢弃所有编辑内容么？"))
		{
			try
			{
				XFBtueaGZrW.RejectChanges();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法撤销数据更改。" + ex.Message, true);
				return;
			}
			this.ThNvuM5Q9GQ(false);
		}
	}

	[AsyncStateMachine(typeof(_003CRow_DoubleClick_003Ed__33))]
	private void lUNtu74onAL(object sender, MouseButtonEventArgs e)
	{
		_003CRow_DoubleClick_003Ed__33 stateMachine = default(_003CRow_DoubleClick_003Ed__33);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void JIttuRNfhcH(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要撤销所有修改么？"))
		{
			try
			{
				XFBtueaGZrW.RejectChanges();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法撤销数据更改。" + ex.Message, true);
			}
		}
	}

	private void FilterControl_OnFilterChanged(object sender, EventArgs e)
	{
		try
		{
			XFBtueaGZrW.DefaultView.RowFilter = FilterControl.FilterText;
		}
		catch (Exception ex)
		{
			XFBtueaGZrW.DefaultView.RowFilter = null;
			AppHelper.ShowWarning(ex.Message);
		}
	}

	private void FwUtuqsmuTI(object sender, DataGridAutoGeneratingColumnEventArgs e)
	{
		if (XFBtueaGZrW == null || !XFBtueaGZrW.Columns.Contains(e.PropertyName))
		{
			return;
		}
		e.Column.IsReadOnly = XFBtueaGZrW.Columns[e.PropertyName].ReadOnly;
		try
		{
			string caption = XFBtueaGZrW.Columns[e.PropertyName].Caption;
			if (!string.IsNullOrEmpty(caption))
			{
				e.Column.Header = caption;
			}
		}
		catch (Exception ex)
		{
			trptu14hSb5.Warn("生成列标题出错：" + ex.Message, ex);
		}
	}

	private void LHitucihj8v(object sender, EventArgs e)
	{
		TableDef tableDef = lK6tuYXqbiQ;
		if (tableDef == null || !tableDef.Fields.HasData())
		{
			TheGrid.Columns.Move(0, TheGrid.Columns.Count - 1);
		}
	}

	private void qyktuV7rSUo(object sender, RoutedEventArgs e)
	{
		if (TheGrid.SelectedCells.Count <= 0)
		{
			return;
		}
		HashSet<DataRow> hashSet = new HashSet<DataRow>();
		foreach (DataGridCellInfo selectedCell in TheGrid.SelectedCells)
		{
			if (selectedCell.Item is DataRowView dataRowView)
			{
				hashSet.Add(dataRowView.Row);
			}
		}
		foreach (DataRow item in hashSet)
		{
			item.Delete();
		}
	}

	[AsyncStateMachine(typeof(_003CMenuItem_CopyCreate_003Ed__43))]
	private void l2XtuZ98Rkj(object sender, RoutedEventArgs e)
	{
		_003CMenuItem_CopyCreate_003Ed__43 stateMachine = default(_003CMenuItem_CopyCreate_003Ed__43);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Yxntu9IRMHZ(object sender, RoutedEventArgs e)
	{
		if (TheGrid.ClipboardCopyMode == DataGridClipboardCopyMode.ExcludeHeader)
		{
			TheGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
			AppHelper.ShowInformation("开启复制表头");
			TheGrid.ContextMenu.Items.OfType<MenuItem>().First(_003C_003Ec.VyivsZ2lmMR ?? (_003C_003Ec.VyivsZ2lmMR = _003C_003Ec.xRKvscIYsyq.J8Qvs7I1n44)).Header = "关闭复制表头";
		}
		else
		{
			TheGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
			AppHelper.ShowInformation("关闭复制表头");
			TheGrid.ContextMenu.Items.OfType<MenuItem>().First(_003C_003Ec.qYjvs9p790R ?? (_003C_003Ec.qYjvs9p790R = _003C_003Ec.xRKvscIYsyq.VJfvsRkBjuo)).Header = "开启复制表头";
		}
	}

	private void WQStuhFCQdV(object sender, DataGridRowClipboardEventArgs e)
	{
		if (e.IsColumnHeadersRow && e.EndColumnDisplayIndex - e.StartColumnDisplayIndex <= 0)
		{
			e.ClipboardRowContent.RemoveAll(_003C_003Ec.r82vsh8geGq ?? (_003C_003Ec.r82vsh8geGq = _003C_003Ec.xRKvscIYsyq.mxZvsqnNMhj));
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!dgHtuXZ9Bi5)
		{
			dgHtuXZ9Bi5 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/tables/tablemanagewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 2:
			TxtHelpText = (TextBlock)target;
			return;
		case 3:
			TheGrid = (DataGrid)target;
			TheGrid.AutoGeneratedColumns += LHitucihj8v;
			TheGrid.AutoGeneratingColumn += FwUtuqsmuTI;
			TheGrid.CopyingRowClipboardContent += WQStuhFCQdV;
			return;
		case 5:
			((MenuItem)target).Click += l2XtuZ98Rkj;
			return;
		case 6:
			((MenuItem)target).Click += qyktuV7rSUo;
			return;
		case 7:
			MenuCopyMode = (MenuItem)target;
			MenuCopyMode.Click += Yxntu9IRMHZ;
			return;
		case 8:
			ogQtu62p9PL = (DataGridTemplateColumn)target;
			return;
		default:
			dgHtuXZ9Bi5 = true;
			return;
		case 11:
			BtnAdd = (Button)target;
			BtnAdd.Click += JFLtu01jNFp;
			return;
		case 12:
			FilterControl = (FilterBoxControl)target;
			return;
		case 13:
			BtnRestore = (Button)target;
			BtnRestore.Click += JIttuRNfhcH;
			num = 0;
			if (A9aQxgQ2ZZlC8O3oaylO != null)
			{
				int num2 = default(int);
				num = num2;
			}
			break;
		case 14:
			BtnOk = (Button)target;
			BtnOk.Click += EAXtu8ClCMK;
			return;
		case 15:
			BtnCancel = (Button)target;
			num = 1;
			if (A9aQxgQ2ZZlC8O3oaylO != null)
			{
				return;
			}
			break;
		}
		switch (num)
		{
		case 1:
			BtnCancel.Click += IwHtua4RX50;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 4:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(lUNtu74onAL);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		case 1:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			if (A9aQxgQ2ZZlC8O3oaylO == null)
			{
				switch (0)
				{
				}
			}
			eventSetter.Handler = new MouseButtonEventHandler(p3wtuCpc9Mn);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		case 10:
			((Button)target).Click += zn3tuyn2dgP;
			break;
		case 9:
			((Button)target).Click += D7LtuEaJ3kl;
			break;
		}
	}

	static TableManageWindow()
	{
		trptu14hSb5 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool N2ARgYQ25Nln3ucJFpU3()
	{
		return A9aQxgQ2ZZlC8O3oaylO == null;
	}
}
