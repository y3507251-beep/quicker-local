using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Markup;
using Newtonsoft.Json;
using Ninject;
using Ninject.Parameters;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Modules.VersionUpdate;
using Quicker.Properties;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.X;

namespace Quicker.View;

public class SharedActionInfoWindow : Window, IComponentConnector
{
	private readonly SharedActionDto ldGLtWUc4VV;

	private readonly ActionItem TcFLtkX1omu;

	private readonly ActionItem US3LtGdCahN;

	internal ActionButton BtnAction;

	internal Button BtnViewAction;

	internal TextBlock TxtName;

	internal TextBlock TxtDescription;

	internal TextBlock LblNote;

	internal TextBlock LblSharedMethod;

	internal TextBlock LblValidFor;

	internal TextBlock LblApplyFor;

	internal TextBlock LblCategory;

	internal TextBlock LblInstallAlert;

	internal TextBlock LblAuthor;

	internal TextBlock LblRevision;

	internal TextBlock LblUpdateTime;

	internal TextBlock LblChangeLog;

	internal TextBlock LblUseCount;

	internal TextBlock TxtVerifyData;

	internal ProgressBar PbVerify;

	internal TextBlock LblVoteCount;

	internal TextBlock LblCommentCount;

	internal TextBlock LblLastComment;

	internal TextBlock LblUserLimit;

	internal Hyperlink LnkAction;

	internal StackPanel PnlVersionWarning;

	internal TextBlock LblVersionWarning;

	internal StackPanel PnlRiskyWarning;

	internal TextBlock LblRiskyWarning;

	internal StackPanel PnlDuplicateWarning;

	internal TextBlock LblDuplicateWarning;

	internal TextBlock LblOverwriteWarning;

	internal ToggleButton ChkAutoUpdate;

	internal Button BtnOk;

	internal Button BtnViewAction1;

	private bool l3LLtsGrSqU;

	private static SharedActionInfoWindow UdrL5rF2QGlQivqWMC4T;

	public bool AutoUpdate
	{
		get
		{
			return false;
		}
		set
		{
			ChkAutoUpdate.IsChecked = false;
		}
	}

