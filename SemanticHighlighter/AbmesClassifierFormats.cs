using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace SemanticHighlighter
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.Brace)]
    [Name(FormatConstants.Brace)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesBraceFormat : ClassificationFormatDefinition
    {
        public AbmesBraceFormat()
        {
            DisplayName = "Abmes Brace";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.Bracket)]
    [Name(FormatConstants.Bracket)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesBracketFormat : ClassificationFormatDefinition
    {
        public AbmesBracketFormat()
        {
            DisplayName = "Abmes Bracket";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.Parenthesis)]
    [Name(FormatConstants.Parenthesis)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesParenthesisFormat : ClassificationFormatDefinition
    {
        public AbmesParenthesisFormat()
        {
            DisplayName = "Abmes Parenthesis";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.Colon)]
    [Name(FormatConstants.Colon)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesColonFormat : ClassificationFormatDefinition
    {
        public AbmesColonFormat()
        {
            DisplayName = "Abmes Colon";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.Semicolon)]
    [Name(FormatConstants.Semicolon)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesSemicolonFormat : ClassificationFormatDefinition
    {
        public AbmesSemicolonFormat()
        {
            DisplayName = "Abmes Semicolon";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.Comma)]
    [Name(FormatConstants.Comma)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesCommaFormat : ClassificationFormatDefinition
    {
        public AbmesCommaFormat()
        {
            DisplayName = "Abmes Comma";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.AngleBracket)]
    [Name(FormatConstants.AngleBracket)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesAngleBracketFormat : ClassificationFormatDefinition
    {
        public AbmesAngleBracketFormat()
        {
            DisplayName = "Abmes Angle Bracket";
            ForegroundColor = Color.FromRgb(180, 180, 180);
        }
    }
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = FormatConstants.CodePenis)]
    [Name(FormatConstants.CodePenis)]
    [UserVisible(true)]
    [Order(After = Priority.High)]
    internal sealed class AbmesCodePenisFormat : ClassificationFormatDefinition
    {
        public AbmesCodePenisFormat()
        {
            DisplayName = "Abmes Code Penis";
            ForegroundColor = Color.FromRgb(216, 160, 223);
        }
    }
}
