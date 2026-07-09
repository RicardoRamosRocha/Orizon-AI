namespace OrizonAI.Infrastructure.Options;

public class OpenAIOptions
{
    public const string SectionName = "OpenAI";

    public string ApiKey { get; set; } = string.Empty;

    public string BaseUrl { get; set; } = "https://api.openai.com/v1/";

    public string DefaultModel { get; set; } = "gpt-5";

    public int TimeoutSeconds { get; set; } = 60;
}