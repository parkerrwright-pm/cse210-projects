namespace ScriptureMemorizer;

public class ScripturesLibrary
{
    private readonly List<Scripture> _scriptures = new()
    {
        new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, " +
            "that whosoever believeth in him should not perish, but have everlasting life."),

        new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."),

        new Scripture(
            new Reference("Psalm", 23, 1),
            "The LORD is my shepherd; I shall not want."),

        new Scripture(
            new Reference("Joshua", 1, 9),
            "Have not I commanded thee? Be strong and of a good courage; " +
            "be not afraid, neither be thou dismayed: for the LORD thy God is with thee " +
            "whithersoever thou goest."),

        new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the LORD with all thine heart; and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him, and he shall direct thy paths.")
    };

    public Scripture GetRandomScripture()
    {
        int index = Random.Shared.Next(_scriptures.Count);
        return _scriptures[index];
    }
}