using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CompiledLanguages.Languages;

/// <summary>Rust: its files, highlighting, comments and brackets.</summary>
public sealed class RustLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Rust { get; } = new("rust", "Rust")
    {
        Extensions = [".rs"],
        ScopeName = "source.rust",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition RustGrammar { get; } = GrammarFiles.Find("source.rust", "rust/rust.tmLanguage.json");
}
