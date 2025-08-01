using Microsoft.Extensions.Options;
using OpenAI;
using OpenAI.Chat;

namespace Nvoy.Clients;

internal class NvoyOpenAIChatClient : INvoyChatClient
{
    private readonly NvoyOpenAIOptions _options;
    private readonly OpenAIClient _openAIClient;

    public NvoyOpenAIChatClient(IOptions<NvoyOpenAIOptions> options)
    {
        _options = options.Value;

        // Create OpenAI client
        _openAIClient = new OpenAIClient(new System.ClientModel.ApiKeyCredential(_options.ApiKey), new OpenAIClientOptions { Endpoint = new Uri(_options.ApiUrl!) });
    }

    public async Task<string> SendMessageAsync(string message, CancellationToken cancellationToken = default)
    {
        try
        {
            var _chatClient = _openAIClient.GetChatClient(_options.DefaultModel);
            var chatCompletion = await _chatClient.CompleteChatAsync(
                messages: [new UserChatMessage(message)],
                options: new ChatCompletionOptions
                {
                    //Temperature = (float)_options.Temperature,
                    //MaxOutputTokenCount = _options.MaxTokens
                },
                cancellationToken: cancellationToken);

            return chatCompletion.Value.Content[0].Text;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to send message to OpenAI: {ex.Message}", ex);
        }
    }
}
