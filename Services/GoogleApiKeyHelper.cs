namespace Backend.Services;

/// <summary>
/// Helper to read Google API key from environment (GOOGLE_API_KEY).
/// Used for Gemini, Maps, and Speech-to-Text in student backends.
/// </summary>
public static class GoogleApiKeyHelper
{
    public static string? GetGoogleApiKey() => Environment.GetEnvironmentVariable("GOOGLE_API_KEY");
}
