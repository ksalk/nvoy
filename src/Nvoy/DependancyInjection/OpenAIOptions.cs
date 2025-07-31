namespace Nvoy.DependancyInjection;

public class OpenAIOptions
{
    public static string SectionName => "OpenAI";
    
    public string ApiKey { get; set; } = null!;
    public string ApiUrl { get; set; } = null!;
}