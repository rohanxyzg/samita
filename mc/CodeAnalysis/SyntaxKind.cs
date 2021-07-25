namespace Samita.CodeAnalysis
{
    public enum SyntaxKind
    {
        // Tokens
        NumberToken,
        WhiteSpaceToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParanthesisToken,
        ClosedParanthesisToken,
        BadToken,
        EndOfFileToken,

        // Expressions
        LiteralExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}

