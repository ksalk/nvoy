namespace Nvoy.Agents;

public interface INvoyAgentFactory
{
    /// <summary>
    /// Creates an instance of INvoyAgent.
    /// </summary>
    /// <param name="configureOptions">The action to configure the agent options.</param>
    /// <returns>An instance of INvoyAgent.</returns>
    INvoyAgent CreateAgent(Action<NvoyAgentOptions> configureOptions);
}