using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CompiledLanguages.Languages;

/// <summary>Swift: its files, highlighting, comments and brackets.</summary>
public sealed class SwiftLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Swift { get; } = new("swift", "Swift")
    {
        Extensions = [".swift"],
        ScopeName = "source.swift",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SwiftGrammar { get; } = GrammarFiles.Find("source.swift", "swift/swift.tmLanguage.json");
}
