namespace Nvoy.Clients;

public interface INvoyChatClient
{
    Task<string> SendMessageAsync(string message, CancellationToken cancellationToken = default);
}
