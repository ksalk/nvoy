namespace Nvoy.Agents;

public interface INvoyAgent
{
    Task<string> ProcessMessageAsync(string message, CancellationToken cancellationToken = default);
}