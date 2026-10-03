using System;

namespace Quicker.Domain.SQL.Entities;

public interface ILocalDataEntity
{
	string Data { get; set; }

	DateTime LastUpdateTimeUtc { get; set; }

	int Revision { get; set; }

	bool IsDeleted { get; set; }

	DateTime? DeleteTimeUtc { get; set; }

	ItemSyncState SyncState { get; set; }

	string SyncErrorMessage { get; set; }
}