	public SharedActionInfoWindow(SharedActionDto sharedAction, ActionItem oldAction)
	{
		ldGLtWUc4VV = sharedAction;
		TcFLtkX1omu = oldAction;
		US3LtGdCahN = ldGLtWUc4VV.CreateActionItem(false);
		InitializeComponent();
		ChkAutoUpdate.IsChecked = false;
		ChkAutoUpdate.Visibility = Visibility.Collapsed;
		LnkAction.NavigateUri = new Uri(AppHelper.CreateSharedActionLink(ldGLtWUc4VV.Id.ToString()));
		base.Loaded += hXkLtZkCvvu;
		LblOverwriteWarning.Visibility = (oldAction != null).ToVisibility();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void hXkLtZkCvvu(object sender, RoutedEventArgs e)
	{
		BtnAction.ActionItem = US3LtGdCahN;
		TxtName.Text = ldGLtWUc4VV.Title;
		TxtDescription.Text = ldGLtWUc4VV.Description;
		LblSharedMethod.Text = (ldGLtWUc4VV.IsPublic ? "公开" : "临时");
		LblApplyFor.Text = (string.IsNullOrEmpty(ldGLtWUc4VV.ExeFile) ? CommonStrings.CommonExeInfo_Common_Name : ldGLtWUc4VV.ExeFile);
		LblCategory.Text = ldGLtWUc4VV.Tags;
		LblNote.Text = ldGLtWUc4VV.Note;
		LblInstallAlert.Text = ldGLtWUc4VV.InstallAlert;
		LblAuthor.Text = ldGLtWUc4VV.UserNickName;
		LblUpdateTime.Text = (ldGLtWUc4VV.LastUpdateTimeUtc.HasValue ? ldGLtWUc4VV.LastUpdateTimeUtc.Value.ToLocalTime().ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) : "");
		LblRevision.Text = ldGLtWUc4VV.Revision.ToString(CultureInfo.InvariantCulture);
		LblUseCount.Text = ldGLtWUc4VV.UseCount.ToString(CultureInfo.InvariantCulture);
		LblVoteCount.Text = ((ldGLtWUc4VV.VoteCount < 1) ? "暂无" : ldGLtWUc4VV.VoteCount.ToString(CultureInfo.InvariantCulture));
		LblCommentCount.Text = ldGLtWUc4VV.CommentCount.ToString(CultureInfo.InvariantCulture);
		LblLastComment.Text = ((!ldGLtWUc4VV.LastCommentTimeUtc.HasValue) ? "暂无" : ldGLtWUc4VV.LastCommentTimeUtc.Value.ToLocalTime().ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
		LblChangeLog.Text = ldGLtWUc4VV.ChangeLog;
		int num = 0;
		if (!m1go5SF2FT3pRLpo6bcg())
		{
			goto IL_0260;
		}
		goto IL_0287;
		IL_0287:
		switch (num)
		{
		case 1:
			PbVerify.Maximum = ldGLtWUc4VV.TotalVerify;
			PbVerify.Value = ldGLtWUc4VV.SuccessCount;
			LblUserLimit.Text = ldGLtWUc4VV.UserLimitation.GetEnumDisplayName();
			oE2LthL4LQe();
			uRpLt9DpZBB();
			return;
		}
		goto IL_0260;
		IL_0260:
		TxtVerifyData.Text = ldGLtWUc4VV.VerifyData;
		num = 1;
		if (UdrL5rF2QGlQivqWMC4T != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0287;
	}

	private void uRpLt9DpZBB()
	{
		ActionItem actionItem = ldGLtWUc4VV.CreateActionItem(false);
		XAction xAction = default(XAction);
		int num;
		if (actionItem.ActionType == ActionType.RunScriptFile)
		{
			LblRiskyWarning.Text = "此动作中包含脚本，请检查确认脚本内容无害后使用。";
		}
		else if (actionItem.ActionType == ActionType.XAction)
		{
			xAction = JsonConvert.DeserializeObject<XAction>(actionItem.Data);
			num = 1;
			if (!m1go5SF2FT3pRLpo6bcg())
			{
				goto IL_006f;
			}
			goto IL_0081;
		}
		goto IL_0102;
		IL_0081:
		if (xAction != null)
		{
			IList<IStepRunner> riskySteps = XActionHelper.GetRiskySteps(xAction);
			if (riskySteps.HasData())
			{
				StringBuilder stringBuilder = new StringBuilder(100);
				stringBuilder.Append("此动作使用了这些可能有风险的模块:");
				foreach (IStepRunner item in riskySteps)
				{
					stringBuilder.Append("\n - ");
					stringBuilder.Append(item.Name);
				}
				LblRiskyWarning.Text = stringBuilder.ToString();
			}
		}
		goto IL_0102;
		IL_006f:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0128;
		}
		goto IL_0081;
		IL_0128:
		PnlDuplicateWarning.Visibility = AppState.DataService.d2ctXSU2gt9(ldGLtWUc4VV.Id.ToString()).Any(t9rLtIDmONm).ToVisibility();
		return;
		IL_0102:
		if (string.IsNullOrEmpty(LblRiskyWarning.Text))
		{
			PnlRiskyWarning.Visibility = Visibility.Collapsed;
			num = 0;
			if (UdrL5rF2QGlQivqWMC4T == null)
			{
				goto IL_006f;
			}
		}
		else
		{
			PnlRiskyWarning.Visibility = Visibility.Visible;
		}
		goto IL_0128;
	}

	private void oE2LthL4LQe()
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(ldGLtWUc4VV.SoftVersion) && SoftVersionHelper.IsVersionNewer(ldGLtWUc4VV.SoftVersion, AppHelper.GetCurrAppVersion()))
		{
			flag = true;
			LblVersionWarning.Text = "Quicker软件版本较旧，动作可能无法正常运行。\n当前版本：" + AppHelper.GetCurrAppVersion() + "，动作来源版本：" + ldGLtWUc4VV.SoftVersion + "。";
		}
		PnlVersionWarning.Visibility = ((!flag) ? Visibility.Collapsed : Visibility.Visible);
	}

	private void cItLte0ikYC(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
	}

	private void WdaLtYtWlXj(object sender, RoutedEventArgs e)
	{
		if (ldGLtWUc4VV != null && ldGLtWUc4VV.ActionType == ActionType.XAction)
		{
			ActionDesignerWindow actionDesignerWindow = new ActionDesignerWindow(null, US3LtGdCahN, false, true);
			actionDesignerWindow.Owner = this;
			actionDesignerWindow.IsReadonly = true;
			actionDesignerWindow.ShowDialog();
		}
		else
		{
			ActionEditorWindow actionEditorWindow = AppState.dAntabrFWrV().Get<ActionEditorWindow>(Array.Empty<IParameter>());
			actionEditorWindow.Owner = this;
			actionEditorWindow.IsReadonly = true;
			actionEditorWindow.EditingActionItem = US3LtGdCahN;
			actionEditorWindow.ShowDialog();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!l3LLtsGrSqU)
		{
			l3LLtsGrSqU = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/share/sharedactioninfowindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			l3LLtsGrSqU = true;
			break;
		case 1:
			BtnAction = (ActionButton)target;
			num = 1;
			if (!m1go5SF2FT3pRLpo6bcg())
			{
				goto IL_020a;
			}
			goto IL_020e;
		case 2:
			BtnViewAction = (Button)target;
			BtnViewAction.Click += WdaLtYtWlXj;
			break;
		case 3:
			TxtName = (TextBlock)target;
			break;
		case 4:
			TxtDescription = (TextBlock)target;
			break;
		case 5:
			LblNote = (TextBlock)target;
			break;
		case 6:
			LblSharedMethod = (TextBlock)target;
			break;
		case 7:
			LblValidFor = (TextBlock)target;
			break;
		case 8:
			LblApplyFor = (TextBlock)target;
			break;
		case 9:
			LblCategory = (TextBlock)target;
			break;
		case 10:
			LblInstallAlert = (TextBlock)target;
			break;
		case 11:
			LblAuthor = (TextBlock)target;
			break;
		case 12:
			LblRevision = (TextBlock)target;
			break;
		case 13:
			LblUpdateTime = (TextBlock)target;
			break;
		case 14:
			LblChangeLog = (TextBlock)target;
			num = 0;
			if (UdrL5rF2QGlQivqWMC4T != null)
			{
				break;
			}
			goto IL_020e;
		case 15:
			LblUseCount = (TextBlock)target;
			break;
		case 16:
			TxtVerifyData = (TextBlock)target;
			break;
		case 17:
			PbVerify = (ProgressBar)target;
			break;
		case 18:
			LblVoteCount = (TextBlock)target;
			break;
		case 19:
			LblCommentCount = (TextBlock)target;
			break;
		case 20:
			LblLastComment = (TextBlock)target;
			break;
		case 21:
			LblUserLimit = (TextBlock)target;
			break;
		case 22:
			LnkAction = (Hyperlink)target;
			break;
		case 23:
			PnlVersionWarning = (StackPanel)target;
			num = 2;
			if (!m1go5SF2FT3pRLpo6bcg())
			{
				goto IL_020a;
			}
			goto IL_020e;
		case 24:
			LblVersionWarning = (TextBlock)target;
			break;
		case 25:
			PnlRiskyWarning = (StackPanel)target;
			break;
		case 26:
			LblRiskyWarning = (TextBlock)target;
			break;
		case 27:
			PnlDuplicateWarning = (StackPanel)target;
			break;
		case 28:
			LblDuplicateWarning = (TextBlock)target;
			break;
		case 29:
			LblOverwriteWarning = (TextBlock)target;
			break;
		case 30:
			ChkAutoUpdate = (ToggleButton)target;
			break;
		case 31:
			BtnOk = (Button)target;
			BtnOk.Click += cItLte0ikYC;
			break;
		case 32:
			{
				BtnViewAction1 = (Button)target;
				BtnViewAction1.Click += WdaLtYtWlXj;
				break;
			}
			IL_020a:
			num = num2;
			goto IL_020e;
			IL_020e:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private bool t9rLtIDmONm(ActionItem actionItem_2)
	{
		return actionItem_2.Id != TcFLtkX1omu?.Id;
	}

	internal static bool m1go5SF2FT3pRLpo6bcg()
	{
		return UdrL5rF2QGlQivqWMC4T == null;
	}
}
