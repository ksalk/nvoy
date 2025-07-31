namespace Nvoy.Clients;

public interface INvoyClient
{
    Task<string> SendMessageAsync(string message, CancellationToken cancellationToken = default);
}
