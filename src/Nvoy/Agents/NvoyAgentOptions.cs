namespace Nvoy.Agents;

public class NvoyAgentOptions
{
    public string? AgentName { get; set; }
    public string? ApiKey { get; set; }
    public string? ApiUrl { get; set; }
    public string Model { get; set; } = "openai/gpt-4.1-nano";

    /// <summary>
    /// Sets the model for the agent.
    /// </summary>
    /// <param name="model">The model to use.</param>
    /// <returns>The options instance for fluent configuration.</returns>
    public NvoyAgentOptions WithModel(string model)
    {
        Model = model;
        return this;
    }

    /// <summary>
    /// Sets the agent type.
    /// </summary>
    /// <param name="agentName">The name of the agent.</param>
    /// <returns>The options instance for fluent configuration.</returns>
    public NvoyAgentOptions WithAgentName(string agentName)
    {
        AgentName = agentName;
        return this;
    }

    /// <summary>
    /// Sets the API key for the agent.
    /// </summary>
    /// <param name="apiKey">The API key to use.</param>
    /// <returns>The options instance for fluent configuration.</returns>
    public NvoyAgentOptions WithApiKey(string apiKey)
    {
        ApiKey = apiKey;
        return this;
    }

    /// <summary>
    /// Sets the API URL for the agent.
    /// </summary>
    /// <param name="apiUrl">The API URL to use.</param>
    /// <returns>The options instance for fluent configuration.</returns>
    public NvoyAgentOptions WithApiUrl(string apiUrl)
    {
        ApiUrl = apiUrl;
        return this;
    }
}