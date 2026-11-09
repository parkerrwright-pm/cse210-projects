public class PromptGenerator
{
    private readonly List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "Who did you help today?",
        "What is something new you learned today?",
        "What are you grateful for today?",
        "What is one thing you would do differently today?",
        "What made you smile today?"
    };

    public string GetRandomPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }
}
