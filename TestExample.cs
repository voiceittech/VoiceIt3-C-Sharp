using System;
using VoiceIt3API;

/// Test script for VoiceIt3 C# SDK
class TestExample {
    static void Main(string[] args) {
        string apiKey = Environment.GetEnvironmentVariable("VOICEIT_API_KEY") ?? "";
        string apiToken = Environment.GetEnvironmentVariable("VOICEIT_API_TOKEN") ?? "";

        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiToken)) {
            Console.WriteLine("Set VOICEIT_API_KEY and VOICEIT_API_TOKEN environment variables");
            return;
        }

        VoiceIt3 vi = new VoiceIt3(apiKey, apiToken);

        Console.WriteLine("CreateUser: " + vi.CreateUser());
        Console.WriteLine("GetAllUsers: " + vi.GetAllUsers());
        Console.WriteLine("CreateGroup: " + vi.CreateGroup("Test Group"));
        Console.WriteLine("GetAllGroups: " + vi.GetAllGroups());
        Console.WriteLine("GetPhrases: " + vi.GetPhrases("en-US"));

        Console.WriteLine("\nAll API calls completed successfully!");
    }
}
