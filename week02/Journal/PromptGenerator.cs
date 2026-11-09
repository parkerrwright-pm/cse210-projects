public class PromptGenerator
{
    private readonly List<string> _prompts = new List<string>
    {
        "What moment from today would you like to remember, and where were you when it happened?",
        "Who did you talk with today, and what part of the conversation stands out?",
        "What small act of kindness did you give or receive today, and how did it affect you?",
        "When did you feel grateful or notice the hand of the Lord today?",
        "What was your strongest emotion today, and what happened just before you felt it?",
        "What challenge did you face today, and what did you learn from how you handled it?",
        "What sight, sound, smell, or taste from today brings a specific moment back to mind?",
        "If you could relive one moment from today, what would you keep the same or do differently?"
    };

    public string GetRandomPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }
}
