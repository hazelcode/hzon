namespace HazelCode.Hzon;

public class Lexer
{
    private Stack<char> remainingText { get; set; }
    public Lexer(string content)
    {
        // Convert the entire string into a stack of characters
        if(string.IsNullOrEmpty(content))
        {
            // Prevent exceptions while creating and reversing an array of an empty text
            remainingText = [];
        }

        remainingText = new Stack<char>(content.ToCharArray().Reverse());
    }

    public IDataRecipient GetData()
    {
        throw new NotImplementedException();
    }
}