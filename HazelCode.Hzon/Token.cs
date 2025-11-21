namespace HazelCode.Hzon;

public class Token
{
    public TokenType TokenType { get; set; }
    public string Value { get; set; }

    public Token(TokenType tokenType, string value)
    {
        TokenType = tokenType;
        Value = value;
    }
}