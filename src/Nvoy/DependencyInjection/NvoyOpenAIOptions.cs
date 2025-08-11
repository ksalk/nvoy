namespace Nvoy;

public class NvoyOpenAIOptions
{
    public static string SectionName => "OpenAI";
    
    public string ApiKey { get; set; } = null!;
    public string? ApiUrl { get; set; }
    public string DefaultModel { get; set; } = "openai/gpt-4.1-nano";
}