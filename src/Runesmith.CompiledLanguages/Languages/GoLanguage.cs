using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CompiledLanguages.Languages;

/// <summary>Go: its files, highlighting, comments and brackets.</summary>
public sealed class GoLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Go { get; } = new("go", "Go")
    {
        Extensions = [".go"],
        ScopeName = "source.go",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition GoGrammar { get; } = GrammarFiles.Find("source.go", "go/go.tmLanguage.json");
}
