using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CompiledLanguages.Languages;

/// <summary>Pascal: its files, highlighting, comments and brackets.</summary>
public sealed class PascalLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Pascal { get; } = new("pascal", "Pascal")
    {
        Extensions = [".pas", ".pp"],
        ScopeName = "source.pascal",
        LineComment = "//",
        BlockComment = ("(*", "*)"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition PascalGrammar { get; } = GrammarFiles.Find("source.pascal", "pascal/pascal.tmLanguage.json");
}
