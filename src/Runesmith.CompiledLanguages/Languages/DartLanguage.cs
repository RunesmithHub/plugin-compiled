using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CompiledLanguages.Languages;

/// <summary>Dart: its files, highlighting, comments and brackets.</summary>
public sealed class DartLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Dart { get; } = new("dart", "Dart")
    {
        Extensions = [".dart"],
        ScopeName = "source.dart",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition DartGrammar { get; } = GrammarFiles.Find("source.dart", "dart/dart.tmLanguage.json");
}
