namespace Quicker.Common;

public enum ActionReviewState
{
	NA = 0,
	NotSubmitted = 1,
	PendingReview = 2,
	ReviewFailed = 11,
	PASS_START = 20,
	ReviewPassed = 21,
	AutoReviewed = 22,
	OldActions = 23
}
