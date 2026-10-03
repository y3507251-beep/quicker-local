using System.Threading.Tasks;

namespace OpenAI_API.Moderation;

public interface IModerationEndpoint
{
	ModerationRequest DefaultModerationRequestArgs { get; set; }

	Task<ModerationResult> CallModerationAsync(ModerationRequest request);

	Task<ModerationResult> CallModerationAsync(string input);
}
